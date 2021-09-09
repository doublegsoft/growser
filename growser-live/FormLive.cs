using ManageLiteAV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growser.Live
{
  public partial class FormLive : Form, ITRTCCloudCallback
  {

    private ITRTCCloud trtcCloud;

    private ITXDeviceManager txDeviceManager;

    private IntPtr handleCameraVideo;

    private bool isMouseDown = false;

    private Point formLocation;

    private Point mouseOffset;

    public FormLive()
    {
      InitializeComponent();

      trtcCloud = DataManager.GetInstance().trtcCloud;
      txDeviceManager = trtcCloud.getDeviceManager();

      trtcCloud.addCallback(this);
      trtcCloud.setLogLevel(TRTCLogLevel.TRTCLogLevelVerbose);
    }

    /// <summary>
    /// 用户进房前准备和进房后打开摄像头和麦克风
    /// </summary>
    /// <param name="params"></param>
    public void EnterRoom()
    {
      DataManager.GetInstance().roomId = 123;
      DataManager.GetInstance().userId = "120";
      // 设置进房所需的相关参数
      TRTCParams trtcParams = new TRTCParams();
      trtcParams.sdkAppId = GenerateTestUserSig.SDKAPPID;
      trtcParams.roomId = DataManager.GetInstance().roomId;
      trtcParams.userId = DataManager.GetInstance().userId;
      trtcParams.strRoomId = DataManager.GetInstance().strRoomId;
      trtcParams.userSig = GenerateTestUserSig.GetInstance().GenTestUserSig(DataManager.GetInstance().userId);
      // 如果您有进房权限保护的需求，则参考文档{https://cloud.tencent.com/document/product/647/32240}完成该功能。
      // 在有权限进房的用户中的下面字段中添加在服务器获取到的privateMapKey。
      trtcParams.privateMapKey = "";
      trtcParams.businessInfo = "";
      trtcParams.role = DataManager.GetInstance().roleType;
      // 若您的项目有纯音频的旁路直播需求，请配置参数。
      // 配置该参数后，音频达到服务器，即开始自动旁路；
      // 否则无此参数，旁路在收到第一个视频帧之前，会将收到的音频包丢弃。
      if (DataManager.GetInstance().pureAudioStyle)
        trtcParams.businessInfo = "{\"Str_uc_params\":{\"pure_audio_push_mod\": 1}}";
      else
        trtcParams.businessInfo = "";

      // 用户进房
      trtcCloud.enterRoom(ref trtcParams, DataManager.GetInstance().appScene);

      //如果当前是视频通话模式，默认打开弱网降分辨率
      if (DataManager.GetInstance().appScene == TRTCAppScene.TRTCAppSceneVideoCall)
      {
        DataManager.GetInstance().videoEncParams.enableAdjustRes = true;
      }

      // 设置默认参数配置
      TRTCVideoEncParam encParams = DataManager.GetInstance().videoEncParams;   // 视频编码参数设置
      TRTCNetworkQosParam qosParams = DataManager.GetInstance().qosParams;      // 网络流控相关参数设置
      trtcCloud.setVideoEncoderParam(ref encParams);
      trtcCloud.setNetworkQosParam(ref qosParams);
      TRTCRenderParams renderParams = DataManager.GetInstance().GetRenderParams();
      trtcCloud.setLocalRenderParams(ref renderParams);
      trtcCloud.setVideoEncoderMirror(DataManager.GetInstance().isRemoteVideoMirror);
      // 设置美颜
      if (DataManager.GetInstance().isOpenBeauty)
        trtcCloud.setBeautyStyle(DataManager.GetInstance().beautyStyle, DataManager.GetInstance().beauty,
            DataManager.GetInstance().white, DataManager.GetInstance().ruddiness);

      // 设置大小流
      if (DataManager.GetInstance().pushSmallVideo)
      {
        TRTCVideoEncParam param = new TRTCVideoEncParam
        {
          videoFps = 25,
          videoBitrate = 100,
          videoResolution = TRTCVideoResolution.TRTCVideoResolution_640_480
        };
        trtcCloud.enableSmallVideoStream(true, ref param);
      }
      // 房间信息
      //mUserId = trtcParams.userId;
      //mRoomId = trtcParams.roomId;
      //this.roomLabel.Text = "房间号：" + trtcParams.roomId.ToString() + "   用户名：" + trtcParams.userId;
      //this.localUserLabel.Text = mUserId;

      // 处理是否纯音频模式
      bool audioCallStyle = DataManager.GetInstance().pureAudioStyle;
      if (audioCallStyle)
      {

      }
      else
      {
        StartLocalVideo();
      }
      // 如果不是观众角色进房，则打开本地摄像头采集和预览
      if (trtcParams.role != TRTCRoleType.TRTCRoleAudience)
        trtcCloud.startLocalAudio(DataManager.GetInstance().AudioQuality);

      InitLocalDevice();
    }

    /// <summary>
    /// 进房后的回调结果
    /// </summary>
    /// <param name="result">小于0：进房失败，错误结果会在 onError 回调显示</param>
    public void onEnterRoom(int result)
    {
      // 回调后的线程不一定在主线程，所以需要统一在回调的地方回到主线程操作，确保不导致跨线程操作 UI。
      if (this.IsHandleCreated)
      {
        this.Invoke(new Action(() =>
        {
          if (result >= 0)
          {
            // 进房成功
            DataManager.GetInstance().enterRoom = true;
            // 确保 SDK 内部的音频和视频采集是开启的。
            trtcCloud.muteLocalVideo(false);
            trtcCloud.muteLocalAudio(false);
            // 更新混流信息
            // UpdateMixTranCodeInfo();
          }
          else
          {
            // 进房失败
            DataManager.GetInstance().enterRoom = false;
          }
        }));
      }
    }

    public void onRemoteUserEnterRoom(string userId)
    {
      if (this.IsHandleCreated)
        this.BeginInvoke(new Action(() =>
        {
          // 添加远端进房用户信息
          
        }));
    }

    /// <summary>
    /// 用户是否开启摄像头视频
    /// </summary>
    public void onUserVideoAvailable(string userId, bool available)
    {
      this.BeginInvoke(new Action(() =>
      {
        if (available)
        {
          IntPtr ptr = this.panelRemote.Handle;
          TRTCRenderParams renderParams = DataManager.GetInstance().GetRenderParams();
          trtcCloud.setRemoteRenderParams(userId, TRTCVideoStreamType.TRTCVideoStreamTypeBig, ref renderParams);
          trtcCloud.startRemoteView(userId, TRTCVideoStreamType.TRTCVideoStreamTypeBig, ptr);
        }
        else
        {
          // 移除远端用户主流画面
          //int pos = GetRemoteVideoPosition(userId);
          //if (pos != -1)
          //{
          //  SetVisableInfoView(pos, true);
          //  mTRTCCloud.stopRemoteView(userId, TRTCVideoStreamType.TRTCVideoStreamTypeBig);
          //  if (mRenderMode == 2)
          //  {
          //    Panel panel = GetPanelAndSetUserId(pos, userId, false, false);
          //    if (panel != null)
          //      RemoveCustomVideoView(panel, userId, TRTCVideoStreamType.TRTCVideoStreamTypeBig);
          //  }
          //  // 关闭远端音量提示
          //  if (DataManager.GetInstance().isShowVolume)
          //    SetRemoteVoiceVisable(pos, false);
          //  RemoveVideoMeta(userId, TRTCVideoStreamType.TRTCVideoStreamTypeBig);
          //  UpdateMixTranCodeInfo();
          //}
        }
      }));
    }

    private void StartLocalVideo()
    {
      trtcCloud.startLocalPreview(handleCameraVideo);
      AddCustomVideoView(this.panelLocal, DataManager.GetInstance().userId, TRTCVideoStreamType.TRTCVideoStreamTypeBig, true);
    }

    private void StopLocalVideo()
    {
      trtcCloud.stopLocalPreview();
    }

    /// <summary>
    /// 初始化本地设备使用
    /// </summary>
    private void InitLocalDevice()
    {
      ITRTCDeviceCollection cameraList = txDeviceManager.getDevicesList(TRTCDeviceType.TXMediaDeviceTypeCamera);
      //mCurCameraDevice = "";
      //if (cameraList.getCount() > 0)
      //{
      //  ITRTCDeviceInfo camera = txDeviceManager.getCurrentDevice(TRTCDeviceType.TXMediaDeviceTypeCamera);
      //  mCurCameraDevice = camera.getDevicePID();
      //}
      cameraList.release();
      ITRTCDeviceCollection micList = txDeviceManager.getDevicesList(TRTCDeviceType.TXMediaDeviceTypeMic);
      //mCurMicDevice = "";
      //if (micList.getCount() > 0)
      //{
      //  ITRTCDeviceInfo mic = txDeviceManager.getCurrentDevice(TRTCDeviceType.TXMediaDeviceTypeMic);
      //  mCurMicDevice = mic.getDevicePID();
      //}
      micList.release();
      ITRTCDeviceCollection speakerList = txDeviceManager.getDevicesList(TRTCDeviceType.TXMediaDeviceTypeSpeaker);
      //mCurSpeakerDevice = "";
      //if (speakerList.getCount() > 0)
      //{
      //  ITRTCDeviceInfo speaker = txDeviceManager.getCurrentDevice(TRTCDeviceType.TXMediaDeviceTypeSpeaker);
      //  mCurSpeakerDevice = speaker.getDevicePID();
      //}
      speakerList.release();
    }

    private void AddCustomVideoView(Control parent, string userId, TRTCVideoStreamType streamType, bool local = false)
    {
      TXLiteVideoView videoView = new TXLiteVideoView();
      videoView.RegEngine(userId, streamType, trtcCloud, local);
      videoView.SetRenderMode(DataManager.GetInstance().videoFillMode);
      videoView.Size = new Size(parent.Width, parent.Height);
      parent.Controls.Add(videoView);
      string key = String.Format("{0}_{1}", userId, streamType);
    }

    public void onAudioDeviceCaptureVolumeChanged(uint volume, bool muted) { }

    public void onAudioDevicePlayoutVolumeChanged(uint volume, bool muted) { }

    [Obsolete("use ITXAudioEffectManager.startPlayMusic instead")]
    public void onAudioEffectFinished(int effectId, int code) { }

    public void onCameraDidReady() { }

    public void onConnectionLost() { }

    public void onConnectionRecovery() { }

    public void onConnectOtherRoom(string userId, TXLiteAVError errCode, string errMsg) { }

    public void onDeviceChange(string deviceId, TRTCDeviceType type, TRTCDeviceState state) { }

    public void onDisconnectOtherRoom(TXLiteAVError errCode, string errMsg) { }

    public void onError(TXLiteAVError errCode, string errMsg, IntPtr arg) { }

    public void onExitRoom(int reason) { }

    public void onFirstAudioFrame(string userId) { }

    public void onFirstVideoFrame(string userId, TRTCVideoStreamType streamType, int width, int height) { }

    public void onMicDidReady() { }

    public void onMissCustomCmdMsg(string userId, int cmdId, int errCode, int missed) { }

    public void onNetworkQuality(TRTCQualityInfo localQuality, TRTCQualityInfo[] remoteQuality, uint remoteQualityCount) { }

    [Obsolete("use ITXAudioEffectManager.ITXMusicPlayObserver instead")]
    public void onPlayBGMBegin(TXLiteAVError errCode) { }

    [Obsolete("use ITXAudioEffectManager.ITXMusicPlayObserver instead")]
    public void onPlayBGMComplete(TXLiteAVError errCode) { }

    [Obsolete("use ITXAudioEffectManager.ITXMusicPlayObserver instead")]
    public void onPlayBGMProgress(uint progressMS, uint durationMS) { }

    public void onRecvCustomCmdMsg(string userId, int cmdID, uint seq, byte[] msg, uint msgSize) { }

    public void onRecvSEIMsg(string userId, byte[] message, uint msgSize) { }

    public void onRemoteUserLeaveRoom(string userId, int reason) { }

    public void onScreenCaptureCovered() { }

    public void onScreenCapturePaused(int reason) { }

    public void onScreenCaptureResumed(int reason) { }

    public void onScreenCaptureStarted() { }

    public void onScreenCaptureStoped(int reason) { }

    public void onSendFirstLocalAudioFrame() { }

    public void onSendFirstLocalVideoFrame(TRTCVideoStreamType streamType) { }

    public void onSetMixTranscodingConfig(int errCode, string errMsg) { }

    public void onSpeedTest(TRTCSpeedTestResult currentResult, uint finishedCount, uint totalCount) { }

    public void onStartPublishCDNStream(int errCode, string errMsg) { }

    public void onStartPublishing(int errCode, string errMsg) { }

    public void onStatistics(TRTCStatistics statis) { }

    public void onStopPublishCDNStream(int errCode, string errMsg) { }

    public void onStopPublishing(int errCode, string errMsg) { }

    public void onSwitchRole(TXLiteAVError errCode, string errMsg) { }

    public void onSwitchRoom(TXLiteAVError errCode, string errMsg) { }

    public void onTestMicVolume(uint volume) { }

    public void onTestSpeakerVolume(uint volume) { }

    public void onTryToReconnect() { }

    public void onUserAudioAvailable(string userId, bool available) { }

    [Obsolete("Please use the latest method(onRemoteUserEnterRoom).")]
    public void onUserEnter(string userId) { }

    [Obsolete("Please use the latest method(onRemoteUserLeaveRoom).")]
    public void onUserExit(string userId, int reason) { }

    public void onUserSubStreamAvailable(string userId, bool available) { }

    public void onUserVoiceVolume(TRTCVolumeInfo[] userVolumes, uint userVolumesCount, uint totalVolume) { }
    
    public void onWarning(TXLiteAVWarning warningCode, string warningMsg, IntPtr arg){ }

    private void panelControl_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.isMouseDown = true;
        this.formLocation = this.Location;
        this.mouseOffset = Control.MousePosition;
      }
    }

    private void panelControl_MouseMove(object sender, MouseEventArgs e)
    {
      if (this.isMouseDown)
      {
        Point pt = Control.MousePosition;
        int x = this.mouseOffset.X - pt.X;
        int y = this.mouseOffset.Y - pt.Y;

        this.Location = new Point(this.formLocation.X - x, this.formLocation.Y - y);
      }
    }

    private void panelControl_MouseUp(object sender, MouseEventArgs e)
    {
      this.isMouseDown = false;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void FormLive_FormClosing(object sender, FormClosingEventArgs e)
    {
      trtcCloud.exitRoom();
    }

    private void FormLive_Load(object sender, EventArgs e)
    {
      handleCameraVideo = this.panelLocal.Handle;
      EnterRoom();
    }
  }
}

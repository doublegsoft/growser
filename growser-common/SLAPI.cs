using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

/**
 * @brief 数据类型重定义(64位工程需要手动定义条件编译符号x64)
 */
#if x64
using SLPOINTER = System.UInt64;
using SLCLIENT = System.UInt64;
using SLREMOTE = System.UInt64;
#else
using SLPOINTER = System.UInt32;
using SLCLIENT = System.UInt32;
using SLREMOTE = System.UInt32;
#endif
using SLSESSION = System.UInt32;

namespace sunlogin
{
    /**
     * @brief SLAPI错误表
     */
    public enum SLERRCODE
    {
        //成功
        SLERRCODE_SUCCESSED = 0,

        //内部错误
        SLERRCODE_INNER = 1,

        //未初始化
        SLERRCODE_UNINITIALIZED = 2,

        //参数错误
        SLERRCODE_ARGS = 3,

        //不支持
        SLERRCODE_NOTSUPPORT = 4,

        //网络连接失败
        SLERRCODE_CONNECT_FAILED = 5,

        //网络连接超时
        SLERRCODE_CONNECT_TIMEOUT = 6,

        //会话不存在
        SLERRCODE_SESSION_NOTEXIST = 7,

        //会话溢出
        SLERRCODE_SESSION_OVERFLOW = 8,

        //会话类型错误
        SLERRCODE_SESSION_WRONGTYPE = 9,

		//OPENID过期
		SLERRCODE_EXPIRED = 10,

        //请求频繁
        SLERRCODE_REQUEST_FREQUENT = 11,
    };

    /**
     * @brief 会话选项
     */
    public enum ESLSessionOpt
    {
        eSLSessionOpt_window = 1,                    /*!< Window container */
        eSLSessionOpt_callback = 2,                  /*!< Callback */
        eSLSessionOpt_deviceSource = 3,              /*!< Device's source */
        eSLSessionOpt_connected = 4,                 /*!< Connect status */
        eSLSessionOpt_desktopctrl_listener = 5,      /*!< Desktop control listener */
        eSLSessionOpt_ipport = 6,                    /*!< Port forward ip and port */
        eSLSessionOpt_savepath = 7,                  /*!< File transfer save path */
        eSLSessionOpt_desktoptype = 8,               /*!< normal or microlive*/
        eSLSessionOpt_config = 9,					 /*!< session config */
    };

    /**
     * @brief 会话事件
     */
    public enum ESLSessionEvent
    {
        eSLSessionEvent_OnConnected = 1,          /*!< Session connected event */
        eSLSessionEvent_OnDisconnected = 2,       /*!< Session disconnected event */
        eSLSessionEvent_OnDisplayChanged = 3,     /*!< Display resolution is changed */
        eSLSessionEvent_OnNewFiletrans = 4,       /*!< Recv a new file transfer item */
        eSLSessionEvent_OnGetRemoteSysinfo = 5,   /*!< Recv remote sys info */
        eSLSessionEvent_OnRunNewInstance = 6,     /*Start new Instance for Server*/
        eSLSessionEvent_OnScreenshotData = 7, /*Recv Screenshot Data*/
    };

    /**
     * @brief 摄像头清晰度
     */
    public enum ESLVideoDefinition
    {
        eSLVideoDefinition_SD = 1,      /*!< Standard Definition 标清*/
        eSLVideoDefinition_HD = 2,      /*!< High Definition 高清*/
        eSLVideoDefinition_UHD = 3,     /*!< Ultra High-Definition 超清*/
    };

    /**
     * @brief 会话类型
     */
    public enum ESLSessionType
    {
        eSLSessionType_Desktop,     /*!< Remote Desktop session */
        eSLSessionType_File,        /*!< Remote File session */
        eSLSessionType_Cmd,         /*!< Remote CMD session */
        eSLSessionType_Sound,       /*!< Remote sound session */
        eSLSessionType_DataTrans,   /*!< Data transfer session */
        eSLSessionType_DesktopView, /*!< Remote desktop view mode session */
        eSLSessionType_Port,        /*!< Port forward session */
        eSLSessionType_FileTrans,   /*!< File transfer session */
        eSLSessionType_Camera,      /*!< Remote Camera session */
        eSLSessionType_Sysinfo,     /*!< Remote Sysinfo session */
        eSLSessionType_Screenshots, /*!< Remote Screenshots session */
        eSLSessionType_Permon,      /*!< Remote Permon session */
        eSLSessionType_Ssh,         /*!< Remote SSH session */
        eSLSessionType_Sound2,		/*!< Remote sound session(webrtc) */
    };

    /**
     * @brief 代理类型
     */
    public enum SLProxyType
    {
        SLProxy_None,
        SLProxy_HTTP,
        SLProxy_Socks5,
        SLProxy_Socks4,
        SLProxy_IE,
    };

    /**
     * @brief 此枚举用于隐藏远程桌面工具栏中的对应模块
     */
    public enum SLDesktopControlType
    {
        eSLDesktopControl_ALL,                      //整个工具栏
        eSLDesktopControl_SWITCH_SCREEN,            //切换屏幕
        eSLDesktopControl_CHAT,                     //聊天
        eSLDesktopControl_CAMERA,                   //摄像头引导
        eSLDesktopControl_FILE,                     //文件传输引导
        eSLDesktopControl_RECORD,                   //录像
        eSLDesktopControl_SCREENSHOT,               //截屏
        eSLDesktopControl_WHITE_BORAD,              //白板
        eSLDesktopControl_MORE,                     //更多
        eSLDesktopControl_FULL_SCREEN,              //全屏
        eSLDesktopControl_SCREEN_ORIGINAL_SIZE,     //屏幕原始尺寸
        eSLDesktopControl_DESKTOP_MODEL,            //桌面模式
        eSLDesktopControl_RESOLUTION,               //分辨率
        eSLDesktopControl_SWITCH_SESSION,           //切换会话
        eSLDesktopControl_SHORTCUT_KEY,             //快捷键
        eSLDesktopControl_BLACKSCREEN_MODE,         //黑屏模式
        eSLDesktopControl_FORBID_MOUSE_KEY,         //禁止对方输入
        eSLDesktopControl_SOUND,                    //声音
        eSLDesktopControl_SHORTCUT_CTRL,            //快捷键Ctrl+Alt+Delete
        eSLDesktopControl_SHORTCUT_LOCK,            //快捷键锁定
        eSLDesktopControl_SHORTCUT_LOGOUT,          //快捷键注销
        eSLDesktopControl_SHORTCUT_RESTART,         //快捷键重启
        eSLDesktopControl_SHORTCUT_SHUTDOWN,        //快捷键关机
        eSLDesktopControl_SHORTCUT_EXPLORER,        //快捷键资源管理器
        eSLDesktopControl_SHORTCUT_TASKMGR,         //快捷键任务管理器
        eSLDesktopControl_SHORTCUT_CONSOLE,         //快捷键控制台
    };

    /**
     * @brief 此枚举用于获取屏幕和会话的个数以及切换功能
     */
    public enum SLDesktopDevType
    {
        eSLDesktopDev_SCREEN,                   //屏幕
        eSLDesktopDev_SESSION,                  //会话
        eSLDesktopDev_RESOLUTION,               //分辨率
    };

    /**
     * @brief 此枚举用于获取某个模块当前状态或索引
     */
    public enum SLDesktopStateType
    {
        eSLDesktopState_SCREEN_ORIGINAL_SIZE,   //原始屏幕比例
        eSLDesktopState_FULL_SCREEN,            //全屏
        eSLDesktopState_SOUND,                  //声音
        eSLDesktopState_FORBID_MOUSE_KEY,       //禁止对方输入
        eSLDesktopState_WHITE_BORAD,            //白板
        eSLDesktopState_RESOLUTION,             //分辨率
        eSLDesktopState_BLACKSCREEN_MODE,       //黑屏模式
    };

    /**
     * @brief 此枚举用于设置远程桌面功模块的开启和关闭
     */
    public enum SLDesktopCommandType
    {
        eSLDesktopCommand_CTRL,                 //快捷键Ctrl+Alt+Delete
        eSLDesktopCommand_LOCK,                 //快捷键锁定
        eSLDesktopCommand_LOGOUT,               //快捷键注销
        eSLDesktopCommand_RESTART,              //快捷键重启
        eSLDesktopCommand_SHUTDOWN,             //快捷键关机
        eSLDesktopCommand_EXPLORER,             //快捷键资源管理器
        eSLDesktopCommand_TASKMGR,              //快捷键任务管理器
        eSLDesktopCommand_CONSOLE,              //快捷键控制台

        eSLDesktopCommand_WORK_MODEL,           //工作模式
        eSLDesktopCommand_ENTERTAINMENT_MODEL,  //娱乐模式
        eSLDesktopCommand_CHAT,                 //发起聊天

        eSLDesktopCommand_SCREEN_ORIGINAL_SIZE, //原始屏幕比例
        eSLDesktopCommand_FULL_SCREEN,          //进入或退出全屏
        eSLDesktopCommand_SOUND,                //开启或关闭声音
        eSLDesktopCommand_FORBID_MOUSE_KEY,     //禁止或允许对方输入
        eSLDesktopCommand_WHITE_BORAD,          //开启或关闭白板
        eSLDesktopCommand_BLACKSCREEN_MODE,     //开启或关闭黑屏模式
        eSLDesktopCommand_LOCAL_INPUT,          //开启或关闭本地输入法输入

        eSLDesktopCommand_SWITCH_SCREEN,        //切换屏幕
        eSLDesktopCommand_SWITCH_SESSION,       //切换会话
        eSLDesktopCommand_RESOLUTION,           //切换分辨率

        //only for android
        eSLDesktopCommand_PULL_DOWN_MENU,       //下拉菜单
        eSLDesktopCommand_VOLUME_INCREASE,      //音量+
        eSLDesktopCommand_VOLUME_DECREASE,      //音量-
        eSLDesktopCommand_HOME_KEY,             //home键
        eSLDesktopCommand_BACK_KEY,             //返回键
        eSLDesktopCommand_MENU_KEY,             //菜单键
        eSLDesktopCommand_LOCK_SCREEN,          //锁屏
        eSLDesktopCommand_SCROLL_UP,            //向上滚动
        eSLDesktopCommand_SCROLL_DOWM,          //向下滚动
    };

    /**
     * @brief 此枚举用于被控端平台
     */
    public enum SLPlatformType
    {
        eSLPlatformType_Windows,
        eSLPlatformType_Linux,
        eSLPlatformType_Mac,
        eSLPlatformType_Android,
        eSLPlatformType_Ios,
    };

    /**
     * @brief 被控制端事件
     */
    public enum SLCLIENT_EVENT
    {
        SLCLIENT_EVENT_ONCONNECT = 0,   //!< 连接成功
        SLCLIENT_EVENT_ONDISCONNECT,    //!< 断开连接
        SLCLIENT_EVENT_ONLOGIN,         //!< 登录成功
        SLCLIENT_EVENT_ONLOGINFAIL,     //!< 登录失败
        SLCLIENT_EVENT_ONCHANNELSFULL,  //!< 通道数已满
        SLCLIENT_EVENT_ONCHECKCFAIL,	//!< 检查通道数失败
    };

    //此枚举用于创建实例对象
    public enum SLObjInterfaceType
    {
        eSLObjInterface_AVIConverter,
        eSLObjInterface_CloudMonitor,
        eSLObjInterface_WakeupClient,
    };

    //此枚举用于声音会话类型
    public enum SLSoundSourceType
    {
        eSLSoundSourceType_Speaker,
        eSLSoundSourceType_Microphone,
        eSLSoundSourceType_TwoWayAudio,
    };

    public enum SLLanguageType
    {
        eSLLanguageType_zh_CN,
        eSLLanguageType_English,
    };


    /**
    * @brief 主控制端事件
    */
    public enum SLREMOTE_EVENT
    {
        SLREMOTE_EVENT_ONCONNECT = 0,           //!< 连接成功
        SLREMOTE_EVENT_ONDISCONNECT,            //!< 断开连接
        SLREMOTE_EVENT_ONDISCONNECT_FOR_FULL,   //!< 断开连接(因为连接数满了)
    };

    /** 
     * @brief 被控端绑定开机设备事件
     */
    public enum SLCLIENT_WOI_EVENT
    {
        SLCLIENT_WOI_EVENT_ONDISCOVER = 0,  //发现开机设备
        SLCLIENT_WOI_EVENT_ONBIND,          //绑定开机设备
        SLCLIENT_WOI_EVENT_ONUNBIND,        //解绑开机设备
    };

    /**
     * @brief 被控端UU事件
     */
    public enum SLCLIENT_UU_EVENT
    {
        SLCLIENT_UU_EVENT_ONUPGRADESTEP = 0,    //UU升级步骤
        SLCLIENT_UU_EVENT_ONSENDMOUSE,          //UU发送鼠标消息
        SLCLIENT_UU_EVENT_ONSENDKEYBOARD,       //UU发送键盘消息
    };

    /**
     * @brief 被控端启动模式
     */
    public enum SLMODE
    {
        UI = 0,
        SERVICE = 1,
    };

    /**
    * 代理类型
	*/
    public struct SLPROXY_INFO
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string ip;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string port;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string user;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string pwd;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 200)]
        public string domain;

        public SLProxyType type;   //ProxyType		
    };

    /**
     * 基础信息结构
     */
    public struct SLBASE_INFO
    {
        public UInt32 uIndex;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string name;
    };

    public struct CAMERA_INFO
    {
        public UInt32 uDeviceID;                        //唯一标识

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string szName;                           //摄像头名称
    };

    public struct SLINSTANCE_INFO
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szMod;                            //模块名称

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szName;                           //名称信息

        public UInt32 uID;                              //ID信息
        public UInt32 uPort;                            //转发端口
    };

    public struct SLKVM_INFO
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szSN;                             //控控sn号

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPassword;                       //控控密码

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string szIotServerAddr;                  //控控连接的iot服务器地址

        public UInt32 nIotPort;                         //控控连接的iot服务器端口
        public UInt32 nLoginType;                       //控控登录p2p服务器的方式，0-开发者ID登录 1-独立服务器登录

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szLoginAddr;                      //开发者ID或者独立服务器登录地址

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szLoginKey;                       //开发者Key或者独立服务器登录Session

        public UInt32 nTimeout;                         //控控创建的会话失效时间，需要在有效时间内连接控控
    };
    /*
     * @brief 会话回调事件函数类型
     */
    public delegate void SLSESSION_CALLBACK(SLSESSION session, ESLSessionEvent event_, IntPtr customdata, UInt32 size, SLPOINTER custom);    

    /**
     * @brief 会话回调属性
     */
    struct SLSESSION_CALLBACK_PROP
    {
        public SLSESSION_CALLBACK pfnCallback;  //!< 回调函数
        public SLPOINTER nCustom;               //!< 自定义数据

    };

    public static class slapi
    {
#if DEBUG
        const string dllName = "slsdk.dll";
#else
        const string dllName = "slsdk.dll";
#endif

        public const SLSESSION SLSESSION_INVAILD = SLSESSION.MaxValue;
        public const SLCLIENT SLCLIENT_INVAILD = 0;
        public const SLREMOTE SLREMOTE_INVAILD = 0;

        /*
         * @brief 初始化SLAPI环境
         * @desc 在使用任何SLAPI之前请先调用此API来初始化整个SLAPI环境，整个进程只需要调用一次即可
         * @return 是否初始化成功
         */
        [DllImport(dllName, EntryPoint = "SLInitialize")]
        public static extern bool SLInitialize();

        /*
         * @brief 退出SLAPI环境
         * @desc 建议在整个进程退出前调用，以释放SLAPI环境所使用的资源
         * @return 是否退出成功
         */
        [DllImport(dllName, EntryPoint = "SLUninitialize")]
        public static extern bool SLUninitialize();

        /*
         * @brief 获取最后的错误码
         * @return 返回SLERRCODE错误码
         */
        [DllImport(dllName, EntryPoint = "SLGetLastError")]
        public static extern SLERRCODE SLGetLastError();

        /*
         * @brief 设置最后的错误码
         * @param errCode 错误码
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetLastError", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLSetLastError(int err);

        /*
         * @brief 获取错误码详细说明
         * @return 详细信息，如果错误码不存在则返回“未知错误”
         */
        //[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "SLGetErrorDesc", CallingConvention = CallingConvention.Cdecl)]
        //public static extern string SLGetErrorDesc(SLERRCODE err);


        [System.Runtime.InteropServices.DllImportAttribute(dllName, EntryPoint = "SLGetErrorDesc", CallingConvention = CallingConvention.StdCall)]
        public static extern System.IntPtr SLGetErrorDesc(SLERRCODE errCode);

        /************************************************************************/
        /* 被控制端相关API                                                      */
        /************************************************************************/

        /*
         * @brief 设置全局的语言环境
         * @param eType 语言类型
         * @return 返回被控制端环境值，如果创建失败则返回UInt32_INVAILD
         */
        [DllImport(dllName, EntryPoint = "SLSetLanguage")]
        public static extern bool SLSetLanguage(SLLanguageType eType);

        /*
         * @brief 创建一个被控制端环境
         * @return 返回被控制端环境值，如果创建失败则返回UInt32_INVAILD
         */
        [DllImport(dllName, EntryPoint = "SLCreateClient")]
        public static extern SLCLIENT SLCreateClient();

        /*
         * @brief 创建一个被控制端环境
         * @param mode 指定UI模式或者Service模式
         * @return 返回被控制端环境值，如果创建失败则返回UInt32_INVAILD
         */
        [DllImport(dllName, EntryPoint = "SLCreateClientEx")]
        public static extern SLCLIENT SLCreateClientEx(SLMODE mode);

        /*
         * @brief 销毁一个被控制端环境
         * @param client 要销毁的被控制端环境
         */
        [DllImport(dllName, EntryPoint = "SLDestroyClient")]
        public static extern bool SLDestroyClient(SLCLIENT client);

        /*
         * @brief 被控制端回调事件
         * @param client 被控制端环境
         * @param event 事件
         * @param custom 用户自定义参数
         */
        public delegate void SLCLIENT_CALLBACK(SLCLIENT client, SLCLIENT_EVENT event_, SLPOINTER custom);

        /*
         * @brief 设置被控制端事件回调函数
         * @param client 被控制端环境
         * @param pfnCallback 回调函数地址
         * @param custom 用户自定义参数，回调时内部程序会将此参数一并回调
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetClientCallback")]
        public static extern bool SLSetClientCallback(SLCLIENT client, SLCLIENT_CALLBACK pfnCallback, SLPOINTER custom);

        /*
         * @brief 打开被控端日志
         * @param client 被控制端环境
         * @param path 路径
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLOpenClientLog")]
        public static extern bool SLOpenClientLog(SLCLIENT client, string path, string name = "");

        /*
         * @brief 被控制端登录服务器
         * @param client 被控制端环境
         * @param pstrOpenID 开发者的ID号
         * @param pstrOpenKey 开发者ID对应的验证码 
         * @param pstrDomain Oray提供的独立域名
         * @param bUseSSL 是否采用加密传输
         * @return 是否登录成功
         */
        [DllImport(dllName, EntryPoint = "SLClientLoginWithOpenID")]
        public static extern bool SLClientLoginWithOpenID(SLCLIENT client, string pstrOpenID, string pstrOpenKey, string pstrDomain = "", bool bUseSSL = false);

        /*
         * @brief 被控制端登录服务器
         * @param client 被控制端环境
         * @param szAddr 服务器地址
         * @param szLic lincense
         * @return 是否登录成功
         */
        [DllImport(dllName, EntryPoint = "SLClientLoginWithLicense")]
        public static extern bool SLClientLoginWithLicense(SLCLIENT client, string szAddr, string szLic);

        /*
         * @brief 被控制端注销登录服务器
         * @param client 被控制端环境
         * @return 是否注销登录成功
         */
        [DllImport(dllName, EntryPoint = "SLClientLogout")]
        public static extern bool SLClientLogout(SLCLIENT client);
        /*
         * @brief 被控制端是否登录中
         * @param client 被控制端环境
         */
        [DllImport(dllName, EntryPoint = "SLClientIsOnLoginned")]
        public static extern bool SLClientIsOnLoginned(SLCLIENT client);
        /*
         * @brief 在被控制端环境中创建一个会话
         * @param client 被控制端环境
         * @return 会话值，如果创建失败，则返回UInt32_INVAILD
         */
        [DllImport(dllName, EntryPoint = "SLCreateClientSession")]
        public static extern SLSESSION SLCreateClientSession(SLCLIENT client, ESLSessionType eType);

        /*
         * @brief 销毁一个会话
         * @param client 被控制端环境
         * @param session 会话
         * @return 是否销毁成功
         */
        [DllImport(dllName, EntryPoint = "SLDestroyClientSession")]
        public static extern bool SLDestroyClientSession(SLCLIENT client, SLSESSION session);

        /*
         * @brief 枚举被控端当前有多少个会话
         * @param client 被控制端环境
         * @param pSessionArray 会话数组（输出参数）
         * @param nArraySize 数组长度
         * @return 一个有多少个会话
         */
        [DllImport(dllName, EntryPoint = "SLEnumClientSession")]
        public static extern UInt16 SLEnumClientSession(SLCLIENT client, ref UInt32 pSessionArray, UInt16 nArraySize);

        /*
         * @brief 获取被控制端连接地址
         * @remark 必须在登录成功后再获取才能获取正确的值，即当回调事件UInt32_EVENT_ONLOGIN发生后调用。通过该值主控制端才能使用该会话的服务
         * @return 地址
         */
        [DllImport(dllName, EntryPoint = "SLGetClientAddress")]
        public static extern IntPtr SLGetClientAddress(SLCLIENT client);

        /*
         * @brief 获取被控制端某个会话的值
         * @remark 通过该值主控制端才能使用该会话的服务
         * @return 会话值，如果会话不存在则返回NULL
         */
        [DllImport(dllName, EntryPoint = "SLGetClientSessionName")]
        public static extern IntPtr SLGetClientSessionName(SLCLIENT client, SLSESSION session);

        /*
        * @brief 获得被控制端会话的连接信息
        * @param remote 被控制端环境
        * @param session 会话
        * @param connectType 连接类型
        * @param localType 是否是在同一局域网（公网IP相同） 0:公网IP不一致 1:公网IP一致
        * @return 是否获得成功
        */
        [DllImport(dllName, EntryPoint = "SLGetClientSessionConnection")]
        public static extern bool SLGetClientSessionConnection(SLCLIENT client, SLSESSION session,ref UInt32 connectType, ref UInt32 localType);

        /*
         * @brief 设置代理
         * @param client 被控制端环境
         * @param proxy 代理设置
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetClientProxy", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLSetClientProxy(SLCLIENT client, ref SLPROXY_INFO proxy);

        /*
        * @brief 测试代理
        * @param client 被控制端环境
        * @param proxy 代理设置
        * @return 测试代理是否连接成功
        */
        [DllImport(dllName, EntryPoint = "SLTestClientPorxy")]
        public static extern bool SLTestClientPorxy(SLCLIENT client, ref SLPROXY_INFO proxy);

        /*
         * @brief 被控制端某个会话发送数据
         * @param client 被控制端环境
         * @param session 会话
         * @param lpData 发送的数据
         * @param nLen 发送的数据长度
         * @return 发送的字节数
         * @remark 目前只适用于DataTrans类型的会话
         */
        [DllImport(dllName, EntryPoint = "SLClientSessionSendData")]
        public static extern UInt32 SLClientSessionSendData(SLCLIENT client, SLSESSION session, IntPtr lpData, UInt32 nLen);

        /*
         * @brief 被控制端某个会话接收数据
         * @param client 被控制端环境
         * @param session 会话
         * @param lpData 接收数据的缓冲区
         * @param nLen 准备接收的数据长度
         * @return 实际接收到的字节数
         * @remark 目前只适用于DataTrans类型的会话
         */
        [DllImport(dllName, EntryPoint = "SLClientSessionRecvData")]
        public static extern UInt32 SLClientSessionRecvData(SLCLIENT client, SLSESSION session, IntPtr lpData, UInt32 nLen);

        /*
         * @brief 获取被控制端某个会话某个属性值
         * @return 是否获取成功
         */
        [DllImport(dllName, EntryPoint = "SLGetClientSessionOpt")]
        public static extern bool SLGetClientSessionOpt(SLCLIENT client, SLSESSION session, ESLSessionOpt eOpt, IntPtr pOptVal, UInt16 nOptLen);

        /*
         * @brief 设置被控制端某个会话某个属性值
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetClientSessionOpt")]
        public static extern bool SLSetClientSessionOpt(SLCLIENT client, SLSESSION session, ESLSessionOpt eOpt, IntPtr pOptVal, UInt16 nOptLen);

        /*
         * @brief 开启WEB服务
         * @return 是否成功
         */
        [DllImport(dllName, EntryPoint = "SLStartWebServer")]
        public static extern bool SLStartWebServer(SLCLIENT client, UInt16 nPort = 0);

        /*
         * @brief 关闭WEB服务
         * @return 是否成功
         */
        [DllImport(dllName, EntryPoint = "SLStopWebServer")]
        public static extern bool SLStopWebServer(SLCLIENT client);

        /*
         * @brief web服务过滤方法，返回true表示已经处理了当前事件，底层将不会再处理
         * @param client 被控制端环境
         * @param data 指向数据的指针
         * @param size 数据长度
         */
        public delegate bool SLWEB_FILTER(SLCLIENT client, IntPtr data, SLPOINTER custom);

        /*
         * @brief 设置web服务过滤方法
         * @param client 被控制端环境
         * @param filter 函数指针
         */
        [DllImport(dllName, EntryPoint = "SlSetWebServerFilter")]
        public static extern bool SlSetWebServerFilter(SLCLIENT client, SLWEB_FILTER filter);

        /*
         * @brief 向web客户端发送数据
         * @param client 被控制端环境
         * @param data 指向数据的指针
         * @param size 数据长度
         */
        [DllImport(dllName, EntryPoint = "SlWebServerSend")]
        public static extern bool SlWebServerSend(SLCLIENT client, IntPtr pdata, UInt16 size);

        /*
         * @brief 被控制端发送文件给主控端
         * @param client 被控制端环境
         * @param session 会话
         * @param filepath 要发送的文件全路径
         * @param resume 是否断点续传
         * @return 当前传输文件的ID
         * @remark 目前只适用于fILETrans类型的会话
         */
        [DllImport(dllName, EntryPoint = "SLClientSendFile")]
        public static extern UInt32 SLClientSendFile(SLCLIENT client, SLSESSION session, IntPtr filepath, bool resume);

        /*
         * @brief 终止正在传输的文件
         * @param client 被控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 是否终止成功
         */
        [DllImport(dllName, EntryPoint = "SLClientKillFile")]
        public static extern bool SLClientKillFile(SLCLIENT client, SLSESSION session, UInt32 fid);

        /*
         * @brief 获得传输文件名称
         * @param client 被控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 文件名
         */
        [DllImport(dllName, EntryPoint = "SLClientGetFileName")]
        public static extern IntPtr SLClientGetFileName(SLCLIENT client, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID获取文件大小
         * @param client 被控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 文件大小
         */
        [DllImport(dllName, EntryPoint = "SLClientGetFileSize")]
        public static extern UInt64 SLClientGetFileSize(SLCLIENT client, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID获取文件已传输大小
         * @param client 被控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 已传输文件大小
         */
        [DllImport(dllName, EntryPoint = "SLClientGetFileTransfered")]
        public static extern UInt64 SLClientGetFileTransfered(SLCLIENT client, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID判断当前文件是否正在传输
         * @param client 被控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 是否正在传输
         */
        [DllImport(dllName, EntryPoint = "SLClientFileIsTransfering")]
        public static extern bool SLClientFileIsTransfering(SLCLIENT client, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID判断当前文件是否传输完成
         * @param client 被控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 已传输文件大小
         */
        [DllImport(dllName, EntryPoint = "SLClientFileIsDone")]
        public static extern bool SLClientFileIsDone(SLCLIENT client, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID获取文件是否已经取消
         * @param client 被控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 是否已经取消
         */
        [DllImport(dllName, EntryPoint = "SLClientFileIsKilled")]
        public static extern bool SLClientFileIsKilled(SLCLIENT client, SLSESSION session, UInt32 fid);

        /*
         * @brief 界面模式中启动桌面代理实例<此API仅供内部使用>
         * @param client 被控制端环境
         * @param nPort 绑定服务端口
         * @param nID 代理ID
         */
        [DllImport(dllName, EntryPoint = "SLClientRunDesktopAgent")]
        public static extern bool SLClientRunDesktopAgent(SLCLIENT client, int nPort, int nID);

        /*
         * @brief 远程桌面中主动发起聊天
         * @param client 被控制端环境
         * @param session 桌面会话
         */
        [DllImport(dllName, EntryPoint = "SLClientStartChat")]
        public static extern bool SLClientStartChat(SLCLIENT client, SLSESSION session, bool bShow = true);

        /*
         * @brief 远程桌面中主动发起聊天
         * @param client 被控制端环境
         * @param session 桌面会话
         * @param bEnable 切换控制/观看模式
         */
        [DllImport(dllName, EntryPoint = "SLClientEnableControl")]
        public static extern bool SLClientEnableControl(SLCLIENT client, SLSESSION session, bool bEnable);

        /*
         * @brief 发现WOI设备
         * @param client 被控制端环境
         * @return 是否调用成功
         */
        [DllImport(dllName, EntryPoint = "SLDiscoverWoiDevice")]
        public static extern bool SLDiscoverWoiDevice(SLCLIENT client);

        /*
         * @brief 绑定WOI设备
         * @param client 被控制端环境
         * @param pstrSN WOI设备SN
         * @param pstrMac WOI设备Mac
         * @param pstrPassword WOI设备Password
         * @return 是否调用成功
         */
        [DllImport(dllName, EntryPoint = "SLBindWoiDevice")]
        public static extern bool SLBindWoiDevice(SLCLIENT client, string pstrSN, string pstrMac, string pstrPassword);

        /*
         * @brief 解绑WOI设备
         * @param client 被控制端环境
         * @param pstrSN WOI设备SN
         * @param pstrMac WOI设备Mac
         * @param pstrPassword WOI设备Password
         * @return 是否调用成功
         */
        [DllImport(dllName, EntryPoint = "SLUnBindWoiDevice")]
        public static extern bool SLUnBindWoiDevice(SLCLIENT client, string pstrSN, string pstrMac, string pstrPassword);

        /*
         * @brief 被控制端WOI事件回调事件
         * @param client 被控制端环境
         * @param evt 事件
         * @param code 错误码
         * @param pstrResponse 响应消息
         * @param custom 用户自定义参数
         */
        public delegate void SLCLIENT_WOI_CALLBACK(SLCLIENT client, SLCLIENT_WOI_EVENT evt, int code, string pstrResponse, SLPOINTER custom);

        /*
         * @brief 设置被控制端WOI事件回调函数
         * @param client 被控制端环境
         * @param pfnCallback 回调函数地址
         * @param custom 用户自定义参数，回调时内部程序会将此参数一并回调
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetClientWOICallback")]
        public static extern bool SLSetClientWOICallback(SLCLIENT client, SLCLIENT_WOI_CALLBACK pfnCallback, SLPOINTER custom);


        /************************************************************************/
        /* 控制端相关API                                                        */
        /************************************************************************/


        /*
         * @brief 创建一个控制端环境
         * @return 返回被控制端环境值，如果创建失败则返回UInt32_INVAILD
         */
        [DllImport(dllName, EntryPoint = "SLCreateRemote")]
        public static extern SLREMOTE SLCreateRemote();

        /*
         * @brief 销毁一个控制端环境
         * @param remote 控制端环境
         * @return 是否销毁成功
         */
        [DllImport(dllName, EntryPoint = "SLDestroyRemote")]
        public static extern bool SLDestroyRemote(SLREMOTE remote);

        /*
         * @brief 主控制端回调事件
         * @param remote 主控制端环境
         * @param event 事件
         * @param custom 用户自定义参数
         */
        public delegate void SLREMOTE_CALLBACK(SLREMOTE remote, SLSESSION session, SLREMOTE_EVENT event_, SLPOINTER custom);       

        /*
         * @brief 设置主控制端事件回调函数
         * @param remote 主控制端环境
         * @param pfnCallback 回调函数地址
         * @param custom 用户自定义参数，回调时内部程序会将此参数一并回调
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetRemoteCallback", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLSetRemoteCallback(SLREMOTE remote, SLREMOTE_CALLBACK pfnCallback, SLPOINTER custom);

        /*
         * @brief 打开主控端日志
         * @param remote 主控制端环境
         * @param path 路径
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLOpenRemoteLog")]
        public static extern bool SLOpenRemoteLog(SLREMOTE remote, string path, string name = "");

        /*
         * @brief 创建主控制端会话
         * @param remote 控制端环境
         * @param eType 会话类型
         * @param pstrAddress 远程被控制端地址
         * @param pstrSession 远程桌面会话名
         * @return 会话
         */
        [DllImport(dllName, EntryPoint = "SLCreateRemoteSession")]
        public static extern SLSESSION SLCreateRemoteSession(SLREMOTE remote, ESLSessionType eType, string pstrAddress, string pstrSession);

        /*
         * @brief 创建主控制端空会话(无连接)
         * @param remote 控制端环境
         * @param eType 会话类型
         * @remark 和SLCreateRemoteSession不同的是创建一个空会话，不进行连接，后面必须再使用SLConnectRemoteSession来连接会话
         * @return 会话
         */
        [DllImport(dllName, EntryPoint = "SLCreateRemoteEmptySession", CallingConvention = CallingConvention.StdCall)]
        public static extern SLSESSION SLCreateRemoteEmptySession(SLREMOTE remote, ESLSessionType eType);

        /*
         * @brief 连接主控端会话
         * @param remote 控制端环境
         * @param session 会话
         * @param pstrAddress 远程被控制端地址
         * @param pstrSession 远程桌面会话名
         * @return 会话
         */
        [DllImport(dllName, EntryPoint = "SLConnectRemoteSession", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLConnectRemoteSession(SLREMOTE remote, SLSESSION session, string pstrAddress, string pstrSession);

        /*
         * @brief 连接主控端会话--被控对象是控控
         * @param remote 控制端环境
         * @param session 会话
         * @param kvm_info 被控控控配置信息
         * @return 是否连接成功
         */
        [DllImport(dllName, EntryPoint = "SLConnectKVMRemoteSession")]
        public static extern bool SLConnectKVMRemoteSession(SLREMOTE remote, SLSESSION session, ref SLKVM_INFO kvm_info);

        /*
         * @brief 销毁一个会话
         * @param remote 控制端环境
         * @param session 会话
         * @return 是否销毁成功
         */
        [DllImport(dllName, EntryPoint = "SLDestroyRemoteSession")]
        public static extern bool SLDestroyRemoteSession(SLREMOTE remote, SLSESSION session);

        /*
         * @brief 获得主控制端会话的连接信息
         * @param remote 主控制端环境
         * @param session 会话
         * @param connectType 连接类型
         * @param localType 是否是在同一局域网（公网IP相同） 0:公网IP不一致 1:公网IP一致
         * @return 是否获得成功
         */
        [DllImport(dllName, EntryPoint = "SLGetRemoteSessionConnection")]
        public static extern bool SLGetRemoteSessionConnection(SLREMOTE remote, SLSESSION session, ref UInt32 connectType, ref UInt32 localType);

        /*
         * @brief 设置代理
         * @param remote 控制端环境
         * @param proxy 代理设置
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetRemoteProxy", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLSetRemoteProxy(SLREMOTE remote, ref SLPROXY_INFO proxy);

        /*
        * @brief 测试代理
        * @param Remote 控制端环境
        * @param proxy 代理设置
        * @return 测试代理是否连接成功
        */
        [DllImport(dllName, EntryPoint = "SLTestRemotePorxy")]
        public static extern bool SLTestRemotePorxy(SLCLIENT remote, ref SLPROXY_INFO proxy);

        /*
         * \brief Show desktop window
         * \return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetDesktopSessionVisible")]
        public static extern bool SLSetDesktopSessionVisible(SLREMOTE remote, SLSESSION session);


        /*
         * @brief 主控制端某个会话发送数据
         * @param remote 主控制端环境
         * @param session 会话
         * @param lpData 发送的数据
         * @param nLen 发送的数据长度
         * @return 发送的字节数
         * @remark 目前只适用于DataTrans类型的会话
         */
        [DllImport(dllName, EntryPoint = "SLRemoteSessionSendData")]
        public static extern UInt32 SLRemoteSessionSendData(SLREMOTE remote, SLSESSION session, IntPtr lpData, UInt32 nLen);

        /*
         * @brief 主控制端某个会话接收数据
         * @param remote 主控制端环境
         * @param session 会话
         * @param lpData 接收数据的缓冲区
         * @param nLen 接收数据缓冲区长度
         * @return 实际接收到的字节数
         * @remark 目前只适用于DataTrans类型的会话
         */
        [DllImport(dllName, EntryPoint = "SLRemoteSessionRecvData")]
        public static extern UInt32 SLRemoteSessionRecvData(SLREMOTE remote, SLSESSION session, IntPtr lpData, UInt32 nLen);

        /*
         * @brief 获取主控制端某个会话某个属性值
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLGetRemoteSessionOpt")]
        public static extern bool SLGetRemoteSessionOpt(SLREMOTE remote, SLSESSION session, ESLSessionOpt eOpt, IntPtr pOptVal, UInt16 nOptLen);

        /*
         * @brief 设置主控制端某个会话某个属性值
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetRemoteSessionOpt", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLSetRemoteSessionOpt(SLREMOTE remote, SLSESSION session, ESLSessionOpt eOpt, IntPtr pOptVal, UInt16 nOptLen);

        /*
         * @brief 设置远程桌面窗口的大小
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLSetDesktopSessionPos", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLSetDesktopSessionPos(SLREMOTE remote, SLSESSION session, int x,int y,int width,int height);

        /*
         * @brief 获取远程桌面窗口的原始大小
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLGetDesktopSessionOriginSize", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLGetDesktopSessionOriginSize(SLREMOTE remote, SLSESSION session, ref int width, ref int height);

        /*
         * @brief 开启远程桌面录像
         * @param remote 主控制端环境
         * @param session 会话
         * @param filepath 保存文件绝对路径，录像文件后缀.mp4
         * @return 是否开启成功
         */
        [DllImport(dllName, EntryPoint = "SLRemoteDesktopStartRecord", CallingConvention = CallingConvention.StdCall)]
		public static extern bool SLRemoteDesktopStartRecord(SLREMOTE remote, SLSESSION session, string filepath );

		/*
         * @brief 停止远程桌面录像
         */
		[DllImport(dllName, EntryPoint = "SLRemoteDesktopStopRecord", CallingConvention = CallingConvention.StdCall)]
		public static extern void SLRemoteDesktopStopRecord(SLREMOTE remote, SLSESSION session);

        /*
         * @brief 设置远程桌面工具栏是否可见
         * @param remote 主控制端环境
         * @param session 对应的session
         * @param eType 枚举隐藏的对象
         * @return 是否设置成功
         */
        [DllImport(dllName, EntryPoint = "SLHideRemoteDesktopToolbarItem", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SLHideRemoteDesktopToolbarItem(SLREMOTE remote, SLSESSION session, SLDesktopControlType eType);

        /*
         * @brief 主控制端发送文件给被控端
         * @param remote 主控制端环境
         * @param session 会话
         * @param filepath 要发送的文件全路径
         * @param resume 是否断点续传
         * @return 当前传输文件的ID
         * @remark 目前只适用于FileTrans类型的会话
         */
        [DllImport(dllName, EntryPoint = "SLRemoteSendFile")]
        public static extern UInt32 SLRemoteSendFile(SLREMOTE remote, SLSESSION session, IntPtr filepath, bool resume);

        /*
         * @brief 终止正在传输的文件
         * @param remote 主控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 是否终止成功
         */
        [DllImport(dllName, EntryPoint = "SLRemoteKillFile")]
        public static extern bool SLRemoteKillFile(SLREMOTE remote, SLSESSION session, UInt32 fid);

        /*
         * @brief 获得传输文件名称
         * @param remote 主控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 文件名
         */
        [DllImport(dllName, EntryPoint = "SLRemoteGetFileName")]
        public static extern IntPtr SLRemoteGetFileName(SLREMOTE remote, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID获取文件大小
         * @param remote 主控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 文件大小
         */
        [DllImport(dllName, EntryPoint = "SLRemoteGetFileSize")]
        public static extern UInt64 SLRemoteGetFileSize(SLREMOTE remote, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID获取文件已传输大小
         * @param remote 主控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 已传输文件大小
         */
        [DllImport(dllName, EntryPoint = "SLRemoteGetFileTransfered")]
        public static extern UInt64 SLRemoteGetFileTransfered(SLREMOTE remote, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID判断当前文件是否正在传输
         * @param remote 主控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 是否正在传输
         */
        [DllImport(dllName, EntryPoint = "SLRemoteFileIsTransfering")]
        public static extern bool SLRemoteFileIsTransfering(SLREMOTE remote, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID判断当前文件是否传输完成
         * @param remote 主控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 已传输文件大小
         */
        [DllImport(dllName, EntryPoint = "SLRemoteFileIsDone")]
        public static extern bool SLRemoteFileIsDone(SLREMOTE remote, SLSESSION session, UInt32 fid);

        /*
         * @brief 根据文件ID获取文件是否已经取消
         * @param remote 主控制端环境
         * @param session 会话
         * @param fid 文件ID
         * @return 是否已经取消
         */
        [DllImport(dllName, EntryPoint = "SLRemoteFileIsKilled")]
        public static extern bool SLRemoteFileIsKilled(SLREMOTE remote, SLSESSION session, UInt32 fid);

        /*
        * @brief 设置远程CMD窗口的大小
        * @return 是否设置成功
        */
        [DllImport(dllName, EntryPoint = "SLSetCmdSessionPos")]
        public static extern bool SLSetCmdSessionPos(SLREMOTE remote, SLSESSION session, int x, int y, int width, int height);

        /*
        * @brief 设置远程摄像头窗口的大小
        * @return 是否设置成功
        */
        [DllImport(dllName, EntryPoint = "SLSetCameraSessionPos")]
        public static extern bool SLSetCameraSessionPos(SLREMOTE remote, SLSESSION session, int x, int y, int width, int height);

        /*
        * @brief 打开远程摄像头
        * @return 是否打开成功
        */
        [DllImport(dllName, EntryPoint = "SLRemoteCameraOpen")]
        public static extern bool SLRemoteCameraOpen(SLREMOTE remote, SLSESSION session, UInt32 dev_id);

        /*
        * @brief 关闭远程摄像头
        * @return 是否关闭成功
        */
        [DllImport(dllName, EntryPoint = "SLRemoteCameraClose")]
        public static extern bool SLRemoteCameraClose(SLREMOTE remote, SLSESSION session);

        /*
        * @brief 设置远程摄像头清晰度
        * @return 是否设置成功
        */
        [DllImport(dllName, EntryPoint = "SLRemoteCameraSetDefinition")]
        public static extern bool SLRemoteCameraSetDefinition(SLREMOTE remote, SLSESSION session, ESLVideoDefinition eVD);

        /*
        * @brief 获取摄像头列表
        * @param infos 摄像头结构体数组，若为空，则此函数仅返回列表大小
        * @param nSize 数组大小
        * @return 返回列表大小
        */
        //[DllImport(dllName, EntryPoint = "SLRemoteCameraGetList")]
        //public static extern UInt32 SLRemoteCameraGetList(SLREMOTE remote, SLSESSION session, CAMERA_INFO[] pInfos, UInt32 nSize );

        [DllImport(dllName, EntryPoint = "SLRemoteCameraGetList")]
        public static extern UInt32 SLRemoteCameraGetList(SLREMOTE remote, SLSESSION session, IntPtr pInfos, UInt32 nSize);
        /*
        * \brief 设置远程开机服务器地址与控制端口
        * \return 是否设置成功
        */
        [DllImport(dllName, EntryPoint = "SLSetRemoteWOIControl")]
        public static extern bool SLSetRemoteWOIControl(SLREMOTE remote, string pstrAddress, UInt32 nPort);

        /*
        * \brief 发送远程开机指令
        * \return 是否发送成功
        */
        [DllImport(dllName, EntryPoint = "SLSendWakeupCommand")]
        public static extern bool SLSendWakeupCommand(SLREMOTE remote, string pstrMac, string pstrPassword);

        /*
        * \brief 远程唤醒回调事件
        * \param remote 主控制端环境
        * \param code http响应code
        * \param pstrResponse http响应具体内容
        * \param custom 用户自定义参数
        */
        public delegate void SLREMOTE_WOI_CALLBACK(SLREMOTE remote, int code, IntPtr pstrResponse, SLPOINTER custom);

        /*
        * \brief 设置主控制端远程唤醒事件回调函数
        * \param remote 主控制端环境
        * \param pfnCallback 回调函数地址
        * \param custom 用户自定义参数，回调时内部程序会将此参数一并回调
        * \return 是否设置成功
        */
        [DllImport(dllName, EntryPoint = "SLSetRemoteWOICallback")]
        public static extern bool SLSetRemoteWOICallback(SLREMOTE remote, SLREMOTE_WOI_CALLBACK pfnCallback, SLPOINTER custom);


        /*
        * \brief 检查远程客户端的系统信息
        * \param remote 主控制端环境
        * \param session 对应的session
        * \param pstrQuery 查询参数
        * \param pstrContent 查询内容
        * \return 此次操作的ID
        */
        [DllImport(dllName, EntryPoint = "SLGetRemoteSysinfo", CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 SLGetRemoteSysinfo(SLREMOTE remote, SLSESSION session, string pstrQuery, string pstrContent);

        /*
        * \brief 获取远程桌面屏幕,会话,分辨率的列表信息
        * \param remote 主控制端环境
        * \param session 对应的session
        * \param infos 基础信息结构，若为空，则此函数仅返回列表大小
        * \param nSize 数组大小
        * \return 返回列表大小
        */
        [DllImport(dllName, EntryPoint = "SLGetRemoteDesktopDevList")]
        public static extern UInt32 SLGetRemoteDesktopDevList(SLREMOTE remote, SLSESSION session, SLDesktopDevType eType, ref SLBASE_INFO infos, UInt32 nSize = 0);

        /*
        * \brief 发送远程桌面控制命令
        * \param remote 主控制端环境
        * \param session 对应的session
        * \param eType 对应的操作命令
        * \param nIndex 索引值,只针对于切换屏幕，切换会话，切换分辨率等选择性的命令有效
        * \return 是否成功
        */
        [DllImport(dllName, EntryPoint = "SLSendRemoteDesktopCommand")]
        public static extern bool SLSendRemoteDesktopCommand(SLREMOTE remote, SLSESSION session, SLDesktopCommandType eType, UInt32 nIndex = 0);

        /*
        * \brief 获得远程桌面当前状态
        * \param remote 主控制端环境
        * \param session 对应的session
        * \param eType 对应的操作命令
        * \param nState 状态值或当前选中索引值
        * \return 是否成功
        */
        [DllImport(dllName, EntryPoint = "SLGetRemoteDesktopCurState")]
        public static extern bool SLGetRemoteDesktopCurState(SLREMOTE remote, SLSESSION session, SLDesktopStateType eType, ref UInt32 nState);

        /*
        * \brief 截屏
        * \param remote 主控制端环境
        * \param session 对应的session
        * \param filepath 保存文件全路径
        * \return 是否成功
        */
        [DllImport(dllName, EntryPoint = "SLGetRemoteDesktopCurState")]
        public static extern bool SLRemoteDesktopScreenShot(SLREMOTE remote, SLSESSION session, IntPtr filepath);

        /*
        * \brief 截屏
        * \param remote 主控制端环境
        * \param session 对应的session
        * \param filepath 被控端对应的操作平台
        * \return 是否成功
        */
        [DllImport(dllName, EntryPoint = "SLSetRemoteDesktopPlatform")]
        public static extern bool SLSetRemoteDesktopPlatform(SLREMOTE remote, SLSESSION session, SLPlatformType eType);

        /*
        * \brief 发送远程桌面控制命令
        * \param remote 主控制端环境
        * \param session 对应的session
        * \param key 对应的键盘字符串
        * \param isDown 是否是键盘按下
        * \return 是否成功
        */
        [DllImport(dllName, EntryPoint = "SLSendRemoteDesktopKeyUpDown")]
        public static extern bool SLSendRemoteDesktopKeyUpDown(SLREMOTE remote, SLSESSION session, IntPtr key, bool isDown);

        /*
        * \brief 将远程桌面和远程声音绑定或者解绑
        * \param remote 主控制端环境
        * \param session 对应的桌面session
        * \param soundSession 对应的声音session
        * \return 是否成功
        */
        [DllImport(dllName, EntryPoint = "SLRemoteDesktopBindSound")]
        public static extern bool SLRemoteDesktopBindSound(SLREMOTE remote, SLSESSION session, SLSESSION soundSession);

        /*
        * \brief 设置远程SSH窗口的大小
        * \return 是否设置成功
        */
        [DllImport(dllName, EntryPoint = "SLSetSshSessionPos")]
        public static extern bool SLSetSshSessionPos(SLREMOTE remote, SLSESSION session, int x, int y, int width, int height);

        /*
        * \brief 设置远程远程文件管理窗口的大小
        * \return 是否设置成功
        */
        [DllImport(dllName, EntryPoint = "SLSetFileMgrSessionPos")]
        public static extern bool SLSetFileMgrSessionPos(SLREMOTE remote, SLSESSION session, int x, int y, int width, int height);

        /*
        * \brief 检查远程客户端的系统信息
        * \param remote 主控制端环境
        * \param session 对应的session
        * \param pstrQuery 查询参数
        * \param pstrContent 查询内容
        * \return 此次操作的ID
        */
        [DllImport(dllName, EntryPoint = "SLGetScreenshot")]
        public static extern UInt32 SLGetScreenshot(SLREMOTE remote, SLSESSION session, int width, int height);

        /*
        * \brief 设置远程桌面水印图片
        * \param remote 主控制端环境
        * \param session 对应的桌面session
        * \param x 水印坐标偏移量(大于0表示左边距，小于0表示右边距)
        * \param y 水印坐标偏移量(大于0表示上边距，小于0表示下边距)
        * \param width 水印图像宽度
        * \param height 水印图像高度
        * \param alpha 透明度(0-255)
        * \param buf 水印图像缓存(ARGB)
        * \param buflen 水印图像缓存长度
        * \return 是否成功
        */
        [DllImport(dllName, EntryPoint = "SLSetRemoteDesktopWatermark")]
        public static extern bool SLSetRemoteDesktopWatermark(SLREMOTE remote, SLSESSION session, int x, int y, int width, int height, int alpha, IntPtr buf, UInt32 buflen);

        /*
        * \brief 获取远程桌面图像位图缓冲区及缓冲区大小
        * \param remote 主控制端环境
        * \param session 对应的桌面session
        * \param buf 桌面位图缓冲区，若为空，此函数返回缓冲区大小
        * \param buflen 桌面位图缓冲区大小
        * \return 缓冲区大小
        */
        [DllImport(dllName, EntryPoint = "SLGetRemoteDesktopBuffer")]
        public static extern UInt32 SLGetRemoteDesktopBuffer(SLREMOTE remote, SLSESSION session, IntPtr buf, UInt32 buflen);

        /*
        * \brief 获取远程会话的帧数
        * \return 帧数
        */
        [DllImport(dllName, EntryPoint = "SLGetRemoteDesktopFrameCount")]
        public static extern UInt32 SLGetRemoteDesktopFrameCount(SLREMOTE remote, SLSESSION session);
    }
}

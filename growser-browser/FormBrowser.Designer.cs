namespace Growser.Browser
{
  partial class FormBrowser
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrowser));
      this.Container = new System.Windows.Forms.ToolStripContainer();
      this.toolMain = new System.Windows.Forms.ToolStrip();
      this.toolExit = new System.Windows.Forms.ToolStripButton();
      this.toolSeq1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolChat = new System.Windows.Forms.ToolStripButton();
      this.toolPreferences = new System.Windows.Forms.ToolStripButton();
      this.toolSeq2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolDebug = new System.Windows.Forms.ToolStripButton();
      this.Container.TopToolStripPanel.SuspendLayout();
      this.Container.SuspendLayout();
      this.toolMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // Container
      // 
      // 
      // Container.ContentPanel
      // 
      this.Container.ContentPanel.Size = new System.Drawing.Size(800, 421);
      this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Container.Location = new System.Drawing.Point(0, 0);
      this.Container.Name = "Container";
      this.Container.Size = new System.Drawing.Size(800, 450);
      this.Container.TabIndex = 0;
      this.Container.Text = "toolStripContainer1";
      // 
      // Container.TopToolStripPanel
      // 
      this.Container.TopToolStripPanel.Controls.Add(this.toolMain);
      // 
      // toolMain
      // 
      this.toolMain.Dock = System.Windows.Forms.DockStyle.None;
      this.toolMain.GripMargin = new System.Windows.Forms.Padding(4);
      this.toolMain.ImageScalingSize = new System.Drawing.Size(22, 22);
      this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExit,
            this.toolSeq1,
            this.toolChat,
            this.toolPreferences,
            this.toolSeq2,
            this.toolDebug});
      this.toolMain.Location = new System.Drawing.Point(0, 0);
      this.toolMain.Name = "toolMain";
      this.toolMain.Size = new System.Drawing.Size(800, 29);
      this.toolMain.Stretch = true;
      this.toolMain.TabIndex = 0;
      // 
      // toolExit
      // 
      this.toolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
      this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolExit.Name = "toolExit";
      this.toolExit.Size = new System.Drawing.Size(26, 26);
      this.toolExit.Text = "退出";
      this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
      // 
      // toolSeq1
      // 
      this.toolSeq1.Name = "toolSeq1";
      this.toolSeq1.Size = new System.Drawing.Size(6, 29);
      // 
      // toolChat
      // 
      this.toolChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolChat.Image = ((System.Drawing.Image)(resources.GetObject("toolChat.Image")));
      this.toolChat.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolChat.Name = "toolChat";
      this.toolChat.Size = new System.Drawing.Size(26, 26);
      this.toolChat.Text = "聊天";
      this.toolChat.Click += new System.EventHandler(this.toolChat_Click);
      // 
      // toolPreferences
      // 
      this.toolPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolPreferences.Image = ((System.Drawing.Image)(resources.GetObject("toolPreferences.Image")));
      this.toolPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolPreferences.Name = "toolPreferences";
      this.toolPreferences.Size = new System.Drawing.Size(26, 26);
      this.toolPreferences.Text = "设置";
      // 
      // toolSeq2
      // 
      this.toolSeq2.Name = "toolSeq2";
      this.toolSeq2.Size = new System.Drawing.Size(6, 29);
      // 
      // toolDebug
      // 
      this.toolDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolDebug.Image = ((System.Drawing.Image)(resources.GetObject("toolDebug.Image")));
      this.toolDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolDebug.Name = "toolDebug";
      this.toolDebug.Size = new System.Drawing.Size(26, 26);
      this.toolDebug.Text = "调试";
      this.toolDebug.Click += new System.EventHandler(this.toolDebug_Click);
      // 
      // FormBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.Container);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormBrowser";
      this.Text = "Growser";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBrowser_FormClosing);
      this.Container.TopToolStripPanel.ResumeLayout(false);
      this.Container.TopToolStripPanel.PerformLayout();
      this.Container.ResumeLayout(false);
      this.Container.PerformLayout();
      this.toolMain.ResumeLayout(false);
      this.toolMain.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer Container;
    private System.Windows.Forms.ToolStrip toolMain;
    private System.Windows.Forms.ToolStripButton toolDebug;
    private System.Windows.Forms.ToolStripButton toolExit;
    private System.Windows.Forms.ToolStripButton toolChat;
    private System.Windows.Forms.ToolStripButton toolPreferences;
    private System.Windows.Forms.ToolStripSeparator toolSeq1;
    private System.Windows.Forms.ToolStripSeparator toolSeq2;
  }
}


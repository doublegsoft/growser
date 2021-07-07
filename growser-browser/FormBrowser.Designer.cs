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
      this.container = new System.Windows.Forms.ToolStripContainer();
      this.toolMain = new System.Windows.Forms.ToolStrip();
      this.toolExit = new System.Windows.Forms.ToolStripButton();
      this.toolSeq1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolPatient = new System.Windows.Forms.ToolStripButton();
      this.toolChat = new System.Windows.Forms.ToolStripButton();
      this.toolPreferences = new System.Windows.Forms.ToolStripButton();
      this.toolSeq2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolDebug = new System.Windows.Forms.ToolStripButton();
      this.container.TopToolStripPanel.SuspendLayout();
      this.container.SuspendLayout();
      this.toolMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // Container
      // 
      // 
      // Container.ContentPanel
      // 
      this.container.ContentPanel.Size = new System.Drawing.Size(800, 409);
      this.container.Dock = System.Windows.Forms.DockStyle.Fill;
      this.container.Location = new System.Drawing.Point(0, 0);
      this.container.Name = "Container";
      this.container.Size = new System.Drawing.Size(800, 450);
      this.container.TabIndex = 0;
      this.container.Text = "toolStripContainer1";
      // 
      // Container.TopToolStripPanel
      // 
      this.container.TopToolStripPanel.Controls.Add(this.toolMain);
      // 
      // toolMain
      // 
      this.toolMain.Dock = System.Windows.Forms.DockStyle.None;
      this.toolMain.GripMargin = new System.Windows.Forms.Padding(4);
      this.toolMain.ImageScalingSize = new System.Drawing.Size(22, 22);
      this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExit,
            this.toolSeq1,
            this.toolPatient,
            this.toolChat,
            this.toolPreferences,
            this.toolSeq2,
            this.toolDebug});
      this.toolMain.Location = new System.Drawing.Point(0, 0);
      this.toolMain.Name = "toolMain";
      this.toolMain.Padding = new System.Windows.Forms.Padding(2);
      this.toolMain.Size = new System.Drawing.Size(800, 41);
      this.toolMain.Stretch = true;
      this.toolMain.TabIndex = 0;
      // 
      // toolExit
      // 
      this.toolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
      this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolExit.Name = "toolExit";
      this.toolExit.Padding = new System.Windows.Forms.Padding(2);
      this.toolExit.Size = new System.Drawing.Size(30, 34);
      this.toolExit.Text = "退出";
      this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
      // 
      // toolSeq1
      // 
      this.toolSeq1.Name = "toolSeq1";
      this.toolSeq1.Size = new System.Drawing.Size(6, 37);
      // 
      // toolPatient
      // 
      this.toolPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolPatient.Image = ((System.Drawing.Image)(resources.GetObject("toolPatient.Image")));
      this.toolPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolPatient.Name = "toolPatient";
      this.toolPatient.Padding = new System.Windows.Forms.Padding(2);
      this.toolPatient.Size = new System.Drawing.Size(30, 34);
      // 
      // toolChat
      // 
      this.toolChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolChat.Image = ((System.Drawing.Image)(resources.GetObject("toolChat.Image")));
      this.toolChat.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolChat.Name = "toolChat";
      this.toolChat.Padding = new System.Windows.Forms.Padding(2);
      this.toolChat.Size = new System.Drawing.Size(30, 34);
      this.toolChat.Text = "聊天";
      this.toolChat.Click += new System.EventHandler(this.toolChat_Click);
      // 
      // toolPreferences
      // 
      this.toolPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolPreferences.Image = ((System.Drawing.Image)(resources.GetObject("toolPreferences.Image")));
      this.toolPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolPreferences.Name = "toolPreferences";
      this.toolPreferences.Padding = new System.Windows.Forms.Padding(3);
      this.toolPreferences.Size = new System.Drawing.Size(32, 34);
      this.toolPreferences.Text = "设置";
      // 
      // toolSeq2
      // 
      this.toolSeq2.Name = "toolSeq2";
      this.toolSeq2.Size = new System.Drawing.Size(6, 37);
      // 
      // toolDebug
      // 
      this.toolDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolDebug.Image = ((System.Drawing.Image)(resources.GetObject("toolDebug.Image")));
      this.toolDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolDebug.Name = "toolDebug";
      this.toolDebug.Padding = new System.Windows.Forms.Padding(4);
      this.toolDebug.Size = new System.Drawing.Size(34, 34);
      this.toolDebug.Text = "调试";
      this.toolDebug.Click += new System.EventHandler(this.toolDebug_Click);
      // 
      // FormBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.container);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormBrowser";
      this.Text = "Growser";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBrowser_FormClosing);
      this.container.TopToolStripPanel.ResumeLayout(false);
      this.container.TopToolStripPanel.PerformLayout();
      this.container.ResumeLayout(false);
      this.container.PerformLayout();
      this.toolMain.ResumeLayout(false);
      this.toolMain.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer container;
    private System.Windows.Forms.ToolStrip toolMain;
    private System.Windows.Forms.ToolStripButton toolDebug;
    private System.Windows.Forms.ToolStripButton toolExit;
    private System.Windows.Forms.ToolStripButton toolChat;
    private System.Windows.Forms.ToolStripButton toolPreferences;
    private System.Windows.Forms.ToolStripSeparator toolSeq1;
    private System.Windows.Forms.ToolStripSeparator toolSeq2;
    private System.Windows.Forms.ToolStripButton toolPatient;
  }
}


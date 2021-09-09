
namespace Growser.Messenger
{
  partial class FormMessenger
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessenger));
      this.buttonClose = new System.Windows.Forms.Button();
      this.panelControl = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.container = new System.Windows.Forms.ToolStripContainer();
      this.panelControl.SuspendLayout();
      this.container.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonClose
      // 
      this.buttonClose.FlatAppearance.BorderSize = 0;
      this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
      this.buttonClose.Location = new System.Drawing.Point(855, 0);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(46, 46);
      this.buttonClose.TabIndex = 11;
      this.buttonClose.UseVisualStyleBackColor = true;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // panelControl
      // 
      this.panelControl.BackColor = System.Drawing.Color.CornflowerBlue;
      this.panelControl.Controls.Add(this.buttonClose);
      this.panelControl.Controls.Add(this.label1);
      this.panelControl.Location = new System.Drawing.Point(0, 0);
      this.panelControl.Name = "panelControl";
      this.panelControl.Size = new System.Drawing.Size(905, 46);
      this.panelControl.TabIndex = 13;
      this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
      this.panelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseMove);
      this.panelControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseUp);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.label1.Location = new System.Drawing.Point(3, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(88, 26);
      this.label1.TabIndex = 10;
      this.label1.Text = "在线交流";
      // 
      // container
      // 
      // 
      // container.ContentPanel
      // 
      this.container.ContentPanel.Size = new System.Drawing.Size(901, 648);
      this.container.Location = new System.Drawing.Point(0, 46);
      this.container.Name = "container";
      this.container.Size = new System.Drawing.Size(901, 673);
      this.container.TabIndex = 14;
      this.container.Text = "toolStripContainer1";
      // 
      // FormMessenger
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(900, 720);
      this.Controls.Add(this.container);
      this.Controls.Add(this.panelControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormMessenger";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "在线交流";
      this.TopMost = true;
      this.panelControl.ResumeLayout(false);
      this.panelControl.PerformLayout();
      this.container.ResumeLayout(false);
      this.container.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Panel panelControl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripContainer container;
  }
}
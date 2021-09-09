
namespace Growser.Live
{
  partial class FormLive
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLive));
      this.panelControl = new System.Windows.Forms.Panel();
      this.buttonClose = new System.Windows.Forms.Button();
      this.panelRemote = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panelLocal = new System.Windows.Forms.Panel();
      this.panelControl.SuspendLayout();
      this.panelRemote.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControl
      // 
      this.panelControl.BackColor = System.Drawing.Color.CornflowerBlue;
      this.panelControl.Controls.Add(this.buttonClose);
      this.panelControl.Location = new System.Drawing.Point(0, 0);
      this.panelControl.Name = "panelControl";
      this.panelControl.Size = new System.Drawing.Size(932, 46);
      this.panelControl.TabIndex = 0;
      this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
      this.panelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseMove);
      this.panelControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseUp);
      // 
      // buttonClose
      // 
      this.buttonClose.FlatAppearance.BorderSize = 0;
      this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
      this.buttonClose.Location = new System.Drawing.Point(883, 0);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(49, 46);
      this.buttonClose.TabIndex = 0;
      this.buttonClose.UseVisualStyleBackColor = false;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // panelRemote
      // 
      this.panelRemote.Controls.Add(this.pictureBox1);
      this.panelRemote.Controls.Add(this.panelLocal);
      this.panelRemote.Location = new System.Drawing.Point(0, 46);
      this.panelRemote.Name = "panelRemote";
      this.panelRemote.Size = new System.Drawing.Size(932, 485);
      this.panelRemote.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(275, 49);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(374, 374);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // panelLocal
      // 
      this.panelLocal.Location = new System.Drawing.Point(683, 348);
      this.panelLocal.Name = "panelLocal";
      this.panelLocal.Size = new System.Drawing.Size(237, 124);
      this.panelLocal.TabIndex = 0;
      // 
      // FormLive
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(932, 530);
      this.Controls.Add(this.panelRemote);
      this.Controls.Add(this.panelControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormLive";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLive_FormClosing);
      this.Load += new System.EventHandler(this.FormLive_Load);
      this.panelControl.ResumeLayout(false);
      this.panelRemote.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelControl;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Panel panelRemote;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panelLocal;
  }
}


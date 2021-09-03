
namespace Growser
{
  partial class FormLoading
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
      this.pictureLoading = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureLoading
      // 
      this.pictureLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoading.Image")));
      this.pictureLoading.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLoading.InitialImage")));
      this.pictureLoading.Location = new System.Drawing.Point(0, 0);
      this.pictureLoading.Name = "pictureLoading";
      this.pictureLoading.Size = new System.Drawing.Size(128, 128);
      this.pictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureLoading.TabIndex = 0;
      this.pictureLoading.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label1.Location = new System.Drawing.Point(13, 135);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(102, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "正在加载资源...";
      // 
      // FormLoading
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(128, 161);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureLoading);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormLoading";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormLoading";
      this.TopMost = true;
      ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureLoading;
    private System.Windows.Forms.Label label1;
  }
}
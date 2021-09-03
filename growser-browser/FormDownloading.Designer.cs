
namespace Growser.Browser
{
  partial class FormDownloading
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
      this.progressDownload = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // progressDownload
      // 
      this.progressDownload.Location = new System.Drawing.Point(13, 28);
      this.progressDownload.Name = "progressDownload";
      this.progressDownload.Size = new System.Drawing.Size(536, 34);
      this.progressDownload.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label1.Location = new System.Drawing.Point(12, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(214, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "正在下载应用更新程序，请稍后...";
      // 
      // FormDownloading
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(561, 74);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.progressDownload);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormDownloading";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormDownloading";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.FormDownloading_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressDownload;
    private System.Windows.Forms.Label label1;
  }
}
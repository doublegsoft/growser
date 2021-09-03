
namespace Growser
{
  partial class FormSettings
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
      this.buttonClose = new System.Windows.Forms.Button();
      this.buttonConfirm = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textHost = new System.Windows.Forms.TextBox();
      this.textOrganization = new System.Windows.Forms.TextBox();
      this.textSecret = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textAppCode = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonClose
      // 
      this.buttonClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.buttonClose.Location = new System.Drawing.Point(416, 184);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(75, 33);
      this.buttonClose.TabIndex = 6;
      this.buttonClose.Text = "关  闭";
      this.buttonClose.UseVisualStyleBackColor = true;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // buttonConfirm
      // 
      this.buttonConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.buttonConfirm.Location = new System.Drawing.Point(326, 184);
      this.buttonConfirm.Name = "buttonConfirm";
      this.buttonConfirm.Size = new System.Drawing.Size(75, 33);
      this.buttonConfirm.TabIndex = 5;
      this.buttonConfirm.Text = "确  定";
      this.buttonConfirm.UseVisualStyleBackColor = true;
      this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label1.Location = new System.Drawing.Point(12, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "服务地址：";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label2.Location = new System.Drawing.Point(12, 101);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(79, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "机构名称：";
      // 
      // textHost
      // 
      this.textHost.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.textHost.Location = new System.Drawing.Point(103, 54);
      this.textHost.Name = "textHost";
      this.textHost.Size = new System.Drawing.Size(388, 26);
      this.textHost.TabIndex = 2;
      // 
      // textOrganization
      // 
      this.textOrganization.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.textOrganization.Location = new System.Drawing.Point(103, 98);
      this.textOrganization.Name = "textOrganization";
      this.textOrganization.Size = new System.Drawing.Size(388, 26);
      this.textOrganization.TabIndex = 3;
      // 
      // textSecret
      // 
      this.textSecret.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.textSecret.Location = new System.Drawing.Point(103, 143);
      this.textSecret.Name = "textSecret";
      this.textSecret.Size = new System.Drawing.Size(388, 26);
      this.textSecret.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label3.Location = new System.Drawing.Point(12, 146);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(79, 20);
      this.label3.TabIndex = 6;
      this.label3.Text = "安全密钥：";
      // 
      // textAppCode
      // 
      this.textAppCode.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.textAppCode.Location = new System.Drawing.Point(103, 15);
      this.textAppCode.Name = "textAppCode";
      this.textAppCode.Size = new System.Drawing.Size(388, 26);
      this.textAppCode.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label4.Location = new System.Drawing.Point(12, 18);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(79, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "服务代码：";
      // 
      // FormSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(503, 228);
      this.Controls.Add(this.textAppCode);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textSecret);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textOrganization);
      this.Controls.Add(this.textHost);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonConfirm);
      this.Controls.Add(this.buttonClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormSettings";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "设置";
      this.Load += new System.EventHandler(this.FormSettings_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Button buttonConfirm;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textHost;
    private System.Windows.Forms.TextBox textOrganization;
    private System.Windows.Forms.TextBox textSecret;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textAppCode;
    private System.Windows.Forms.Label label4;
  }
}
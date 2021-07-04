namespace Growser
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
      this.Container.SuspendLayout();
      this.SuspendLayout();
      // 
      // Container
      // 
      // 
      // Container.ContentPanel
      // 
      this.Container.ContentPanel.Size = new System.Drawing.Size(800, 450);
      this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Container.Location = new System.Drawing.Point(0, 0);
      this.Container.Name = "Container";
      this.Container.Size = new System.Drawing.Size(800, 450);
      this.Container.TabIndex = 0;
      this.Container.Text = "toolStripContainer1";
      this.Container.TopToolStripPanelVisible = false;
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
      this.Container.ResumeLayout(false);
      this.Container.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer Container;
  }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Growser.Messenger
{
  public partial class FormMessenger2 : Form
  {

    private bool MouseLeftDown = false;

    private Point FormLocation;

    private Point MouseOffset;

    public FormMessenger2()
    {
      InitializeComponent();

      ListViewItem item = new ListViewItem();
      listMessage.Items.Add(item);
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }


    private void panelControl_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.MouseLeftDown = true;
        this.FormLocation = this.Location;
        this.MouseOffset = Control.MousePosition;
      }
    }

    private void panelControl_MouseMove(object sender, MouseEventArgs e)
    {
      if (this.MouseLeftDown)
      {
        Point pt = Control.MousePosition;
        int x = this.MouseOffset.X - pt.X;
        int y = this.MouseOffset.Y - pt.Y;

        this.Location = new Point(this.FormLocation.X - x, this.FormLocation.Y - y);
      }
    }

    private void panelControl_MouseUp(object sender, MouseEventArgs e)
    {
      this.MouseLeftDown = false;
    }

    private void buttonClose_Click_1(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}

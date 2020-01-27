using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Books.Custom_Controls
{
    public partial class TitleBar : UserControl
    {
        Form container;
        public TitleBar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }
        public string Title { get { return label1.Text; } set { label1.Text = value; } }
        public Form MainForm { get { return container; } set { container = value; container.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size; } }
        private void butClose_Click(object sender, EventArgs e)
        {
            MainForm.Close();
        }

        private void pbxMaximize_Click(object sender, EventArgs e)
        {
            if (container.WindowState == FormWindowState.Normal)
            {
                container.WindowState = FormWindowState.Maximized;
                pbxMaximize.Image = Properties.Resources.Maximized_Hover;
            }

            else
            {
                container.WindowState = FormWindowState.Normal;
                pbxMaximize.Image = Properties.Resources.Icono_Maximizar___Hover;

            }

        }
        private void butMinimize_Click(object sender, EventArgs e)
        {        
           container.WindowState = FormWindowState.Minimized;
        }
        private void pbxMaximize_MouseHover(object sender, EventArgs e)
        {
            pbxMaximize.BackColor = Color.FromArgb(125, 204, 255);
        }

        private void pbxMaximize_MouseLeave(object sender, EventArgs e)
        {
            pbxMaximize.BackColor = Color.FromArgb(17, 144, 203);
        }
        #region ScreenMoving
        int x, y;
        bool isMove;
        private void panelControls_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
                MainForm.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void panelControls_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
        private void panelControls_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y; isMove = true;
        }
        #endregion
    }
}

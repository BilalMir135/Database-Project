using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Standard_Books
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {         
            InitializeComponent();        
            if(Properties.Settings.Default.RM)
            {
                tbxUserName.Text = Properties.Settings.Default.Username;
                tbxPassword.Text = Properties.Settings.Default.Password;
                chbxRM.Checked = true;
            }       
        }      
        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void butMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbxPassword_OnValueChanged(object sender, EventArgs e)
        {
            tbxPassword.isPassword = true;
        }

        private void tbxUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #region Move Form
        bool isMove = false;
        int x, y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }
   
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
        #endregion


        private void chbxRM_OnChange(object sender, EventArgs e)
        {
            if (chbxRM.Checked)
            {
                Properties.Settings.Default.RM = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.RM = false;
                Properties.Settings.Default.Save();
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != tbxUserName.Text)
            {
                Custom_Message_Box.Show("Please enter correct username. ", "Incorrect Username", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            else if (Properties.Settings.Default.Password != tbxPassword.Text)
            {
                Custom_Message_Box.Show("Please enter correct password. ", "Incorrect Password", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            else
            {
                Main_Form obj = new Main_Form();
                this.Hide();
                obj.Show();
            }          
        }

    }
}

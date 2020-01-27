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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void butUserSave_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username == tbxCurrentUserName.Text)
            {
                Properties.Settings.Default.Username = tbxNewUserName.Text;
                Properties.Settings.Default.Save();
                Custom_Message_Box.Show("Username changed successfully.", "Success", MessageBoxIcons.Information, MessageBoxButtons.OK);
                tbxCurrentUserName.Clear();
                tbxNewUserName.Clear();
            }
            else
            {
                Custom_Message_Box.Show("Invalid current username.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }

        private void butPasswordSave_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Password == tbxCurrentPassword.Text)
            {
                Properties.Settings.Default.Password = tbxNewPassword.Text;
                Properties.Settings.Default.Save();
                Custom_Message_Box.Show("Password changed successfully.", "Success", MessageBoxIcons.Information, MessageBoxButtons.OK);
                tbxCurrentPassword.Clear();
                tbxNewPassword.Clear();
            }
            else
            {
                Custom_Message_Box.Show("Invalid current password.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Account";
            Main_Form.Instance.Form = new SettingPanel();
        }
    }
}

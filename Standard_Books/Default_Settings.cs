using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Books
{
    public partial class Default_Settings : Form
    {
        public Default_Settings()
        {
            InitializeComponent();
        }
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region ScreenMoving
        int x, y;
        bool isMove;
        private void panelControls_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
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

        private void butSave_Click(object sender, EventArgs e)
        {
            if(tbxDatabase.Text=="" || tbxDatabase.Text == "")
            {
                Custom_Message_Box.Show("All database setting field are mandatory", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            else if(tbxPassword.Text=="" || tbxUserName.Text =="")
            {
                Custom_Message_Box.Show("Username and password both are mandatory", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Data Source=" + tbxDataSource.Text + ";" + "Initial Catalog=" + tbxDatabase.Text + ";" + "Integrated Security=true;MultipleActiveResultSets=true;");
                File.WriteAllText(path + "\\SB settings", sb.ToString());
                Properties.Settings.Default.Username = tbxUserName.Text;
                Properties.Settings.Default.Password = tbxPassword.Text;
                Properties.Settings.Default.ServerName = tbxDataSource.Text;
                Properties.Settings.Default.Database = tbxDatabase.Text;
                Properties.Settings.Default.Save();
                DialogResult dr = Custom_Message_Box.Show("Settings saved successful", "Saved", MessageBoxIcons.Information, MessageBoxButtons.OK);
                if(dr == DialogResult.OK)
                {
                    this.Hide();
                    Splash_Screen obj = new Splash_Screen();
                    obj.Show();
                }
            }

        }

    }
}

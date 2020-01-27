using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Standard_Books.Classes;

namespace Standard_Books.Custom_Controls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        string link;
        public string getlink(string procedure)
        {        
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                Main_Class.connection.Open();
                link = cmd.ExecuteScalar().ToString();
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return link;
        }
        private void pbxfacebook_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(getlink("link_facebook"));
            }
            catch(Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
                
        }

        private void pbxGmail_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(getlink("link_gmail"));
            }
            catch (Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }

        }

        private void pbxTwitter_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(getlink("link_twitter"));
            }
            catch (Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }


        }

        private void pbxOutlook_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(getlink("link_outlook"));
            }
            catch (Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }

        }

        private void pbxYahoo_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(getlink("link_yahoo"));
            }
            catch (Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }

        private void pbxSB_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(getlink("link_SB"));
            }
            catch (Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = false;
            Main_Form.Instance.Title.Text = "Standard Books";
        }

        private void pbxWebster_Click(object sender, EventArgs e)
        {
            Webster obj = new Webster();
            obj.ShowDialog();
        }
    }
}

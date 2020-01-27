using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Standard_Books.Classes;

namespace Standard_Books.Custom_Controls
{
    public partial class links : UserControl
    {
        public links()
        {
            InitializeComponent();
        }
        Retreival r = new Retreival();
        string[] link = new string[6];
        private void links_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Links";
            Main_Form.Instance.Form = new SettingPanel();
            Main_Class.disable(panelControls);
            link = r.getlinks();
            tbxFacebook.Text = link[0];
            tbxGmail.Text = link[1];
            tbxTwitter.Text = link[2];
            tbxOutlook.Text = link[3];
            tbxYahoo.Text = link[4];
            tbxSB.Text = link[5];            
            Array.Clear(link, 0, link.Length);
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            butEdit.Enabled = false;
            butSave.Enabled = true;
            Main_Class.enable(panelControls);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            butEdit.Enabled = true;
            butSave.Enabled = false;
            Main_Class.disable(panelControls);
            link[0] = tbxFacebook.Text;
            link[1] = tbxGmail.Text;
            link[2] = tbxTwitter.Text;
            link[3] = tbxOutlook.Text;
            link[4] = tbxYahoo.Text;
            link[5] = tbxSB.Text;
            Updation u = new Updation();
            u.updateLinks(link);
            Array.Clear(link, 0, link.Length);
        }
    }
}

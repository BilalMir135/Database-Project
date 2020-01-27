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
    public partial class SettingPanel : UserControl
    {
        public SettingPanel()
        {
            InitializeComponent();
        }      
        private void butAccount_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butParameter_Click(object sender, EventArgs e)
        {
            Parameters obj = new Parameters();
            Main_Form.Instance.panel_loading(obj);
        }

        private void SettingPanel_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = false;
            Main_Form.Instance.Title.Text = "Settings";
        }

        private void butLink_Click(object sender, EventArgs e)
        {
            links obj = new links();
            Main_Form.Instance.panel_loading(obj);
        }
    }
}

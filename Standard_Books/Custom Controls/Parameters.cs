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
    public partial class Parameters : UserControl
    {
        public Parameters()
        {
            InitializeComponent();
        }

        string[] parameters = new string[12];
        private void butEdit_Click_1(object sender, EventArgs e)
        {
            butEdit.Enabled = false;
            butSave.Enabled = true;
            Main_Class.enable(panelControls);
        }

        private void butSave_Click_1(object sender, EventArgs e)
        {
            butEdit.Enabled = true;
            butSave.Enabled = false;
            Main_Class.disable(panelControls);
            parameters[0] = tbxAddress.Text;
            parameters[1] = tbxCity.Text;
            parameters[2] = tbxProvince.Text;
            parameters[3] = tbxCountry.Text;
            parameters[4] = tbxPhone.Text;
            parameters[5] = tbxMobile.Text;
            parameters[6] = tbxEmail.Text;
            parameters[7] = tbxWebsite.Text;
            parameters[8] = tbxRemarks.Text;
            parameters[9] = tbxSpecialRemarks.Text;
            parameters[10] = cbxFYR.Text;
            parameters[11] = tbxNTN.Text;
            Updation u = new Updation();
            u.updateParameter(1, parameters);
            Array.Clear(parameters, 0, parameters.Length);
        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Parameters";
            Main_Form.Instance.Form = new SettingPanel();
            Retreival r = new Retreival();
            parameters = r.getparameters();
            tbxAddress.Text = parameters[0];
            tbxCity.Text = parameters[1];
            tbxProvince.Text = parameters[2];
            tbxCountry.Text = parameters[3];
            tbxPhone.Text = parameters[4];
            tbxMobile.Text = parameters[5];
            tbxEmail.Text = parameters[6];
            tbxWebsite.Text = parameters[7];
            tbxRemarks.Text = parameters[8];
            tbxSpecialRemarks.Text = parameters[9];
            cbxFYR.Text = parameters[10];
            tbxNTN.Text = parameters[11];
            Array.Clear(parameters, 0, parameters.Length);
        }
    }
}

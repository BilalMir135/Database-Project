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
    public partial class Supplier : UserControl
    {
        public Supplier()
        {
            InitializeComponent();
        }
        byte edit = 0;
        byte selected = 0;
        int supplierID;
        Retreival r = new Retreival();
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (panelGV.Visible)
            {
                panelGV.Visible = false;
                labelsearch.Visible = false;
                tbxSearch.Visible = false;
            }
            butDetails.Enabled = false;
            butSave.Enabled = true;
            butCancel.Enabled = true;
            butAdd.Enabled = false;
            butEdit.Enabled = false;
            butDelete.Enabled = false;
            edit = 0;
            Main_Class.enable_reset(panelControls);
            tbxName.Focus();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                if (panelGV.Visible)
                {
                    panelGV.Visible = false;
                    labelsearch.Visible = false;
                    tbxSearch.Visible = false;
                }

                butDetails.Enabled = false;
                butSave.Enabled = true;
                butCancel.Enabled = true;
                butAdd.Enabled = false;
                butEdit.Enabled = false;
                butDelete.Enabled = false;
                edit = 1;
                Main_Class.enable(panelControls);
                selected = 0;
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                DialogResult dr = Custom_Message_Box.Show("Are you sure?", "Delete", MessageBoxIcons.Question, MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(supplierID, "sp_deleteSupplier", "@SupplierID");
                    r.showSupplier(dgvSupplier, SupplierIDGV, NameGV, AddressGV, CityGV, ProvinceGV, CountryGV, PhoneGV, FaxGV, EmailGV);
                    Main_Class.disable_reset(panelControls);
                    selected = 0;
                }
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "" && tbxAddress.Text != "" && tbxCity.Text != "" && tbxProvince.Text != "" && tbxCountry.Text != "")
            {
                if (edit == 0)  //Code for Add
                {
                    Insertion i = new Insertion();
                    i.insertSupplier(tbxName.Text, tbxAddress.Text, tbxCity.Text, tbxProvince.Text, tbxCountry.Text, tbxPhone.Text, tbxFax.Text, tbxEmail.Text);
                    Main_Class.disable_reset(panelControls);
                }
                else if (edit == 1) //Code for Update
                {
                    Updation u = new Updation();
                    u.updateSupplier(supplierID, tbxName.Text, tbxAddress.Text, tbxCity.Text, tbxProvince.Text, tbxCountry.Text, tbxPhone.Text, tbxFax.Text, tbxEmail.Text);
                    Main_Class.disable_reset(panelControls);
                }
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Main_Class.disable_reset(panelControls);
            butDetails.Enabled = true;
            butSave.Enabled = false;
            butCancel.Enabled = false;
            butAdd.Enabled = true;
            butEdit.Enabled = true;
            butDelete.Enabled = true;
        }

        private void butDetails_Click(object sender, EventArgs e)
        {
            if (panelGV.Visible)
            {
                Main_Class.disable_reset(panelControls);
                panelGV.Visible = false;
                labelsearch.Visible = false;
                tbxSearch.Visible = false;
            }
            else
            {
                panelGV.Visible = true;
                labelsearch.Visible = true;
                tbxSearch.Visible = true;
                r.showSupplier(dgvSupplier, SupplierIDGV, NameGV, AddressGV, CityGV, ProvinceGV, CountryGV, PhoneGV, FaxGV, EmailGV);
            }
        }       

        private void dgvSupplier_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvSupplier, e);
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["SupplierIDGV"].Value.ToString());
                tbxName.Text = row.Cells["NameGV"].Value.ToString();
                tbxAddress.Text = row.Cells["AddressGV"].Value.ToString();
                tbxCity.Text = row.Cells["CityGV"].Value.ToString();
                tbxProvince.Text = row.Cells["ProvinceGV"].Value.ToString();
                tbxCountry.Text = row.Cells["CountryGV"].Value.ToString();
                tbxPhone.Text = row.Cells["PhoneGV"].Value.ToString();
                tbxFax.Text = row.Cells["FaxGV"].Value.ToString();
                tbxEmail.Text = row.Cells["EmailGV"].Value.ToString();
                Main_Class.disable(panelControls);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != " ")
            {
                r.showSupplier(dgvSupplier, SupplierIDGV, NameGV, AddressGV, CityGV, ProvinceGV, CountryGV, PhoneGV, FaxGV, EmailGV, tbxSearch.Text);
            }
            else
            {
                r.showSupplier(dgvSupplier, SupplierIDGV, NameGV, AddressGV, CityGV, ProvinceGV, CountryGV, PhoneGV, FaxGV, EmailGV);
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Supplier";
            Main_Form.Instance.Form = new Master_Enteries();
            Main_Class.disable(panelControls);
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tbx = (TextBox)sender;  //Phone & Fax
            Main_Class.allow_phonenumbers(tbx, e);
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            ReportForm obj = new ReportForm("Supplier List", "\\Reports\\Supplier.rpt", "Without Parameters");
            obj.ShowDialog();
        }
    }
}

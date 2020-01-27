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
    public partial class Freight : UserControl
    {
        public Freight()
        {
            InitializeComponent();
        }
        byte edit = 0;
        byte selected = 0;
        int freightID;
        Retreival r = new Retreival();
        private void butEdit_Click(object sender, EventArgs e)
        {
            if (selected == 1)  //if dgv cell is selected than it will work
            {
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

        private void butCancel_Click(object sender, EventArgs e)
        {
            butSave.Enabled = false;
            butCancel.Enabled = false;
            butAdd.Enabled = true;
            butEdit.Enabled = true;
            butDelete.Enabled = true;
            Main_Class.disable_reset(panelControls);
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                DialogResult dr = Custom_Message_Box.Show("Are you sure?", "Delete", MessageBoxIcons.Question, MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(freightID, "sp_deleteFreight", "@FreightID");
                    r.showFreighty(dgvFreight, FreightIDGV, AbbreGV, DestinationGV, ChargesGV);
                    Main_Class.disable_reset(panelControls);
                    selected = 0;
                }
            }
        }      
        private void tbxCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main_Class.allow_numbers(tbxCharges, e);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (tbxAbbrevation.Text != "" && tbxDestination.Text != "" && tbxCharges.Text != "")
            {
                if (edit == 0)  //Code for Add
                {
                    Insertion i = new Insertion();
                    i.insertFreight(tbxAbbrevation.Text, tbxDestination.Text, float.Parse(tbxCharges.Text));
                    r.showFreighty(dgvFreight, FreightIDGV, AbbreGV, DestinationGV, ChargesGV);
                    Main_Class.disable_reset(panelControls);
                }
                else if (edit == 1) //Code for Update
                {
                    Updation u = new Updation();
                    u.updateFreight(freightID, tbxAbbrevation.Text, tbxDestination.Text, float.Parse(tbxCharges.Text));
                    r.showFreighty(dgvFreight, FreightIDGV, AbbreGV, DestinationGV, ChargesGV);
                    Main_Class.disable_reset(panelControls);
                }
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            butSave.Enabled = true;
            butCancel.Enabled = true;
            butAdd.Enabled = false;
            butEdit.Enabled = false;
            butDelete.Enabled = false;
            edit = 0;
            Main_Class.enable_reset(panelControls);
            tbxAbbrevation.Focus();
        }

        private void Freight_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Freight";
            Main_Form.Instance.Form = new Master_Enteries();
            Main_Class.disable(panelControls);
            r.showFreighty(dgvFreight, FreightIDGV, AbbreGV, DestinationGV, ChargesGV);
        }

        private void dgvFreight_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvFreight, e);
        }

        private void dgvFreight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvFreight.Rows[e.RowIndex];
                freightID = Convert.ToInt32(row.Cells["FreightIDGV"].Value.ToString());
                tbxAbbrevation.Text = row.Cells["AbbreGV"].Value.ToString();
                tbxDestination.Text = row.Cells["DestinationGV"].Value.ToString();
                tbxCharges.Text = row.Cells["ChargesGV"].Value.ToString();
                Main_Class.disable(panelControls);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != " ")
            {
                r.showFreighty(dgvFreight, FreightIDGV, AbbreGV, DestinationGV, ChargesGV, tbxSearch.Text);
            }
            else
            {
                r.showFreighty(dgvFreight, FreightIDGV, AbbreGV, DestinationGV, ChargesGV);
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            ReportForm obj = new ReportForm("Freight List", "\\Reports\\Freight.rpt", "Without Parameters");
            obj.ShowDialog();
        }
    }
}

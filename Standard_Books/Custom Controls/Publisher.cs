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
    public partial class Publisher : UserControl
    {
        public Publisher()
        {
            InitializeComponent();
        }
        byte edit = 0;
        byte selected = 0;
        int PublisherID;
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
                    d.delete(PublisherID, "sp_deletePublisher", "@PublisherID");
                    r.showPublisher(dgvPublisher, PublisherIDGV, CodeGV, NameGV);
                    Main_Class.disable_reset(panelControls);
                    selected = 0;
                }
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
            tbxCode.Focus();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (tbxCode.Text != "" && tbxPublisherName.Text != "")
            {
                if (edit == 0)  //Code for Add
                {
                    Insertion i = new Insertion();
                    i.insertPublisher(tbxCode.Text, tbxPublisherName.Text);
                    r.showPublisher(dgvPublisher, PublisherIDGV, CodeGV, NameGV);
                    Main_Class.disable_reset(panelControls);
                }
                else if (edit == 1) //Code for Update
                {
                    Updation u = new Updation();
                    u.updatePublisher(PublisherID, tbxCode.Text, tbxPublisherName.Text);
                    r.showPublisher(dgvPublisher, PublisherIDGV, CodeGV, NameGV);
                    Main_Class.disable_reset(panelControls);
                }
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
           
        }
        private void Publisher_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Publisher";
            Main_Form.Instance.Form = new Master_Enteries();
            Main_Class.disable(panelControls);
            r.showPublisher(dgvPublisher, PublisherIDGV, CodeGV, NameGV);
        }

        private void dgvPublisher_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvPublisher, e);
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvPublisher.Rows[e.RowIndex];
                PublisherID = Convert.ToInt32(row.Cells["PublisherIDGV"].Value.ToString());
                tbxCode.Text = row.Cells["CodeGV"].Value.ToString();
                tbxPublisherName.Text = row.Cells["NameGV"].Value.ToString();
                Main_Class.disable(panelControls);
            }
        }
        private void tbxSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (tbxSearch.Text != " ")
            {
                r.showPublisher(dgvPublisher, PublisherIDGV, CodeGV, NameGV, tbxSearch.Text);
            }
            else
            {
                r.showPublisher(dgvPublisher, PublisherIDGV, CodeGV, NameGV);
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            ReportForm obj = new ReportForm("Publisher List", "\\Reports\\Publisher.rpt", "Without Parameters");
            obj.ShowDialog();
        }
    }
}

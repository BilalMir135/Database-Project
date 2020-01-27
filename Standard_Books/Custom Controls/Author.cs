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
    public partial class Author : UserControl
    {
        public Author()
        {
            InitializeComponent();
        }
        byte edit = 0;
        byte selected = 0;
        int authorID;
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
                    d.delete(authorID, "sp_deleteAuthor", "@AuthorID");
                    r.showAuthor(dgvAuthor, AuthorIDGV, AuthorNamesGV);
                    Main_Class.disable_reset(panelControls);
                    selected = 0;
                }
            }
        }
     

        private void butSave_Click(object sender, EventArgs e)
        {
            if (tbxAuthorName.Text != "" )
            {
                if (edit == 0)  //Code for Add
                {
                    Insertion i = new Insertion();
                    i.insertAuthor(tbxAuthorName.Text);
                    r.showAuthor(dgvAuthor, AuthorIDGV, AuthorNamesGV);
                    Main_Class.disable_reset(panelControls);
                }
                else if (edit == 1) //Code for Update
                {
                    Updation u = new Updation();
                    u.updateAuthor(authorID, tbxAuthorName.Text);
                    r.showAuthor(dgvAuthor, AuthorIDGV, AuthorNamesGV);
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
            tbxAuthorName.Focus();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Author";
            Main_Form.Instance.Form = new Master_Enteries();
            Main_Class.disable(panelControls);
            r.showAuthor(dgvAuthor, AuthorIDGV, AuthorNamesGV);
        }

        private void dgvAuthor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvAuthor, e);
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvAuthor.Rows[e.RowIndex];
                authorID = Convert.ToInt32(row.Cells["AuthorIDGV"].Value.ToString());
                tbxAuthorName.Text = row.Cells["AuthorNamesGV"].Value.ToString();               
                Main_Class.disable(panelControls);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != " ")
            {
                r.showAuthor(dgvAuthor, AuthorIDGV, AuthorNamesGV, tbxSearch.Text);
            }
            else
            {
                r.showAuthor(dgvAuthor, AuthorIDGV, AuthorNamesGV);
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            ReportForm obj = new ReportForm("Author List", "\\Reports\\Author.rpt", "Without Parameters");
            obj.ShowDialog();
        }
    }
}

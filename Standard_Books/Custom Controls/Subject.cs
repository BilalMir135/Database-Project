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
    public partial class Subject : UserControl
    {
        public Subject()
        {
            InitializeComponent();
        }
        byte edit = 0;
        byte selected = 0;
        int subjectID;
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

        private void butSave_Click(object sender, EventArgs e)
        {
            if (tbxSubjectName.Text != "")
            {
                if (edit == 0)  //Code for Add
                {
                    Insertion i = new Insertion();
                    i.insertSubject(tbxSubjectName.Text);
                    r.showSubject(dgvSubjects, SubjectIDGV, SubjectNameGV);
                    Main_Class.disable_reset(panelControls);
                }
                else if (edit == 1) //Code for Update
                {
                    Updation u = new Updation();
                    u.updateSubject(subjectID, tbxSubjectName.Text);
                    r.showSubject(dgvSubjects, SubjectIDGV, SubjectNameGV);
                    Main_Class.disable_reset(panelControls);
                }
            }
            else
            {
                Custom_Message_Box.Show("Subject name is mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
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
                    d.delete(subjectID, "sp_deleteSubject", "@SubjectID");
                    r.showSubject(dgvSubjects, SubjectIDGV, SubjectNameGV);
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
            tbxSubjectName.Focus();
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Subject";
            Main_Form.Instance.Form = new Master_Enteries();
            Main_Class.disable(panelControls);
            r.showSubject(dgvSubjects, SubjectIDGV, SubjectNameGV);
        }

        private void dgvSubjects_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvSubjects, e);
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];
                subjectID = Convert.ToInt32(row.Cells["SubjectIDGV"].Value.ToString());
                tbxSubjectName.Text = row.Cells["SubjectNameGV"].Value.ToString();              
                Main_Class.disable(panelControls);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != " ")
            {
                r.showSubject(dgvSubjects, SubjectIDGV, SubjectNameGV, tbxSearch.Text);
            }
            else
            {
                r.showSubject(dgvSubjects, SubjectIDGV, SubjectNameGV);
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            ReportForm obj = new ReportForm("Subject List", "\\Reports\\Subject.rpt", "Without Parameters");
            obj.ShowDialog();
        }
    }
}

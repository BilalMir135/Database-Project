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
    public partial class BooksReporting : UserControl
    {
        public BooksReporting()
        {
            InitializeComponent();
        }
        Retreival r = new Retreival();
        ReportForm obj;
        byte condition;
        short pubyear;
        private void chbxSubject_OnChange(object sender, EventArgs e)
        {
            if (cbxSubject.Enabled)
            {
                cbxSubject.Enabled = false;
                cbxPubYear.Enabled = false;
                tbxPubYear.Enabled = false;
                cbxSubject.SelectedIndex = -1;
                cbxPubYear.SelectedIndex = -1;
                tbxPubYear.Clear();
                chbxzerostock.Checked = false;
                chbxzerostock.Enabled = false;
            }
            else
            {
                Main_Class.disable_reset(panelControls);
                chbxAuthor.Checked = false;
                chbxPublisher.Checked = false;
                chbxPartialSearch.Checked = false;
                cbxSubject.Enabled = true;
                chbxCR.Checked = false;
                chbxCR0.Checked = false;
                cbxPubYear.Enabled = true;
                tbxPubYear.Enabled = true;
                chbxzerostock.Enabled = true;
            }
        }

        private void chbxAuthor_OnChange(object sender, EventArgs e)
        {
            if (cbxAuthor.Enabled)
            {
                cbxAuthor.Enabled = false;
                cbxAuthor.SelectedIndex = -1;
            }
            else
            {
                Main_Class.disable_reset(panelControls);
                chbxSubject.Checked = false;
                chbxPublisher.Checked = false;
                chbxPartialSearch.Checked = false;
                cbxAuthor.Enabled = true;
                chbxCR.Checked = false;
                chbxCR0.Checked = false;
                cbxPubYear.Enabled = false;
                tbxPubYear.Enabled = false;
                chbxzerostock.Checked = false;
                chbxzerostock.Enabled = false;
            }
        }

        private void chbxPublisher_OnChange(object sender, EventArgs e)
        {
            if (cbxPublisher.Enabled)
            {
                cbxPublisher.Enabled = false;
                cbxPublisher.SelectedIndex = -1;
            }
            else
            {
                Main_Class.disable_reset(panelControls);
                chbxSubject.Checked = false;
                chbxAuthor.Checked = false;
                chbxPartialSearch.Checked = false;
                cbxPublisher.Enabled = true;
                chbxCR.Checked = false;
                chbxCR0.Checked = false;
                cbxPubYear.Enabled = false;
                tbxPubYear.Enabled = false;
                chbxzerostock.Checked = false;
                chbxzerostock.Enabled = false;
            }
        }

        private void chbxPartialSearch_OnChange(object sender, EventArgs e)
        {
            if (tbxPartialSearch.Enabled)
            {
                tbxPartialSearch.Enabled = false;
                tbxPartialSearch.Clear();
            }
            else
            {
                Main_Class.disable_reset(panelControls);
                chbxSubject.Checked = false;
                chbxAuthor.Checked = false;
                chbxPublisher.Checked = false;
                tbxPartialSearch.Enabled = true;
                chbxCR.Checked = false;
                chbxCR0.Checked = false;
                cbxPubYear.Enabled = false;
                tbxPubYear.Enabled = false;
                chbxzerostock.Checked = false;
                chbxzerostock.Enabled = false;
            }
        }

        private void BooksReporting_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Book List";
            Main_Form.Instance.Form = new Lists();
            r.getData("sp_getAuthorData", "Author Name", "ID", cbxAuthor);
            r.getData("sp_getPublisherData", "Name", "ID", cbxPublisher);
            r.getData("sp_getSubjectData", "Subject Name", "ID", cbxSubject);
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (chbxSubject.Checked && cbxSubject.SelectedIndex!=-1)
            {
                if (cbxPubYear.Text!="" && tbxPubYear.Text != "")
                {
                    pubyear = Convert.ToInt16(tbxPubYear.Text);
                    if (cbxPubYear.Text == ">")
                        condition = 0;
                    else if (cbxPubYear.Text == "<")
                        condition = 1;
                    else
                        condition = 2;
                }
                else
                {
                    condition = 3;
                    pubyear = 0;
                }
                if (chbxzerostock.Checked)
                {
                    if (!chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                    {
                        obj = new ReportForm("Book List", "\\Reports\\Books_0S.rpt", "With Parameters", "sp_getBookSubjectforReport0", "@SubjectID", cbxSubject.SelectedValue, condition, pubyear);
                        obj.ShowDialog();
                    }
                    else if (!chbxDeleteYear.Checked && chbxDeletePublisher.Checked)
                    {
                        obj = new ReportForm("Book List", "\\Reports\\Books_0S_dp.rpt", "With Parameters", "sp_getBookSubjectforReport0", "@SubjectID", cbxSubject.SelectedValue, condition, pubyear);
                        obj.ShowDialog();
                    }
                    else if (chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                    {
                        obj = new ReportForm("Book List", "\\Reports\\Books_0S_dy.rpt", "With Parameters", "sp_getBookSubjectforReport0", "@SubjectID", cbxSubject.SelectedValue, condition, pubyear);
                        obj.ShowDialog();
                    }
                    else
                    {
                        obj = new ReportForm("Book List", "\\Reports\\Books_0S_dp_dy.rpt", "With Parameters", "sp_getBookSubjectforReport0", "@SubjectID", cbxSubject.SelectedValue, condition, pubyear);
                        obj.ShowDialog();
                    }
                }
                else
                {
                    if (!chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                    {
                        obj = new ReportForm("Book List", "\\Reports\\Books.rpt", "With Parameters", "sp_getBookSubjectforReport", "@SubjectID", cbxSubject.SelectedValue, condition, pubyear);
                        obj.ShowDialog();
                    }
                    else if (!chbxDeleteYear.Checked && chbxDeletePublisher.Checked)
                    {
                        obj = new ReportForm("Book List", "\\Reports\\Books_dp.rpt", "With Parameters", "sp_getBookSubjectforReport", "@SubjectID", cbxSubject.SelectedValue, condition, pubyear);
                        obj.ShowDialog();
                    }
                    else if (chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                    {
                        obj = new ReportForm("Book List", "\\Reports\\Books_dy.rpt", "With Parameters", "sp_getBookSubjectforReport", "@SubjectID", cbxSubject.SelectedValue, condition, pubyear);
                        obj.ShowDialog();
                    }
                    else
                    {
                        obj = new ReportForm("Book List", "\\Reports\\Books_dp_dy.rpt", "With Parameters", "sp_getBookSubjectforReport", "@SubjectID", cbxSubject.SelectedValue, condition, pubyear);
                        obj.ShowDialog();
                    }
                }
                         
            }
            else if(chbxPublisher.Checked && cbxPublisher.SelectedIndex != -1 && !chbxDeletePublisher.Checked)
            {
                if (!chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books1.rpt", "With Parameters", "sp_getBooksforReport", "@data", cbxPublisher.SelectedText);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books1_dy.rpt", "With Parameters", "sp_getBooksforReport", "@data", cbxPublisher.SelectedText);
                    obj.ShowDialog();
                }            
            }
            else if(chbxAuthor.Checked && cbxAuthor.SelectedIndex != -1)
            {
                if (!chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2.rpt", "With Parameters", "sp_getBooksforReport", "@data", cbxAuthor.SelectedText);
                    obj.ShowDialog();
                }
                else if(!chbxDeleteYear.Checked && chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dp.rpt", "With Parameters", "sp_getBooksforReport", "@data", cbxAuthor.SelectedText);
                    obj.ShowDialog();
                }
                else if (chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dy.rpt", "With Parameters", "sp_getBooksforReport", "@data", cbxAuthor.SelectedText);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dp_dy.rpt", "With Parameters", "sp_getBooksforReport", "@data", cbxAuthor.SelectedText);
                    obj.ShowDialog();
                }
            }
            else if (chbxCR.Checked)
            {
                if (!chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2.rpt", "With Parameters", "sp_getBooksforReport", "@data", "");
                    obj.ShowDialog();
                }
                else if (!chbxDeleteYear.Checked && chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dp.rpt", "With Parameters", "sp_getBooksforReport", "@data", "");
                    obj.ShowDialog();
                }
                else if (chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dy.rpt", "With Parameters", "sp_getBooksforReport", "@data", "");
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dp_dy.rpt", "With Parameters", "sp_getBooksforReport", "@data", "");
                    obj.ShowDialog();
                }
            }
            else if (chbxCR0.Checked)
            {
                if (!chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books0.rpt", "Without Parameters");
                    obj.ShowDialog();
                }
                else if(!chbxDeleteYear.Checked && chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books0_dp.rpt", "Without Parameters");
                    obj.ShowDialog();
                }
                else if(chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books0_dy.rpt", "Without Parameters");
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books0_dp_dy.rpt", "Without Parameters");
                    obj.ShowDialog();
                }         
            }
            else if (chbxPartialSearch.Checked)
            {
                if (!chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2.rpt", "With Parameters", "sp_getBooksforReport", "@data", tbxPartialSearch.Text);
                    obj.ShowDialog();
                }
                else if (!chbxDeleteYear.Checked && chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dp.rpt", "With Parameters", "sp_getBooksforReport", "@data", tbxPartialSearch.Text);
                    obj.ShowDialog();
                }
                else if (chbxDeleteYear.Checked && !chbxDeletePublisher.Checked)
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dy.rpt", "With Parameters", "sp_getBooksforReport", "@data", tbxPartialSearch.Text);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Book List", "\\Reports\\Books2_dp_dy.rpt", "With Parameters", "sp_getBooksforReport", "@data", tbxPartialSearch.Text);
                    obj.ShowDialog();
                }
            }
            
        }

        private void chbxCR_OnChange(object sender, EventArgs e)
        {
            if (chbxCR.Checked)
            {
                Main_Class.disable_reset(panelControls);
                chbxSubject.Checked = false;
                chbxAuthor.Checked = false;
                chbxPublisher.Checked = false;
                chbxPartialSearch.Checked = false;
                chbxCR0.Checked = false;
                chbxzerostock.Checked = false;
                chbxzerostock.Enabled = false;
            }         
        }

        private void chbxCR0_OnChange(object sender, EventArgs e)
        {
            if (chbxCR0.Checked)
            {
                Main_Class.disable_reset(panelControls);
                chbxSubject.Checked = false;
                chbxAuthor.Checked = false;
                chbxPublisher.Checked = false;
                chbxPartialSearch.Checked = false;
                chbxCR.Checked = false;
                chbxzerostock.Checked = false;
                chbxzerostock.Enabled = false;
            }
        }

        private void tbxPubYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main_Class.allow_int_numbers(tbxPubYear, e);
        }
    }
}

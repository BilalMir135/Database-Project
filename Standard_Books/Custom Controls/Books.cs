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
using System.Transactions;

namespace Standard_Books.Custom_Controls
{
    public partial class Books : UserControl
    {
        public Books()
        {
            InitializeComponent();
        }
        byte edit = 0;
        byte selected = 0;
        string ISBN;
        Retreival r = new Retreival();
        Deletion d = new Deletion();
        Insertion i = new Insertion();
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
                cbxCurrency.Visible = true;
                butDetails.Enabled = false;
                butSave.Enabled = true;
                butCancel.Enabled = true;
                butAdd.Enabled = false;
                butEdit.Enabled = false;
                butDelete.Enabled = false;
                edit = 1;
                Main_Class.enable(panelControls);
                dgvSubjects.Visible = true;
                r.showSubject(dgvSubjects, SubIDGV, SubjectNameGV);
                dgvSubjects.ClearSelection();              
                selected = 0;
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
            dgvSubjects.Visible = false;
            
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                DialogResult dr = Custom_Message_Box.Show("Are you sure?", "Delete", MessageBoxIcons.Question, MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {             
                    d.delete(tbxISBN.Text, "sp_deleteBooks", "@ISBN");
                    r.showBooks(dgvBooks, ISBNGV, TitleGV, AuthorIDGV, AuthorGV, SubjectIDGV, SubjectGV, PublisherIDGV, PublisherGV, PubYearGV, CurrencyIDGV, CurrencyGV, PriceGV, QuantityGV);
                    Main_Class.disable_reset(panelControls);
                    selected = 0;
                }
            }
        }
     
        private void butDetails_Click(object sender, EventArgs e)
        {        
            if (panelGV.Visible)
            {
                Main_Class.disable(panelControls);
                panelGV.Visible = false;
                labelsearch.Visible = false;
                tbxSearch.Visible = false;
                cbxCurrency.Visible = true;             
                dgvSubjects.Visible = true;
            }
            else
            {
                cbxCurrency.Visible = false;
                panelGV.Visible = true;
                labelsearch.Visible = true;
                tbxSearch.Visible = true;
                dgvBooks.AutoGenerateColumns = false;
                r.showBooks(dgvBooks, ISBNGV, TitleGV, AuthorIDGV, AuthorGV, SubjectIDGV, SubjectGV, PublisherIDGV, PublisherGV, PubYearGV, CurrencyIDGV, CurrencyGV, PriceGV, QuantityGV);
                dgvSubjects.Visible = false;
            }       
               
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (panelGV.Visible)
            {
                panelGV.Visible = false;
                labelsearch.Visible = false;
                tbxSearch.Visible = false;
            }
            cbxCurrency.Visible = true;
            butDetails.Enabled = false;
            butSave.Enabled = true;
            butCancel.Enabled = true;
            butAdd.Enabled = false;
            butEdit.Enabled = false;
            butDelete.Enabled = false;
            edit = 0;
            Main_Class.enable_reset(panelControls);          
            r.showSubject(dgvSubjects, SubIDGV, SubjectNameGV);
            dgvSubjects.ClearSelection();
            dgvSubjects.Visible = true;
            tbxISBN.Focus();     
        }

        short pubyear;
        private void butSave_Click(object sender, EventArgs e)
        {
            if (tbxPublishingYear.Text != " " && tbxPublishingYear.Text != "" ) 
                pubyear = Convert.ToInt16(tbxPublishingYear.Text);
            else
                pubyear = 0;

            if (tbxISBN.Text != "" && tbxTitle.Text != "" && tbxPrice.Text != "" && tbxQuantity.Text != "" && cbxAuthor.Text!="" && cbxSubject.SelectedIndex != -1 && cbxPublisher.SelectedIndex != -1 && cbxCurrency.SelectedIndex != -1)
            {
                if (edit == 0)  //Code for Add
                {                   
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (cbxAuthor.SelectedIndex == -1)
                        {
                            AuthorID = i.insertAuthorfromBooks(cbxAuthor.Text);
                        }
                        i.insertBooks(tbxISBN.Text, tbxTitle.Text, AuthorID, Convert.ToInt32(cbxSubject.SelectedValue), Convert.ToInt32(cbxPublisher.SelectedValue), pubyear, Convert.ToInt32(cbxCurrency.SelectedValue), float.Parse(tbxPrice.Text), Convert.ToInt32(tbxQuantity.Text));
                        i.insertBooksSubject(tbxISBN.Text, Convert.ToInt32(cbxSubject.SelectedValue));
                        foreach (DataGridViewRow row in dgvSubjects.SelectedRows)
                        {
                            i.insertBooksSubject(tbxISBN.Text, Convert.ToInt32(row.Cells["SubIDGV"].Value.ToString()));
                        }
                        Custom_Message_Box.Show(tbxTitle.Text + " added to the system successfully", "Record Added", MessageBoxIcons.Information, MessageBoxButtons.OK);
                        scope.Complete();
                    }
                        
                    Main_Class.disable_reset(panelControls); 
                }
                else if (edit == 1) //Code for Update
                {
                    Updation u = new Updation();
                    using (TransactionScope scope = new TransactionScope())
                    {                      
                        u.updateBooks(tbxISBN.Text, tbxTitle.Text, Convert.ToInt32(cbxAuthor.SelectedValue), Convert.ToInt32(cbxSubject.SelectedValue), Convert.ToInt32(cbxPublisher.SelectedValue), pubyear, Convert.ToInt32(cbxCurrency.SelectedValue), float.Parse(tbxPrice.Text), Convert.ToInt32(tbxQuantity.Text));
                        d.delete_without_message(ISBN, "sp_deleteBooksSubject", "@ISBN");
                        i.insertBooksSubject(tbxISBN.Text, Convert.ToInt32(cbxSubject.SelectedValue));
                        foreach (DataGridViewRow row in dgvSubjects.SelectedRows)
                        {
                            i.insertBooksSubject(tbxISBN.Text, Convert.ToInt32(row.Cells["SubIDGV"].Value.ToString()));
                        }
                        Custom_Message_Box.Show(tbxTitle.Text + " updated to the system successfully", "Record updated", MessageBoxIcons.Information, MessageBoxButtons.OK);
                        scope.Complete();
                    }
                        
                    Main_Class.disable_reset(panelControls);
                }

            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;           
            Main_Form.Instance.Title.Text = "Books";
            Main_Form.Instance.Form = new Master_Enteries();
            Main_Class.disable(panelControls);
            r.getData("sp_getAuthorData", "Author Name", "ID", cbxAuthor);
            r.getData("sp_getPublisherData", "Name", "ID", cbxPublisher);
            r.getData("sp_getSubjectData", "Subject Name", "ID", cbxSubject);
            r.getData("sp_getCurrencyData", "Currency Name", "ID", cbxCurrency);
           
        }

        private void tbxPublishingYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tbx = (TextBox)sender;      // price,pubyear,quantity
            Main_Class.allow_numbers(tbx, e);
        }

        private void dgvBooks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvBooks, e);
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];            
                tbxISBN.Text = row.Cells["ISBNGV"].Value.ToString();
                ISBN = row.Cells["ISBNGV"].Value.ToString();
                tbxTitle.Text = row.Cells["TitleGV"].Value.ToString();
                cbxAuthor.Text = row.Cells["AuthorGV"].Value.ToString();
                cbxSubject.Text = row.Cells["SubjectGV"].Value.ToString();
                cbxPublisher.Text = row.Cells["PublisherGV"].Value.ToString();
                cbxCurrency.SelectedValue = Convert.ToInt32(row.Cells["CurrencyIDGV"].Value.ToString());
                tbxPublishingYear.Text = row.Cells["PubYearGV"].Value.ToString();
                tbxPrice.Text = row.Cells["PriceGV"].Value.ToString();
                tbxQuantity.Text = row.Cells["QuantityGV"].Value.ToString();
                r.showBooksSubject(dgvSubjects, SubIDGV, SubjectNameGV,ISBN);
                dgvSubjects.ClearSelection();
                Main_Class.disable(panelControls);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != " ")
            {
                r.showBooks(dgvBooks, ISBNGV, TitleGV, AuthorIDGV, AuthorGV, SubjectIDGV, SubjectGV, PublisherIDGV, PublisherGV, PubYearGV, CurrencyIDGV, CurrencyGV, PriceGV, QuantityGV, tbxSearch.Text);
            }
            else
            {
                r.showBooks(dgvBooks, ISBNGV, TitleGV, AuthorIDGV, AuthorGV, SubjectIDGV, SubjectGV, PublisherIDGV, PublisherGV, PubYearGV, CurrencyIDGV, CurrencyGV, PriceGV, QuantityGV);
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            ReportForm obj = new ReportForm("Book List", "\\Reports\\Books0.rpt", "Without Parameters");
            obj.ShowDialog();
        }

        int AuthorID;
        private void cbxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(edit==0 && cbxAuthor.Enabled)
                 AuthorID = Convert.ToInt32(cbxAuthor.SelectedValue);
        }
    }
}

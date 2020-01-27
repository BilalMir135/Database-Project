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
    public partial class InvoiceRecord : UserControl
    {
        public InvoiceRecord()
        {
            InitializeComponent();
        }
        byte selected = 0;
        long invoiceid;
        Retreival r = new Retreival();
        Updation u = new Updation();
        string invoiceno;
        private void InvoiceRecord_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Invoice Details";
            Main_Form.Instance.Form = new Transaction();
            dgvInvoice.AutoGenerateColumns = false;
            r.showInvoice(dgvInvoice, InvoiceIDGV, InvoiceNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
        }

        private void dgvInvoice_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvInvoice, e);
        }

        private void tbxInvoiceSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxInvoiceSearch.Text != " ")
            {
                r.showInvoice(dgvInvoice, InvoiceIDGV, InvoiceNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV, tbxInvoiceSearch.Text);
            }
            else
            {
                r.showInvoice(dgvInvoice, InvoiceIDGV, InvoiceNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
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
                    d.delete(invoiceid, "sp_deleteInvoice", "@InvoiceID");
                    r.showInvoice(dgvInvoice, InvoiceIDGV, InvoiceNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
                    selected = 0;
                }
            }
        }
        bool isdetailclicked;
        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvInvoice.Rows[e.RowIndex];
                invoiceid = Convert.ToInt64(row.Cells["InvoiceIDGV"].Value.ToString());
                invoiceno = row.Cells["InvoiceNOGV"].Value.ToString();
                if (e.ColumnIndex == 11)
                {
                    r.showInvoiceDetails(dgvInvoiceDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, invoiceid);
                    isdetailclicked = true;
                }

            }
        }

        private void dgvInvoiceDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvInvoiceDetails.Rows[e.RowIndex].Cells["SNOGV1"].Value = (e.RowIndex + 1).ToString();
        }

        private void tbxInvoiceDetailSearch_TextChanged(object sender, EventArgs e)
        {
            if (isdetailclicked)
            {
                if (tbxInvoiceDetailSearch.Text != " ")
                {
                    r.showInvoiceDetails(dgvInvoiceDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, invoiceid, tbxInvoiceDetailSearch.Text);
                }
                else
                {
                    r.showInvoiceDetails(dgvInvoiceDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, invoiceid);
                }
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                ReportForm obj;
                if (!chbxDeleteYear.Checked && !chbxLetterHead.Checked)
                {
                    obj = new ReportForm("Invoice", "\\Reports\\Invoice.rpt", "With Parameters", "sp_getInvoiceforReport", "@InvoiceNo", invoiceno);
                    obj.ShowDialog();
                }
                else if (chbxDeleteYear.Checked && !chbxLetterHead.Checked)
                {
                    obj = new ReportForm("Invoice", "\\Reports\\Invoice_dy.rpt", "With Parameters", "sp_getInvoiceforReport", "@InvoiceNo", invoiceno);
                    obj.ShowDialog();
                }
                else if (!chbxDeleteYear.Checked && chbxLetterHead.Checked)
                {
                    obj = new ReportForm("Invoice", "\\Reports\\Invoice_LH.rpt", "With Parameters", "sp_getInvoiceforReport", "@InvoiceNo", invoiceno);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Invoice", "\\Reports\\Invoice_LH_dy.rpt", "With Parameters", "sp_getInvoiceforReport", "@InvoiceNo", invoiceno);
                    obj.ShowDialog();
                }
            }
        }

        private void butCancelInvoice_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                DialogResult dr = Custom_Message_Box.Show("Are you sure you want to cancel invoice?", "Cancel Invoice", MessageBoxIcons.Question, MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DataTable dt = r.getDetails("sp_getInvoiceDetails", "@InvoiceID", invoiceid);
                    foreach (DataRow row in dt.Rows)
                    {
                        int stockquantity = r.getStockQuantity(row["ISBN"].ToString());
                        stockquantity += Convert.ToInt32(row["Quantity"].ToString());
                        u.updateStock(row["ISBN"].ToString(), stockquantity);
                    }
                    Deletion d = new Deletion();
                    d.delete(invoiceid, "sp_deleteInvoice", "@InvoiceID");
                    r.showInvoice(dgvInvoice, InvoiceIDGV, InvoiceNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
                    selected = 0;
                }               
            }         
        }
    }
}

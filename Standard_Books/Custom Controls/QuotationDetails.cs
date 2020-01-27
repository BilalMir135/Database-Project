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
    public partial class QuotationDetails : UserControl
    {
        public QuotationDetails()
        {
            InitializeComponent();
        }
        byte selected = 0;
        long quotationid;
        Retreival r = new Retreival();
        string quotationno;
        private void QuotationDetails_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Quotation Details";
            Main_Form.Instance.Form = new Transaction();
            dgvQuotation.AutoGenerateColumns = false;
            r.showQuotation(dgvQuotation, QuotationIDGV, QuotationNoGV, DateGV, QTitleGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
        }

        private void dgvQuotation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvQuotation, e);
        }

        private void tbxQuotationSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxQuotationSearch.Text != " ")
            {
                r.showQuotation(dgvQuotation, QuotationIDGV, QuotationNoGV, DateGV, QTitleGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV, tbxQuotationSearch.Text);
            }
            else
            {
                r.showQuotation(dgvQuotation, QuotationIDGV, QuotationNoGV, DateGV, QTitleGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
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
                    d.delete(quotationid, "sp_deleteQuotation", "@QuotationID");
                    r.showQuotation(dgvQuotation, QuotationIDGV, QuotationNoGV, DateGV, TitleGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
                    selected = 0;
                }
            }
        }

        bool isdetailclicked;
        private void dgvQuotation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvQuotation.Rows[e.RowIndex];
                quotationid = Convert.ToInt64(row.Cells["QuotationIDGV"].Value.ToString());
                quotationno = row.Cells["QuotationNoGV"].Value.ToString();
                if (e.ColumnIndex == 11)
                {
                    r.showQuotationDetails(dgvQuotationDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, quotationid);
                    isdetailclicked = true;
                }
            }
        }

        private void dgvQuotationDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvQuotationDetails.Rows[e.RowIndex].Cells["SNOGV1"].Value = (e.RowIndex + 1).ToString();
        }

        private void tbxQuotationDetailSearch_TextChanged(object sender, EventArgs e)
        {
            if (isdetailclicked)
            {
                if (tbxQuotationDetailSearch.Text != " ")
                {
                    r.showQuotationDetails(dgvQuotationDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, quotationid, tbxQuotationDetailSearch.Text);
                }
                else
                {
                    r.showQuotationDetails(dgvQuotationDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, quotationid);
                }
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                ReportForm obj;
                if (chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Quotations", "\\Reports\\Quotation_dy.rpt", "With Parameters", "sp_getQuotationforReport", "@QuotationNo", quotationno);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Quotations", "\\Reports\\Quotation.rpt", "With Parameters", "sp_getQuotationforReport", "@QuotationNo", quotationno);
                    obj.ShowDialog();
                }
               
            }
        }
    }
}

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
    public partial class PurchaseRecord : UserControl
    {
        public PurchaseRecord()
        {
            InitializeComponent();
        }
        byte selected = 0;
        long purchaseid;
        string purchaseno;
        Retreival r = new Retreival();
       
        private void PurchaseRecord_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Purchase Details";
            Main_Form.Instance.Form = new Transaction();
            dgvPurchase.AutoGenerateColumns = false;
            r.showPurchase(dgvPurchase, PurchaseIDGV, PurchaseNoGV, DateGV, SupplierIDGV, SupplierGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
        }

        private void dgvPurchase_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvPurchase, e);
        }

        private void tbxPurchaseSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxPurchaseSearch.Text != " ")
            {
                r.showPurchase(dgvPurchase, PurchaseIDGV, PurchaseNoGV, DateGV, SupplierIDGV, SupplierGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV, tbxPurchaseSearch.Text);
            }
            else
            {
                r.showPurchase(dgvPurchase, PurchaseIDGV, PurchaseNoGV, DateGV, SupplierIDGV, SupplierGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
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
                    d.delete(purchaseid, "sp_deletePurchase", "@PurchaseID");
                    r.showPurchase(dgvPurchase, PurchaseIDGV, PurchaseNoGV, DateGV, SupplierIDGV, SupplierGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
                    selected = 0;
                }
            }
        }

        bool isdetailclicked;
        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvPurchase.Rows[e.RowIndex];
                purchaseid = Convert.ToInt64(row.Cells["PurchaseIDGV"].Value.ToString());
                purchaseno = row.Cells["PurchaseNoGV"].Value.ToString();
                if (e.ColumnIndex == 10)
                {
                    r.showPurchaseDetails(dgvPurchaseDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, purchaseid);       
                    isdetailclicked = true;
                }
            }
        }

        private void dgvPurchaseDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvPurchaseDetails.Rows[e.RowIndex].Cells["SNOGV1"].Value = (e.RowIndex + 1).ToString();
        }

        private void tbxPurchaseDetailSearch_TextChanged(object sender, EventArgs e)
        {
            if (isdetailclicked)
            {
                if (tbxPurchaseDetailSearch.Text != " ")
                {
                    r.showPurchaseDetails(dgvPurchaseDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, purchaseid, tbxPurchaseDetailSearch.Text);
                }
                else
                {
                    r.showPurchaseDetails(dgvPurchaseDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, purchaseid);
                }
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
                ReportForm obj = new ReportForm("Purchases", "\\Reports\\Purchase.rpt", "With Parameters", "sp_getPurchaseforReport", "@PurchaseNo", purchaseno);
                obj.ShowDialog();
            }
        }
    }
}

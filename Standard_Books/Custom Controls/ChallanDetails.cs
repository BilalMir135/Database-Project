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
    public partial class ChallanDetails : UserControl
    {
        public ChallanDetails()
        {
            InitializeComponent();
        }
        byte selected = 0;
        long challanid;
        Retreival r = new Retreival();
        string challanno;

        private void ChallanDetails_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Challan Details";
            Main_Form.Instance.Form = new Transaction();
            dgvChallan.AutoGenerateColumns = false;
            r.showChallan(dgvChallan, ChallanIDGV, ChallanNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
        }

        private void dgvChallan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvChallan, e);
        }

        private void tbxChallanSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxChallanSearch.Text != " ")
            {
                r.showChallan(dgvChallan, ChallanIDGV, ChallanNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV, tbxChallanSearch.Text);
            }
            else
            {
                r.showChallan(dgvChallan, ChallanIDGV, ChallanNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
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
                    d.delete(challanid, "sp_deleteChallan", "@ChallanID");
                    r.showChallan(dgvChallan, ChallanIDGV, ChallanNoGV, DateGV, BatchGV, PartyIDGV, PartyGV, BooksGV, ChallanAmountGV, TotalAmountGV, ReferenceGV);
                    selected = 0;
                }
            }
        }
        bool isdetailclicked;
        private void dgvChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvChallan.Rows[e.RowIndex];
                challanid = Convert.ToInt64(row.Cells["ChallanIDGV"].Value.ToString());
                challanno = row.Cells["ChallanNOGV"].Value.ToString();
                if (e.ColumnIndex == 11)
                {                 
                    r.showChallanDetails(dgvChallanDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, challanid);
                    isdetailclicked = true;
                }              
            }
        }

        private void dgvChallanDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvChallanDetails.Rows[e.RowIndex].Cells["SNOGV1"].Value = (e.RowIndex + 1).ToString();
        }

        private void tbxChallanDetailSearch_TextChanged(object sender, EventArgs e)
        {
            if (isdetailclicked)
            {
                if (tbxChallanDetailSearch.Text != " ")
                {
                    r.showChallanDetails(dgvChallanDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, challanid, tbxChallanDetailSearch.Text);
                }
                else
                {
                    r.showChallanDetails(dgvChallanDetails, ISBNGV, TitleGV, PriceGV, QuantityGV, AmountGV, DiscountGV, FinalAmountGV, challanid);
                }
            }
           
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (selected==1)
            {
                ReportForm obj;
                if (chbxDetailChallan.Checked && !chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Delivery Challan", "\\Reports\\DetailChallan.rpt", "With Parameters", "sp_getChallanforReport", "@ChallanNo", challanno);
                    obj.ShowDialog();
                }
                else if (chbxDetailChallan.Checked && chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Delivery Challan", "\\Reports\\DetailChallan_dy.rpt", "With Parameters", "sp_getChallanforReport", "@ChallanNo", challanno);
                    obj.ShowDialog();
                }
                else if (!chbxDetailChallan.Checked && !chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Delivery Challan", "\\Reports\\Challan.rpt", "With Parameters", "sp_getChallanforReport", "@ChallanNo", challanno);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Delivery Challan", "\\Reports\\Challan_dy.rpt", "With Parameters", "sp_getChallanforReport", "@ChallanNo", challanno);
                    obj.ShowDialog();
                }
            }
        }
    }
}

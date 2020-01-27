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
    public partial class Challan : UserControl
    {
        public Challan()
        {
            InitializeComponent();
        }
        Retreival r = new Retreival();
        int total_quantity;
        float final_amount, final_total_amount;
        long challanid;
        byte edit;
        string currencylist = "";      
        private void butCancel_Click(object sender, EventArgs e)
        {
            Issaveclick = false;
            butEdit.Enabled = false;
            butSearch.Enabled = true;
            butSave.Enabled = false;
            butCancel.Enabled = false;
            butAdd.Enabled = true;
            butAddtocart.Enabled = false;
            butChallanSave.Enabled = true;
            butChallanSave.Enabled = false;        
            Main_Class.disable_reset(panelChallan);
            Main_Class.disable_reset(panelControls);
            tbxISBN.Enabled = false;
            tbxQuantity.Enabled = false;
            tbxDiscount.Enabled = false;          
            if (dgvChallan.Rows.Count != 0)
            {
                dgvChallan.Rows.Clear();
            }
            tbxTotalQuantity.Text = "0";
            tbxAmount.Text = "0";
            tbxTotalAmount.Text = "0";
            total_quantity = 0; final_amount = 0; final_total_amount = 0;
        }

        bool Issaveclick;
        int count;
        private void butSave_Click(object sender, EventArgs e)
        {
            if (Issaveclick == false)
            {
                foreach (DataGridViewRow row in dgvChallan.Rows)
                {
                    if (currencylist != "")
                    {
                        bool same_currency = false;
                        string temp = r.getCurrencybyISBN(row.Cells["ISBNGV"].Value.ToString());
                        string[] array = currencylist.Split(',');
                        foreach (string x in array)
                        {
                            if (x == temp)
                            {
                                same_currency = true;
                                break;
                            }
                        }
                        if (!same_currency)
                        {
                            currencylist += temp + ",";
                        }
                    }
                    else
                    {
                        currencylist = r.getCurrencybyISBN(row.Cells["ISBNGV"].Value.ToString()) + ",";
                    }
                }
                if (edit == 1 && dgvChallan.Rows.Count > 0 && !butChallanSave.Enabled)
                {
                    Deletion d = new Deletion();
                    d.delete_without_message(challanid, "sp_deleteChallan", "@ChallanID");
                    Issaveclick = true;
                }

                if (dgvChallan.Rows.Count > 0 && !butChallanSave.Enabled)
                {
                    long challanid;
                    Insertion i = new Insertion();
                    using (TransactionScope scope = new TransactionScope())
                    {
                        challanid = i.insertChallan(tbxChallanNo.Text, dtpChallan.Value, tbxBatchNo.Text, tbxReference.Text, Convert.ToInt32(tbxTotalQuantity.Text), float.Parse(tbxAmount.Text), float.Parse(tbxTotalAmount.Text), Convert.ToInt32(cbxParty.SelectedValue),currencylist);
                        foreach (DataGridViewRow row in dgvChallan.Rows)
                        {
                            count += i.insertBookDetails(challanid, "@ChallanID", "sp_insertChallanDetail", row.Cells["ISBNGV"].Value.ToString(), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), float.Parse(row.Cells["AmountGV"].Value.ToString()), float.Parse(row.Cells["DiscountGV"].Value.ToString()), float.Parse(row.Cells["FinalAmountGV"].Value.ToString()), float.Parse(row.Cells["PriceGV"].Value.ToString()));
                        }
                        if (count > 0)
                        {
                            Custom_Message_Box.Show("Challan created successfuly", "Success", MessageBoxIcons.Information, MessageBoxButtons.OK);
                        }
                        else
                        {
                            Custom_Message_Box.Show("Unable to create challan", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                        }
                        scope.Complete();
                        Issaveclick = true;
                    }
                }               
            }
        }
        bool Is_Same_Row;
        private void butAddtocart_Click(object sender, EventArgs e)
        {
            if (tbxISBN.Text != "" && tbxCurrency.Text != "" && tbxPrice.Text != "" && tbxExchangeRate.Text != "" && tbxQuantity.Text != "" && tbxBookAmount.Text != "" && tbxDiscount.Text != "" && tbxBookTotalAmount.Text != "")
            {
                if (dgvChallan.Rows.Count != 0)      //if dgv is empty then loop will not work 
                {
                    foreach (DataGridViewRow row in dgvChallan.Rows)            //restricting fomr the same double entry of same book
                    {
                        if (row.Cells["ISBNGV"].Value.ToString() == tbxISBN.Text)
                        {
                            Is_Same_Row = true;
                            break;
                        }
                        else
                        {
                            Is_Same_Row = false;
                        }
                    }
                    if (Is_Same_Row == false)
                    {
                        dgvChallan.Rows.Add(0, tbxISBN.Text, title, tbxPrice.Text, tbxQuantity.Text, tbxBookAmount.Text, tbxDiscount.Text, tbxBookTotalAmount.Text);
                        total_quantity += Convert.ToInt32(tbxQuantity.Text);
                        final_amount += float.Parse(tbxBookAmount.Text);
                        final_total_amount += float.Parse(tbxBookTotalAmount.Text);
                        tbxTotalQuantity.Text = total_quantity.ToString();
                        tbxAmount.Text = final_amount.ToString();
                        tbxTotalAmount.Text = final_total_amount.ToString();
                        Main_Class.reset(panelControls);
                        Array.Clear(bookdata, 0, bookdata.Length);
                    }

                }
                else
                {
                    dgvChallan.Rows.Add(0, tbxISBN.Text, title, tbxPrice.Text, tbxQuantity.Text, tbxBookAmount.Text, tbxDiscount.Text, tbxBookTotalAmount.Text);
                    total_quantity += Convert.ToInt32(tbxQuantity.Text);
                    final_amount += float.Parse(tbxBookAmount.Text);
                    final_total_amount += float.Parse(tbxBookTotalAmount.Text);
                    tbxTotalQuantity.Text = total_quantity.ToString();
                    tbxAmount.Text = final_amount.ToString();
                    tbxTotalAmount.Text = final_total_amount.ToString();
                    Main_Class.reset(panelControls);
                    Array.Clear(bookdata, 0, bookdata.Length);
                }
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            tbxISBN.Focus();
        }
        string[] bookdata = new string[4];
        string title;
        private void tbxISBN_Validated(object sender, EventArgs e)
        {
            if (tbxISBN.Text != " " && tbxISBN.Text != "")
            {
                bookdata = r.getBookbyISBN(tbxISBN.Text);
                tbxCurrency.Text = bookdata[0];
                tbxPrice.Text = bookdata[1];
                tbxExchangeRate.Text = bookdata[2];
                title = bookdata[3];
            }
            else
            {
                tbxCurrency.Text = " ";
                tbxPrice.Text = " ";
                tbxExchangeRate.Text = " ";
                Array.Clear(bookdata, 0, bookdata.Length);
            }
        }

        private void tbxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (tbxQuantity.Text != " " && tbxQuantity.Text != "" && tbxPrice.Text != " " && tbxPrice.Text != "")
            {
                int quantity = Convert.ToInt32(tbxQuantity.Text);
                tbxBookAmount.Text = (quantity * float.Parse(tbxPrice.Text) * float.Parse(tbxExchangeRate.Text)).ToString();
                float amount = float.Parse(tbxBookAmount.Text);
                tbxBookTotalAmount.Text = amount.ToString();
                tbxDiscount.Text = "";
            }
            else
            {
                tbxBookAmount.Text = " ";
            }
        }

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            Main_Class.allow_numbers(tbx, e);
        }

        private void tbxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (tbxDiscount.Text != " " && tbxDiscount.Text != "" && tbxBookAmount.Text != " " && tbxBookAmount.Text != " ")
            {
                float disc = float.Parse(tbxDiscount.Text);
                disc = disc / 100;
                disc = float.Parse(tbxBookAmount.Text) * disc;
                tbxBookTotalAmount.Text = (float.Parse(tbxBookAmount.Text) - disc).ToString();
            }
            else
            {
                tbxBookTotalAmount.Text = " ";
            }
        }

        private void Challan_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Challan";
            Main_Form.Instance.Form = new Transaction();
            r.getData("get_PartyList", "Name", "ID", cbxParty);
            Main_Class.disable(panelChallan);
            tbxISBN.Enabled = false;
            tbxQuantity.Enabled = false;
            tbxDiscount.Enabled = false;
        }

        private void butChallanSave_Click(object sender, EventArgs e)
        {
            if (tbxChallanNo.Text != "" && tbxBatchNo.Text != "" && cbxParty.SelectedIndex != -1)
            {
                tbxISBN.Enabled = true;
                tbxQuantity.Enabled = true;
                tbxPrice.Enabled = true;
                tbxDiscount.Enabled = true;
                butChallanSave.Enabled = false;
                butAddtocart.Enabled = true;
                Main_Class.disable(panelChallan);
                tbxISBN.Focus();
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }

        private void dgvChallan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvChallan, e);
        }

        private void dgvChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 8)
                {
                    DataGridViewRow row = dgvChallan.Rows[e.RowIndex];
                    total_quantity -= Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                    final_amount -= float.Parse(row.Cells["AmountGV"].Value.ToString());
                    final_total_amount -= float.Parse(row.Cells["FinalAmountGV"].Value.ToString());
                    dgvChallan.Rows.Remove(row);
                    tbxTotalQuantity.Text = total_quantity.ToString();
                    if (dgvChallan.Rows.Count != 0)
                    {
                        tbxAmount.Text = final_amount.ToString("###############.##");
                        tbxTotalAmount.Text = final_total_amount.ToString("##############.##");
                    }
                    else
                    {
                        tbxAmount.Text = "0";
                        tbxTotalAmount.Text = "0";
                    }
                }
            }
        }
    
        private string[] ChallanData = new string[9];
        private void butSearch_Click(object sender, EventArgs e)
        {
            if(tbxChallanNo.Text == "")
            {
                butAdd.Enabled = false;
                butCancel.Enabled = true;
                tbxChallanNo.Enabled = true;
                tbxChallanNo.Focus();
            }
            else
            {              
                ChallanData = r.getChallanbyChallanNo(tbxChallanNo.Text);
                if (ChallanData[0] != null)
                {
                    butEdit.Enabled = true;
                    butSearch.Enabled = false;
                    challanid = Convert.ToInt64(ChallanData[0]);
                    dtpChallan.Value = Convert.ToDateTime(ChallanData[1]);
                    tbxBatchNo.Text = ChallanData[2];
                    tbxTotalQuantity.Text = ChallanData[3];
                    tbxTotalAmount.Text = ChallanData[4];
                    tbxAmount.Text = ChallanData[5];
                    cbxParty.Text = ChallanData[6];
                    tbxReference.Text = ChallanData[7];
                    tbxCode.Text = ChallanData[8];
                    total_quantity = Convert.ToInt32(tbxTotalQuantity.Text);
                    final_amount = float.Parse(tbxAmount.Text);
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    dgvChallan.AutoGenerateColumns = false;
                    r.showDetails(dgvChallan, "sp_getChallanDetails", "@ChallanID", challanid);
                    Array.Clear(ChallanData, 0, ChallanData.Length);
                }
               
            }
           
        }
        
        private void butEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            butSave.Enabled = true;
            Main_Class.enable(panelChallan);
            butChallanSave.Enabled = true;
        }

        private void tbxCode_Validated(object sender, EventArgs e)
        {
            if (tbxCode.Text != "" && tbxCode.Text != null)
                cbxParty.SelectedValue = r.getPartybyCode(Convert.ToInt32(tbxCode.Text));
        }

        private void cbxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxParty.SelectedIndex != -1 && cbxParty.Focused)
                tbxCode.Text = r.getCodebyPartyID(Convert.ToInt32(cbxParty.SelectedValue)).ToString();
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (tbxChallanNo.Text != "")
            {
                ReportForm obj;
                if (chbxDetailChallan.Checked && !chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Delivery Challan", "\\Reports\\DetailChallan.rpt", "With Parameters", "sp_getChallanforReport", "@ChallanNo", tbxChallanNo.Text);
                    obj.ShowDialog();
                }
                else if (chbxDetailChallan.Checked && chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Delivery Challan", "\\Reports\\DetailChallan_dy.rpt", "With Parameters", "sp_getChallanforReport", "@ChallanNo", tbxChallanNo.Text);
                    obj.ShowDialog();
                }
                else if(!chbxDetailChallan.Checked && !chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Delivery Challan", "\\Reports\\Challan.rpt", "With Parameters", "sp_getChallanforReport", "@ChallanNo", tbxChallanNo.Text);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Delivery Challan", "\\Reports\\Challan_dy.rpt", "With Parameters", "sp_getChallanforReport", "@ChallanNo", tbxChallanNo.Text);
                    obj.ShowDialog();
                }
            }         
        }

        private void tbxPrice_Validated(object sender, EventArgs e)
        {
            if (tbxQuantity.Text != "" || tbxDiscount.Text != "")
            {
                tbxQuantity.Clear();
                tbxBookAmount.Clear();
                tbxDiscount.Clear();
                tbxBookTotalAmount.Clear();
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            butSearch.Enabled = false;
            butSave.Enabled = true;
            butCancel.Enabled = true;
            butAdd.Enabled = false;
            butChallanSave.Enabled = true;
            Main_Class.enable_reset(panelChallan);
            tbxChallanNo.Focus();
        }

    }
}

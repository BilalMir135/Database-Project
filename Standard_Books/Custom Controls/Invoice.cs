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
    public partial class Invoice : UserControl
    {
        public Invoice()
        {
            InitializeComponent();
        }
        Retreival r = new Retreival();
        Updation u = new Updation();
        int total_quantity, count;
        float final_amount, final_total_amount;
        bool Issaveclick;
        byte edit, remarks, specialremarks, ntn;
        long invoiceid;
        string currencylist = "";

        private void butAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            butSearch.Enabled = false;
            butSave.Enabled = true;
            butCancel.Enabled = true;
            butAdd.Enabled = false;
            butInvoiceSave.Enabled = true;
            chbxFreight.Enabled = true;
            chbxSpecialDiscount.Enabled = true;
            Main_Class.enable_reset(panelInvoice);
            tbxInvoiceNo.Focus();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (Issaveclick == false)
            {
                foreach (DataGridViewRow row in dgvInvoice.Rows)
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
                if (edit == 1 && dgvInvoice.Rows.Count > 0 && !butInvoiceSave.Enabled)
                {
                    DataTable dt = r.getDetails("sp_getInvoiceDetails", "@InvoiceID", invoiceid);
                    foreach (DataRow row in dt.Rows)
                    {
                        int stockquantity = r.getStockQuantity(row["ISBN"].ToString());
                        stockquantity += Convert.ToInt32(row["Quantity"].ToString());
                        u.updateStock(row["ISBN"].ToString(), stockquantity);
                    }
                    Deletion d = new Deletion();
                    d.delete_without_message(invoiceid, "sp_deleteInvoice", "@InvoiceID");
                    Issaveclick = true;
                }
                if (dgvInvoice.Rows.Count > 0 && !butInvoiceSave.Enabled)
                {
                    if (chbxRemarks.Checked) { remarks = 1; } else { remarks = 0; }
                    if (chbxSpecialRemarks.Checked) { specialremarks = 1; } else { specialremarks = 0; }
                    if (chbxNTN.Checked) { ntn = 1; } else { ntn = 0; }
                    Insertion i = new Insertion();
                    using (TransactionScope scope = new TransactionScope())
                    {
                        if (tbxSpecialDiscount.Text != null && tbxSpecialDiscount.Text != "")
                        {
                            if (cbxFreight.SelectedIndex != -1)
                                invoiceid = i.insertInvoice(tbxInvoiceNo.Text, dtpInvoice.Value, tbxBatchNo.Text, tbxReference.Text, Convert.ToInt32(tbxTotalQuantity.Text), float.Parse(tbxAmount.Text), float.Parse(tbxTotalAmount.Text), Convert.ToInt32(cbxParty.SelectedValue), cbxFreight.Text, float.Parse(cbxFreight.SelectedValue.ToString()), Convert.ToInt32(tbxSpecialDiscount.Text), currencylist, remarks, specialremarks, ntn, Convert.ToInt32(cbxForwardChallan.SelectedValue));
                            else
                                invoiceid = i.insertInvoice(tbxInvoiceNo.Text, dtpInvoice.Value, tbxBatchNo.Text, tbxReference.Text, Convert.ToInt32(tbxTotalQuantity.Text), float.Parse(tbxAmount.Text), float.Parse(tbxTotalAmount.Text), Convert.ToInt32(cbxParty.SelectedValue), cbxFreight.Text, 0, Convert.ToInt32(tbxSpecialDiscount.Text), currencylist, remarks, specialremarks, ntn, Convert.ToInt32(cbxForwardChallan.SelectedValue));
                        }
                        else
                        {
                            if (cbxFreight.SelectedIndex != -1)
                                invoiceid = i.insertInvoice(tbxInvoiceNo.Text, dtpInvoice.Value, tbxBatchNo.Text, tbxReference.Text, Convert.ToInt32(tbxTotalQuantity.Text), float.Parse(tbxAmount.Text), float.Parse(tbxTotalAmount.Text), Convert.ToInt32(cbxParty.SelectedValue), cbxFreight.Text, float.Parse(cbxFreight.SelectedValue.ToString()), 0, currencylist, remarks, specialremarks, ntn, Convert.ToInt32(cbxForwardChallan.SelectedValue));
                            else
                                invoiceid = i.insertInvoice(tbxInvoiceNo.Text, dtpInvoice.Value, tbxBatchNo.Text, tbxReference.Text, Convert.ToInt32(tbxTotalQuantity.Text), float.Parse(tbxAmount.Text), float.Parse(tbxTotalAmount.Text), Convert.ToInt32(cbxParty.SelectedValue), cbxFreight.Text, 0, 0, currencylist, remarks, specialremarks, ntn, Convert.ToInt32(cbxForwardChallan.SelectedValue));
                        }
                        if (cbxForwardChallan.SelectedIndex != -1)
                        {
                            u.updateApprovedChallan(Convert.ToInt64(cbxForwardChallan.SelectedValue));
                        }
                        foreach (DataGridViewRow row in dgvInvoice.Rows)
                        {
                            count += i.insertBookDetails(invoiceid, "@InvoiceID", "sp_insertInvoiceDetails", row.Cells["ISBNGV"].Value.ToString(), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), float.Parse(row.Cells["AmountGV"].Value.ToString()), float.Parse(row.Cells["DiscountGV"].Value.ToString()), float.Parse(row.Cells["FinalAmountGV"].Value.ToString()), float.Parse(row.Cells["PriceGV"].Value.ToString()));
                            int stockquantity = r.getStockQuantity(row.Cells["ISBNGV"].Value.ToString());
                            if (stockquantity >= 0)
                            {
                                stockquantity -= Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                                u.updateStock(row.Cells["ISBNGV"].Value.ToString(), stockquantity);
                            }
                        }
                        if (count > 0)
                        {
                            Custom_Message_Box.Show("Invoice created successfuly", "Success", MessageBoxIcons.Information, MessageBoxButtons.OK);
                        }
                        else
                        {
                            Custom_Message_Box.Show("Unable to create invoice", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                        }
                        scope.Complete();
                        Issaveclick = true;
                        currencylist = "";
                    }
                }
            }                    
        }

        private void butCancel_Click(object sender, EventArgs e)
        {

            Issaveclick = false;
            butEdit.Enabled = false;
            butSearch.Enabled = true;
            butSave.Enabled = false;
            butCancel.Enabled = false;
            butAdd.Enabled = true;
            butAddtocart.Enabled = false;
            butInvoiceSave.Enabled = false;
            chbxFreight.Enabled = false;
            chbxFreight.Checked = false;
            cbxFreight.Enabled = false;
            chbxNTN.Checked = false;
            chbxRemarks.Checked = false;
            chbxSpecialRemarks.Checked = false;
            chbxLetterHead.Checked = false;
            chbxDeleteYear.Checked = false;
            cbxFreight.SelectedIndex = -1;
            cbxFreight.Text = "";
            chbxSpecialDiscount.Enabled = false;
            chbxSpecialDiscount.Checked = false;
            tbxSpecialDiscount.Clear();
            tbxSpecialDiscount.Enabled = false;
            Main_Class.disable_reset(panelInvoice);
            Main_Class.disable_reset(panelControls);
            tbxISBN.Enabled = false;
            tbxQuantity.Enabled = false;
            tbxDiscount.Enabled = false;
            if (dgvInvoice.Rows.Count != 0)
            {
                dgvInvoice.Rows.Clear();
            }
            total_quantity = 0; final_amount = 0; final_total_amount = 0; 
            tbxTotalQuantity.Text = "0";
            tbxAmount.Text = "0";
            tbxTotalAmount.Text = "0";
            x = 0;  previousfreight = 0; sp_discount = 0;    previous_sp_discount = 0;
        }

        bool Is_Same_Row;
        private void butAddtocart_Click(object sender, EventArgs e)
        {
            if (tbxISBN.Text != "" && tbxCurrency.Text != "" && tbxPrice.Text != "" && tbxExchangeRate.Text != "" && tbxQuantity.Text != "" && tbxBookAmount.Text != "" && tbxDiscount.Text != "" && tbxBookTotalAmount.Text != "")
            {
                if (dgvInvoice.Rows.Count != 0)      //if dgv is empty then loop will not work 
                {
                    foreach (DataGridViewRow row in dgvInvoice.Rows)            //restricting fomr the same double entry of same book
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
                        dgvInvoice.Rows.Add(0, tbxISBN.Text, title, tbxPrice.Text, tbxQuantity.Text, tbxBookAmount.Text, tbxDiscount.Text, tbxBookTotalAmount.Text);
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
                    dgvInvoice.Rows.Add(0, tbxISBN.Text, title, tbxPrice.Text, tbxQuantity.Text, tbxBookAmount.Text, tbxDiscount.Text, tbxBookTotalAmount.Text);
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
            Main_Class.allow_int_numbers(tbx, e);
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
        private void Invoice_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Invoice";
            Main_Form.Instance.Form = new Transaction();
            r.getData("get_PartyList", "Name", "ID", cbxParty);
            r.getData("sp_getChallanList", "ChallanNo", "ID", cbxForwardChallan);
            r.getData("get_FreightList", "Freight", "Charges", cbxFreight);
            Main_Class.disable(panelInvoice);
            tbxISBN.Enabled = false;
            tbxQuantity.Enabled = false;
            tbxDiscount.Enabled = false;
        }
        private void butInvoiceSave_Click(object sender, EventArgs e)
        {
            if (tbxInvoiceNo.Text != "" && tbxBatchNo.Text!="" && cbxParty.SelectedIndex != -1)
            {
                tbxISBN.Enabled = true;
                tbxQuantity.Enabled = true;
                tbxDiscount.Enabled = true;
                tbxPrice.Enabled = true;
                butInvoiceSave.Enabled = false;
                butAddtocart.Enabled = true;
                Main_Class.disable(panelInvoice);
                tbxISBN.Focus();
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        private void dgvInvoice_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvInvoice, e);
        }
        private void chbxFreight_OnChange(object sender, EventArgs e)
        {
            if (cbxFreight.Enabled)
            {
                cbxFreight.Enabled = false;
                cbxFreight.SelectedIndex = -1;
            }
            else
            {               
                cbxFreight.Enabled = true;
            }
        }

        float previousfreight = 0, x;
        private void cbxFreight_Validated(object sender, EventArgs e)
        {
            if (cbxFreight.SelectedIndex != -1)
            {
                x = float.Parse(tbxTotalAmount.Text);
                x += float.Parse(cbxFreight.SelectedValue.ToString());
                if (previousfreight == 0)
                {                
                    tbxTotalAmount.Text = x.ToString();
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    previousfreight = float.Parse(cbxFreight.SelectedValue.ToString());
                }
                else
                {
                    x -= previousfreight;
                    tbxTotalAmount.Text = x.ToString();
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    previousfreight = float.Parse(cbxFreight.SelectedValue.ToString());
                }            
            }
            else
            {
                if (previousfreight != 0)
                {
                    x = float.Parse(tbxTotalAmount.Text);
                    x -= previousfreight;
                    tbxTotalAmount.Text = x.ToString();
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    previousfreight = 0;
                }
            }         
        }

        int sp_discount, previous_sp_discount;

        private void tbxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main_Class.allow_numbers(tbxDiscount, e);
        }

        private string[] ChallanData = new string[9];
        private void cbxForwardChallan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (is_challan_clicked)
            {
                if (dgvInvoice.Rows.Count != 0)
                {
                    dgvInvoice.Rows.Clear();
                }
                dgvInvoice.AutoGenerateColumns = false;
                r.showDetails(dgvInvoice, "sp_getChallanDetails", "@ChallanID", Convert.ToInt64(cbxForwardChallan.SelectedValue));
                ChallanData = r.getChallanbyChallanNo(cbxForwardChallan.Text);
                dtpInvoice.Value = Convert.ToDateTime(ChallanData[1]);
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
                is_challan_clicked = false;
            }                  
        }

        bool is_challan_clicked;

        private string[] InvoiceData = new string[16];
        private void butSearch_Click(object sender, EventArgs e)
        {
            if (tbxInvoiceNo.Text == "")
            {
                butAdd.Enabled = false;
                butCancel.Enabled = true;
                tbxInvoiceNo.Enabled = true;
                tbxInvoiceNo.Focus();
            }
            else
            {
                InvoiceData = r.getInvoicebyInvoiceNo(tbxInvoiceNo.Text);
                if (InvoiceData[0] != null)
                {
                    butEdit.Enabled = true;
                    butSearch.Enabled = false;
                    invoiceid = Convert.ToInt64(InvoiceData[0]);
                    dtpInvoice.Value = Convert.ToDateTime(InvoiceData[1]);
                    tbxBatchNo.Text = InvoiceData[2];
                    tbxTotalQuantity.Text = InvoiceData[3];
                    tbxTotalAmount.Text = InvoiceData[4];
                    tbxAmount.Text = InvoiceData[5];
                    cbxParty.Text = InvoiceData[6];
                    tbxReference.Text = InvoiceData[7];
                    cbxFreight.Text = InvoiceData[8];
                    tbxSpecialDiscount.Text = InvoiceData[10];
                    tbxCode.Text = InvoiceData[11];
                    cbxForwardChallan.SelectedValue = InvoiceData[12];
                    if (InvoiceData[13] == "True") { chbxRemarks.Checked = true; }     
                    if (InvoiceData[14] == "True") { chbxSpecialRemarks.Checked = true; }
                    if (InvoiceData[15] == "True") { chbxNTN.Checked = true; }                              
                    if (cbxFreight.Text != "")
                    {
                        previousfreight = float.Parse(InvoiceData[9]);
                        chbxFreight.Checked = true;
                    }
                    if (tbxSpecialDiscount.Text != "0")
                    {
                        previous_sp_discount = Convert.ToInt32(tbxSpecialDiscount.Text);
                        chbxSpecialDiscount.Checked = true;
                    }
                    total_quantity = Convert.ToInt32(tbxTotalQuantity.Text);
                    final_amount = float.Parse(tbxAmount.Text);
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    dgvInvoice.AutoGenerateColumns = false;
                    r.showDetails(dgvInvoice, "sp_getInvoiceDetails", "@InvoiceID", invoiceid);
                    Array.Clear(InvoiceData, 0, InvoiceData.Length);
                }

            }
        }

        private void chbxSpecialRemarks_OnChange(object sender, EventArgs e)
        {
            if (!chbxRemarks.Checked)
                chbxRemarks.Checked = true;
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (tbxInvoiceNo.Text != "")
            {
                ReportForm obj;
                if(!chbxDeleteYear.Checked && !chbxLetterHead.Checked)
                {
                    obj = new ReportForm("Invoice", "\\Reports\\Invoice.rpt", "With Parameters", "sp_getInvoiceforReport", "@InvoiceNo", tbxInvoiceNo.Text);
                    obj.ShowDialog();
                }
                else if(chbxDeleteYear.Checked && !chbxLetterHead.Checked)
                {
                    obj = new ReportForm("Invoice", "\\Reports\\Invoice_dy.rpt", "With Parameters", "sp_getInvoiceforReport", "@InvoiceNo", tbxInvoiceNo.Text);
                    obj.ShowDialog();
                }
                else if(!chbxDeleteYear.Checked && chbxLetterHead.Checked)
                {
                    obj = new ReportForm("Invoice", "\\Reports\\Invoice_LH.rpt", "With Parameters", "sp_getInvoiceforReport", "@InvoiceNo", tbxInvoiceNo.Text);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Invoice", "\\Reports\\Invoice_LH_dy.rpt", "With Parameters", "sp_getInvoiceforReport", "@InvoiceNo", tbxInvoiceNo.Text);
                    obj.ShowDialog();
                }              
            }
        }

        private void tbxPrice_Validated(object sender, EventArgs e)
        {
            if(tbxQuantity.Text!="" || tbxDiscount.Text != "")
            {
                tbxQuantity.Clear();
                tbxBookAmount.Clear();
                tbxDiscount.Clear();
                tbxBookTotalAmount.Clear();
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if(tbxSpecialDiscount.Text != "0")
            {
                tbxSpecialDiscount.Enabled = true;         
            }
            if (cbxFreight.Text != "")
            {
                cbxFreight.Enabled = true;
            }
            edit = 1;
            butSave.Enabled = true;
            chbxSpecialDiscount.Enabled = true;
            chbxFreight.Enabled = true;
            Main_Class.enable(panelInvoice);
            butInvoiceSave.Enabled = true;
        }

        private void tbxCode_Validated(object sender, EventArgs e)
        {
            if(tbxCode.Text!="" && tbxCode.Text!=null)
                cbxParty.SelectedValue = r.getPartybyCode(Convert.ToInt32(tbxCode.Text));
        }

        private void cbxParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxParty.SelectedIndex != -1 && cbxParty.Focused)
                tbxCode.Text = r.getCodebyPartyID(Convert.ToInt32(cbxParty.SelectedValue)).ToString();
        }

        private void cbxForwardChallan_Click(object sender, EventArgs e)
        {
            is_challan_clicked = true;
        }

        private void tbxSpecialDiscount_Validated(object sender, EventArgs e)
        {
            if (tbxSpecialDiscount.Text != "")
            {
                x = float.Parse(tbxTotalAmount.Text);
                sp_discount = Convert.ToInt32(tbxSpecialDiscount.Text);
                x -= sp_discount;
                if (previous_sp_discount == 0)
                {                                     
                    tbxTotalAmount.Text = x.ToString();
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    previous_sp_discount = sp_discount;
                }
                else
                {
                    x += previous_sp_discount;
                    tbxTotalAmount.Text = x.ToString();
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    previous_sp_discount = sp_discount;
                }
            }
            else
            {
                if (previous_sp_discount != 0)
                {
                    x = float.Parse(tbxTotalAmount.Text);
                    x += previous_sp_discount;
                    tbxTotalAmount.Text = x.ToString();
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    previous_sp_discount = 0;
                }
            }
        }

        private void chbxSpecialDiscount_OnChange(object sender, EventArgs e)
        {
            if (tbxSpecialDiscount.Enabled)
            {
                tbxSpecialDiscount.Enabled = false;
                tbxSpecialDiscount.Clear();
            }
            else
            {
                tbxSpecialDiscount.Enabled = true;
            }
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 8)
                {
                    DataGridViewRow row = dgvInvoice.Rows[e.RowIndex];
                    total_quantity -= Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                    final_amount -= float.Parse(row.Cells["AmountGV"].Value.ToString());
                    final_total_amount -= float.Parse(row.Cells["FinalAmountGV"].Value.ToString());
                    dgvInvoice.Rows.Remove(row);
                    tbxTotalQuantity.Text = total_quantity.ToString();
                    if (dgvInvoice.Rows.Count != 0)
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
    }
}

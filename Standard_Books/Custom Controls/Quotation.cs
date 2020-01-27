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
    public partial class Quotation : UserControl
    {
        public Quotation()
        {
            InitializeComponent();
        }
        Retreival r = new Retreival();
        int total_quantity, count;
        float final_amount, final_total_amount;
        bool Issaveclick;
        byte edit;
        long quotationid;
        string currencylist = "";

        private void butSave_Click(object sender, EventArgs e)
        {          
            if (Issaveclick == false)
            {
                foreach (DataGridViewRow row in dgvQuotation.Rows)
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
                            currencylist += temp+", ";
                        }
                    }
                    else
                    {
                        currencylist = r.getCurrencybyISBN(row.Cells["ISBNGV"].Value.ToString())+",";
                    }
                }
                if (edit == 1 && dgvQuotation.Rows.Count > 0 && !butQuotationSave.Enabled)
                {
                    Deletion d = new Deletion();
                    d.delete_without_message(quotationid, "sp_deleteQuotation", "@QuotationID");
                    Issaveclick = true;
                }

                if (dgvQuotation.Rows.Count > 0 && !butQuotationSave.Enabled)
                {
                    Insertion i = new Insertion();
                    using (TransactionScope scope = new TransactionScope())
                    {
                        quotationid = i.insertQuotation(tbxQuotationNo.Text, dtpQuotation.Value, tbxTitle.Text, tbxReference.Text, Convert.ToInt32(tbxTotalQuantity.Text), float.Parse(tbxAmount.Text), float.Parse(tbxTotalAmount.Text), Convert.ToInt32(cbxParty.SelectedValue),currencylist);
                        foreach (DataGridViewRow row in dgvQuotation.Rows)
                        {
                            count += i.insertBookDetails(quotationid, "@QuotationID", "sp_insertQuotationDetail", row.Cells["ISBNGV"].Value.ToString(), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), float.Parse(row.Cells["AmountGV"].Value.ToString()), float.Parse(row.Cells["DiscountGV"].Value.ToString()), float.Parse(row.Cells["FinalAmountGV"].Value.ToString()), float.Parse(row.Cells["PriceGV"].Value.ToString()));
                        }
                        if (count > 0)
                        {
                            Custom_Message_Box.Show("Quotation created successfuly", "Success", MessageBoxIcons.Information, MessageBoxButtons.OK);
                        }
                        else
                        {
                            Custom_Message_Box.Show("Unable to create quotation", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                        }
                        scope.Complete();
                        Issaveclick = true;
                        currencylist = "";
                    }
                }
            }
        }

        string[] bookdata = new string[4];
        string title;
        bool Is_Same_Row;
        private void butAddtocart_Click(object sender, EventArgs e)
        {
            if (tbxISBN.Text != "" && tbxCurrency.Text != "" && tbxPrice.Text != "" && tbxExchangeRate.Text != "" && tbxQuantity.Text != "" && tbxBookAmount.Text != "" && tbxDiscount.Text != "" && tbxBookTotalAmount.Text != "")
            {
                if (dgvQuotation.Rows.Count != 0)      //if dgv is empty then loop will not work 
                {
                    foreach (DataGridViewRow row in dgvQuotation.Rows)            //restricting fomr the same double entry of same book
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
                        dgvQuotation.Rows.Add(0, tbxISBN.Text, title, tbxPrice.Text, tbxQuantity.Text, tbxBookAmount.Text, tbxDiscount.Text, tbxBookTotalAmount.Text);
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
                    dgvQuotation.Rows.Add(0, tbxISBN.Text, title, tbxPrice.Text, tbxQuantity.Text, tbxBookAmount.Text, tbxDiscount.Text, tbxBookTotalAmount.Text);
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

        private void tbxQuantity_Validated(object sender, EventArgs e)
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
            Main_Class.allow_int_numbers(tbxQuantity, e);
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

        private void Quotation_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Quotation";
            Main_Form.Instance.Form = new Transaction();
            r.getData("get_PartyList", "Name", "ID", cbxParty);         
            Main_Class.disable(panelQuotation);
            tbxISBN.Enabled = false;
            tbxQuantity.Enabled = false;
            tbxDiscount.Enabled = false;
        }

        private void dgvQuotation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvQuotation, e);
        }

        private void tbxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main_Class.allow_numbers(tbxDiscount, e);
        }

        private void dgvQuotation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 8)
                {
                    DataGridViewRow row = dgvQuotation.Rows[e.RowIndex];
                    total_quantity -= Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                    final_amount -= float.Parse(row.Cells["AmountGV"].Value.ToString());
                    final_total_amount -= float.Parse(row.Cells["FinalAmountGV"].Value.ToString());
                    dgvQuotation.Rows.Remove(row);
                    tbxTotalQuantity.Text = total_quantity.ToString();
                    if (dgvQuotation.Rows.Count != 0)
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

        private void butCancel_Click(object sender, EventArgs e)
        {
            Issaveclick = false;
            butEdit.Enabled = false;
            butSearch.Enabled = true;
            butSave.Enabled = false;
            butCancel.Enabled = false;
            butAdd.Enabled = true;
            butAddtocart.Enabled = false;
            butQuotationSave.Enabled = false;          
            Main_Class.disable_reset(panelQuotation);
            Main_Class.disable_reset(panelControls);
            tbxISBN.Enabled = false;
            tbxQuantity.Enabled = false;
            tbxDiscount.Enabled = false;
            if (dgvQuotation.Rows.Count != 0)
            {
                dgvQuotation.Rows.Clear();
            }
            total_quantity = 0; final_amount = 0; final_total_amount = 0;
            tbxTotalQuantity.Text = "0";
            tbxAmount.Text = "0";
            tbxTotalAmount.Text = "0";
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            butSave.Enabled = true;
            Main_Class.enable(panelQuotation);
            butQuotationSave.Enabled = true;
        }

        private string[] QuotationData = new string[9];
        private void butSearch_Click(object sender, EventArgs e)
        {
            if (tbxQuotationNo.Text == "")
            {
                butAdd.Enabled = false;
                butCancel.Enabled = true;
                tbxQuotationNo.Enabled = true;
                tbxQuotationNo.Focus();
            }
            else
            {
                QuotationData = r.getQuotationbyQuotationNo(tbxQuotationNo.Text);
                if (QuotationData[0] != null)
                {
                    butEdit.Enabled = true;
                    butSearch.Enabled = false;
                    quotationid = Convert.ToInt64(QuotationData[0]);
                    dtpQuotation.Value = Convert.ToDateTime(QuotationData[1]);                
                    tbxTotalQuantity.Text = QuotationData[2];
                    tbxTotalAmount.Text = QuotationData[3];
                    tbxAmount.Text = QuotationData[4];
                    cbxParty.Text = QuotationData[5];
                    tbxReference.Text = QuotationData[6];
                    tbxTitle.Text = QuotationData[7];
                    tbxCode.Text = QuotationData[8];
                    total_quantity = Convert.ToInt32(tbxTotalQuantity.Text);
                    final_amount = float.Parse(tbxAmount.Text);
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    dgvQuotation.AutoGenerateColumns = false;
                    r.showDetails(dgvQuotation, "sp_getQuotationDetails", "@QuotationID", quotationid);
                    Array.Clear(QuotationData, 0, QuotationData.Length);
                }

            }
        }

        private void butQuotationSave_Click(object sender, EventArgs e)
        {
            if (tbxQuotationNo.Text != "" && tbxTitle.Text != "" && cbxParty.SelectedIndex != -1)
            {
                tbxISBN.Enabled = true;
                tbxQuantity.Enabled = true;
                tbxPrice.Enabled = true;
                tbxDiscount.Enabled = true;
                butQuotationSave.Enabled = false;
                butAddtocart.Enabled = true;
                Main_Class.disable(panelQuotation);
                tbxISBN.Focus();
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
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

        private void tbxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main_Class.allow_int_numbers(tbxCode, e);
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (tbxQuotationNo.Text != "")
            {
                ReportForm obj;
                if (chbxDeleteYear.Checked)
                {
                    obj = new ReportForm("Quotations", "\\Reports\\Quotation_dy.rpt", "With Parameters", "sp_getQuotationforReport", "@QuotationNo", tbxQuotationNo.Text);
                    obj.ShowDialog();
                }
                else
                {
                    obj = new ReportForm("Quotations", "\\Reports\\Quotation.rpt", "With Parameters", "sp_getQuotationforReport", "@QuotationNo", tbxQuotationNo.Text);
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
            butQuotationSave.Enabled = true;
            Main_Class.enable_reset(panelQuotation);
            tbxQuotationNo.Focus();
        }


    }
}

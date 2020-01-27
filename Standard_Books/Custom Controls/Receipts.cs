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
    public partial class Receipts : UserControl
    {
        public Receipts()
        {
            InitializeComponent();
        }

        Retreival r = new Retreival();
        Updation u = new Updation();
        string[] invoicedata = new string[3];
        int outstanding_amount;
        byte edit, selected, error = 1;
        bool is_save_click;
        long receiptid;
        private void tbxInvoiceNo_Validated(object sender, EventArgs e)
        {
            Array.Clear(invoicedata, 0, invoicedata.Length);
            Main_Class.disable_reset(panelControls);
            if(tbxInvoiceNo.Text!="" && tbxInvoiceNo.Text != " ")
            {
                invoicedata = r.getInvoiceforReceipt(tbxInvoiceNo.Text);
                tbxInvoiceDate.Text = invoicedata[0];
                tbxInvoiceAmount.Text = invoicedata[1];
                tbxOutstandingAmount.Text = invoicedata[2];
                tbxIncomeTax.Text = "0";
            }
            if (tbxOutstandingAmount.Text != "" && tbxOutstandingAmount.Text != "0")
            {
                Main_Class.enable(panelControls);
                outstanding_amount = Convert.ToInt32(tbxOutstandingAmount.Text);
                tbxInvoiceNo.Enabled = false;    
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
            tbxInvoiceNo.Enabled = true;
            tbxIncomeTax.Enabled = true;
            tbxInvoiceNo.Focus();
            butSave.Enabled = true;
            butCancel.Enabled = true;
            butAdd.Enabled = false;
            butEdit.Enabled = false;
            butDelete.Enabled = false;
            butDetails.Enabled = false;
            edit = 0;
            Main_Class.reset(panelControls);
            Main_Class.reset(panelinvoice);
        }

        private void Receipts_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Receipt";
            Main_Form.Instance.Form = new Transaction();
            Main_Class.disable(panelControls);
        }

        private void tbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main_Class.allow_int_numbers(tbxAmount, e);
        }

        private void tbxAmount_Validated(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                if (tbxAmount.Text != "" && tbxOutstandingAmount.Text != "")
                {
                    outstanding_amount = Convert.ToInt32(invoicedata[2]);
                    outstanding_amount -= Convert.ToInt32(tbxAmount.Text);
                    tbxOutstandingAmount.Text = outstanding_amount.ToString();
                }
                if (tbxAmount.Text == "")
                {
                    tbxOutstandingAmount.Text = invoicedata[2];
                    outstanding_amount = Convert.ToInt32(tbxOutstandingAmount.Text);
                }
            }
            else if (edit == 1)
            {
                if (tbxAmount.Text != "" && tbxOutstandingAmount.Text != "")
                {
                    outstanding_amount = Convert.ToInt32(tbxInvoiceAmount.Text);
                    outstanding_amount -= Convert.ToInt32(tbxAmount.Text);
                    tbxOutstandingAmount.Text = outstanding_amount.ToString();
                }
                else if (tbxAmount.Text == "")
                {
                    tbxOutstandingAmount.Text = tbxInvoiceAmount.Text;
                    outstanding_amount = Convert.ToInt32(tbxOutstandingAmount.Text);
                }
            }

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            butDetails.Enabled = true;
            butSave.Enabled = false;
            butCancel.Enabled = false;
            butAdd.Enabled = true;
            butEdit.Enabled = true;
            butDelete.Enabled = true;
            is_save_click = false;
            Main_Class.disable_reset(panelControls);
            Main_Class.disable_reset(panelinvoice);
            tbxInvoiceNo.Focus();
            outstanding_amount = 0;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (is_save_click == false)
            {
                if (tbxInvoiceNo.Text != "" && tbxIncomeTax.Text != "" && tbxReceipt.Text != "" && tbxRemarks.Text != "" && tbxCC.Text != "" && tbxAmount.Text != "")
                {
                    if (edit == 0)
                    {
                        if (tbxIncomeTax.Text != "" && tbxIncomeTax.Text != "0")
                            outstanding_amount -= Convert.ToInt32(tbxIncomeTax.Text);
                        Insertion i = new Insertion();
                        error = i.insertReceipt(tbxInvoiceNo.Text, tbxReceipt.Text, dtpReceipt.Value, tbxRemarks.Text, tbxCC.Text, float.Parse(tbxAmount.Text), float.Parse(tbxIncomeTax.Text));                       
                        is_save_click = true;
                    }
                    else if (edit == 1)
                    {
                        if (tbxIncomeTax.Text != "" && tbxIncomeTax.Text != "0")
                            outstanding_amount -= Convert.ToInt32(tbxIncomeTax.Text);
                        u.updateReceipt(receiptid, tbxReceipt.Text, dtpReceipt.Value, tbxRemarks.Text, tbxCC.Text, float.Parse(tbxAmount.Text), float.Parse(tbxIncomeTax.Text));                       
                        is_save_click = true;
                    }
                    if (error == 0)
                    {
                        if (outstanding_amount >= 0)
                            u.updatePaidAmount(tbxInvoiceNo.Text, outstanding_amount);
                        else
                            u.updatePaidAmount(tbxInvoiceNo.Text, 0);
                    }
                }
            }
            
        }

        private void butDetails_Click(object sender, EventArgs e)
        {
            if (panelGV.Visible)
            {
                Main_Class.disable_reset(panelControls);
                Main_Class.disable_reset(panelinvoice);
                panelGV.Visible = false;
                labelsearch.Visible = false;
                tbxSearch.Visible = false;
            }
            else
            {
                Main_Class.disable_reset(panelinvoice);
                panelGV.Visible = true;
                labelsearch.Visible = true;
                tbxSearch.Visible = true;
                r.showReceipts(dgvReceipt, IDGV, InvoiceNoGv, ReceiptNoGv, DateGV, RemarksGv, CCGV, IncomeTaxGV, AmountGV, PaidAmountGV,InvoiceDateGV,InvoiceAmountGV);
            }
        }

        private void dgvReceipt_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvReceipt, e);
        }

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

                butDetails.Enabled = false;
                butSave.Enabled = true;
                butCancel.Enabled = true;
                butAdd.Enabled = false;
                butEdit.Enabled = false;
                butDelete.Enabled = false;
                tbxIncomeTax.Enabled = true;
                edit = 1;
                Main_Class.enable(panelControls);
                selected = 0;
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
                    d.delete(receiptid, "sp_deleteReceipt", "@ID");
                    r.showReceipts(dgvReceipt, IDGV, InvoiceNoGv, ReceiptNoGv, DateGV, RemarksGv, CCGV, IncomeTaxGV, AmountGV, PaidAmountGV, InvoiceDateGV, InvoiceAmountGV);
                    Main_Class.disable_reset(panelControls);
                    selected = 0;
                    u.updatePaidAmount(tbxInvoiceNo.Text, float.Parse(tbxInvoiceAmount.Text));
                }
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (tbxReceipt.Text != "")
            {
                ReportForm obj = new ReportForm("Receipt", "\\Reports\\Receipt.rpt", "With Parameters", "sp_getReceiptforReport", "@ReceiptNo", tbxReceipt.Text);
                obj.ShowDialog();
            }
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != " ")
            {
                r.showReceipts(dgvReceipt, IDGV, InvoiceNoGv, ReceiptNoGv, DateGV, RemarksGv, CCGV, IncomeTaxGV, AmountGV, PaidAmountGV, InvoiceDateGV, InvoiceAmountGV, tbxSearch.Text);
            }
            else
            {
                r.showReceipts(dgvReceipt, IDGV, InvoiceNoGv, ReceiptNoGv, DateGV, RemarksGv, CCGV, IncomeTaxGV, AmountGV, PaidAmountGV, InvoiceDateGV, InvoiceAmountGV);
            }
        }

        private void dgvReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvReceipt.Rows[e.RowIndex];
                receiptid = Convert.ToInt64(row.Cells["IDGV"].Value.ToString());
                tbxInvoiceNo.Text = row.Cells["InvoiceNoGv"].Value.ToString();
                tbxReceipt.Text = row.Cells["ReceiptNoGv"].Value.ToString();
                dtpReceipt.Value = Convert.ToDateTime(row.Cells["DateGV"].Value.ToString());
                tbxRemarks.Text = row.Cells["RemarksGv"].Value.ToString();
                tbxCC.Text = row.Cells["CCGV"].Value.ToString();
                tbxIncomeTax.Text = row.Cells["IncomeTaxGV"].Value.ToString();
                tbxAmount.Text = row.Cells["AmountGV"].Value.ToString();
                tbxOutstandingAmount.Text = row.Cells["PaidAmountGV"].Value.ToString();
                tbxInvoiceAmount.Text = row.Cells["InvoiceAmountGV"].Value.ToString();
                tbxInvoiceDate.Text = row.Cells["InvoiceDateGV"].Value.ToString();
                outstanding_amount = Convert.ToInt32(row.Cells["PaidAmountGV"].Value.ToString());
                Main_Class.disable(panelControls);
            }
        }
    }
}

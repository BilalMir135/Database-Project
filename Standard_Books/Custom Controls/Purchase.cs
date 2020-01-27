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
    public partial class Purchase : UserControl
    {
        public Purchase()
        {
            InitializeComponent();
        }
        Retreival r = new Retreival();
        Updation u = new Updation();
        int total_quantity;
        float final_amount, final_total_amount;
        byte edit;
        long purchaseid;
        private void Purchase_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Purchase";
            Main_Form.Instance.Form = new Transaction();
            r.getData("get_supplierList", "Name", "ID", cbxSupplier);
            Main_Class.disable(panelPurchase);
            tbxISBN.Enabled = false;
            tbxQuantity.Enabled = false;
            tbxDiscount.Enabled = false;
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
            if(tbxQuantity.Text!= " " && tbxQuantity.Text != "" && tbxPrice.Text!=" " && tbxPrice.Text!="")
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
            if (tbxDiscount.Text != " " && tbxDiscount.Text != "" && tbxBookAmount.Text!=" " && tbxBookAmount.Text != " ")
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

        private void butAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            butSearch.Enabled = false;
            butSave.Enabled = true;
            butCancel.Enabled = true;
            butAdd.Enabled = false;
            butPurchaseSave.Enabled = true;
            Main_Class.enable_reset(panelPurchase);
            tbxPurchaseNo.Focus();
        }

        bool Issaveclick;
        int count;
        private void butSave_Click(object sender, EventArgs e)
        {
            if (Issaveclick == false)
            {
                if (edit == 1 && dgvPurchase.Rows.Count > 0 && !butPurchaseSave.Enabled)
                {
                    DataTable dt = r.getDetails("sp_getPurchaseDetails", "@PurchaseID", purchaseid);
                    foreach(DataRow row in dt.Rows)
                    {
                        int stockquantity = r.getStockQuantity(row["ISBN"].ToString());
                        stockquantity -= Convert.ToInt32(row["Quantity"].ToString());
                        u.updateStock(row["ISBN"].ToString(), stockquantity);
                    }
                    Deletion d = new Deletion();
                    d.delete_without_message(purchaseid, "sp_deletePurchase", "@PurchaseID");
                    Issaveclick = true;
                }

                if (dgvPurchase.Rows.Count > 0 && !butPurchaseSave.Enabled)
                {
                    Insertion i = new Insertion();
                    using (TransactionScope scope = new TransactionScope())
                    {
                        purchaseid = i.insertPurchase(tbxPurchaseNo.Text, dtpPurchase.Value, tbxReference.Text, Convert.ToInt32(tbxTotalQuantity.Text), float.Parse(tbxAmount.Text), float.Parse(tbxTotalAmount.Text), Convert.ToInt32(cbxSupplier.SelectedValue));
                        foreach (DataGridViewRow row in dgvPurchase.Rows)
                        {
                            count += i.insertBookDetails(purchaseid, "@PurchaseID", "sp_insertPurchaseDetail", row.Cells["ISBNGV"].Value.ToString(), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), float.Parse(row.Cells["AmountGV"].Value.ToString()), float.Parse(row.Cells["DiscountGV"].Value.ToString()), float.Parse(row.Cells["FinalAmountGV"].Value.ToString()), float.Parse(row.Cells["PriceGV"].Value.ToString()));
                            int stockquantity = r.getStockQuantity(row.Cells["ISBNGV"].Value.ToString());                             
                             stockquantity += Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                             u.updateStock(row.Cells["ISBNGV"].Value.ToString(), stockquantity);                           
                        }
                        if (count > 0)
                        {
                            Custom_Message_Box.Show("Purchase Invoice created successfuly", "Success", MessageBoxIcons.Information, MessageBoxButtons.OK);
                        }
                        else
                        {
                            Custom_Message_Box.Show("Unable to create purchase invoice", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                        }
                        scope.Complete();
                        Issaveclick = true;
                    }
                }
            }
            
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Issaveclick = false;
            butEdit.Enabled = false;
            butSearch.Enabled = true;
            butPurchaseSave.Enabled = false;
            butSave.Enabled = false;
            butCancel.Enabled = false;
            butAdd.Enabled = true;
            butAddtocart.Enabled = false;
            Main_Class.disable_reset(panelPurchase);
            Main_Class.disable_reset(panelControls);
            tbxISBN.Enabled = false;
            tbxQuantity.Enabled = false;
            tbxDiscount.Enabled = false;
            if (dgvPurchase.Rows.Count != 0)
            {
                dgvPurchase.Rows.Clear();
            }
            tbxTotalQuantity.Text = "0";
            tbxAmount.Text = "0";
            tbxTotalAmount.Text = "0";
            total_quantity = 0; final_amount = 0; final_total_amount = 0;
        }

        bool Is_Same_Row;
        private void butAddtocart_Click(object sender, EventArgs e)
        {
            if(tbxISBN.Text!="" && tbxCurrency.Text!="" && tbxPrice.Text!=""&& tbxExchangeRate.Text!="" && tbxQuantity.Text!="" && tbxBookAmount.Text!="" && tbxDiscount.Text!="" && tbxBookTotalAmount.Text!="")
            {
                if(dgvPurchase.Rows.Count != 0)      //if dgv is empty then loop will not work 
                {
                    foreach (DataGridViewRow row in dgvPurchase.Rows)            //restricting fomr the same double entry of same book
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
                    if (Is_Same_Row==false)
                    {
                        dgvPurchase.Rows.Add(0, tbxISBN.Text, title, tbxPrice.Text, tbxQuantity.Text, tbxBookAmount.Text, tbxDiscount.Text, tbxBookTotalAmount.Text);
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
                    dgvPurchase.Rows.Add(0, tbxISBN.Text, title, tbxPrice.Text, tbxQuantity.Text, tbxBookAmount.Text, tbxDiscount.Text, tbxBookTotalAmount.Text);
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
        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 8)
                {
                    DataGridViewRow row = dgvPurchase.Rows[e.RowIndex];
                    total_quantity -= Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                    final_amount -= float.Parse(row.Cells["AmountGV"].Value.ToString());
                    final_total_amount -= float.Parse(row.Cells["FinalAmountGV"].Value.ToString());
                    dgvPurchase.Rows.Remove(row);
                    tbxTotalQuantity.Text = total_quantity.ToString();
                    if (dgvPurchase.Rows.Count != 0)
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

        private void butPurchaseSave_Click(object sender, EventArgs e)
        {
            if(tbxPurchaseNo.Text!="" && cbxSupplier.SelectedIndex != -1)
            {
                tbxISBN.Enabled = true;
                tbxQuantity.Enabled = true;
                tbxPrice.Enabled = true;
                tbxDiscount.Enabled = true;
                butPurchaseSave.Enabled = false;
                butAddtocart.Enabled = true;
                Main_Class.disable(panelPurchase);
                tbxISBN.Focus();
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            butSave.Enabled = true;
            Main_Class.enable(panelPurchase);
            butPurchaseSave.Enabled = true;
        }

        private string[] PurchaseData = new string[7];

        private void butSearch_Click(object sender, EventArgs e)
        {
            if (tbxPurchaseNo.Text == "")
            {
                butAdd.Enabled = false;
                butCancel.Enabled = true;
                tbxPurchaseNo.Enabled = true;
                tbxPurchaseNo.Focus();
            }
            else
            {
                PurchaseData = r.getPurchasebyPurchaseNo(tbxPurchaseNo.Text);
                if (PurchaseData[0] != null)
                {
                    butEdit.Enabled = true;
                    butSearch.Enabled = false;
                    purchaseid = Convert.ToInt64(PurchaseData[0]);
                    dtpPurchase.Value = Convert.ToDateTime(PurchaseData[1]);
                    tbxTotalQuantity.Text = PurchaseData[2];
                    tbxTotalAmount.Text = PurchaseData[3];
                    tbxAmount.Text = PurchaseData[4];
                    cbxSupplier.Text = PurchaseData[5];
                    tbxReference.Text = PurchaseData[6];
                    total_quantity = Convert.ToInt32(tbxTotalQuantity.Text);
                    final_amount = float.Parse(tbxAmount.Text);
                    final_total_amount = float.Parse(tbxTotalAmount.Text);
                    dgvPurchase.AutoGenerateColumns = false;
                    r.showDetails(dgvPurchase, "sp_getPurchaseDetails", "@PurchaseID", purchaseid);
                    Array.Clear(PurchaseData, 0, PurchaseData.Length);
                }               
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (tbxPurchaseNo.Text != "")
            {
                ReportForm obj = new ReportForm("Purchases", "\\Reports\\Purchase.rpt", "With Parameters", "sp_getPurchaseforReport", "@PurchaseNo", tbxPurchaseNo.Text);
                obj.ShowDialog();
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

        private void dgvPurchase_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvPurchase, e);
        }
    }
}

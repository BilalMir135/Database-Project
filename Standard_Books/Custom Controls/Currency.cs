using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Standard_Books.Classes;

namespace Standard_Books.Custom_Controls
{
    public partial class Currency : UserControl
    {
        public Currency()
        {
            InitializeComponent();
        }
        byte edit = 0;
        byte selected = 0;
        int currencyID;
        Retreival r = new Retreival();
        private void butEdit_Click(object sender, EventArgs e)
        {
            if (selected == 1)  //if dgv cell is selected than it will work
            {
                butSave.Enabled = true;
                butCancel.Enabled = true;
                butAdd.Enabled = false;
                butEdit.Enabled = false;
                butDelete.Enabled = false;
                edit = 1;
                Main_Class.enable(panelControls);
                selected = 0;
            }
            
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            butSave.Enabled = false;
            butCancel.Enabled = false;
            butAdd.Enabled = true;
            butEdit.Enabled = true;
            butDelete.Enabled = true;
            Main_Class.disable_reset(panelControls);
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (selected == 1)
            {
               DialogResult dr = Custom_Message_Box.Show("Are you sure?", "Delete", MessageBoxIcons.Question, MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(currencyID, "sp_deleteCurrency", "@CurrencyID");
                    r.showCurrency(dgvCurrency, CurrencyIDGV, SymbolGV, CurrencyGV, ExchangeRateGV);
                    Main_Class.disable_reset(panelControls);
                    selected = 0;
                }
            }         
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            butSave.Enabled = true;
            butCancel.Enabled = true;
            butAdd.Enabled = false;
            butEdit.Enabled = false;
            butDelete.Enabled = false;
            edit = 0;
            Main_Class.enable_reset(panelControls);
            tbxSymbol.Focus();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (tbxCurrency.Text != "" && tbxSymbol.Text != "" && tbxExchangeRate.Text != "")
            {
                if (edit == 0)  //Code for Add
                {
                    Insertion i = new Insertion();
                    i.insertCurrency(tbxSymbol.Text, tbxCurrency.Text, float.Parse(tbxExchangeRate.Text));
                    r.showCurrency(dgvCurrency, CurrencyIDGV, SymbolGV, CurrencyGV, ExchangeRateGV);                 
                    Main_Class.disable_reset(panelControls);
                }
                else if (edit == 1) //Code for Update
                {                  
                    Updation u = new Updation();
                    u.updateCurrency(currencyID, tbxSymbol.Text, tbxCurrency.Text, float.Parse(tbxExchangeRate.Text));
                    r.showCurrency(dgvCurrency, CurrencyIDGV, SymbolGV, CurrencyGV, ExchangeRateGV);
                    Main_Class.disable_reset(panelControls);
                }
                
            }
            else
            {
                Custom_Message_Box.Show("All fields are mandatory.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }          
        }

        private void tbxExchangeRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Main_Class.allow_numbers(tbxExchangeRate, e);
        }

        private void Currency_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = true;
            Main_Form.Instance.Title.Text = "Currency";
            Main_Form.Instance.Form = new Master_Enteries();
            Main_Class.disable(panelControls);
            r.showCurrency(dgvCurrency, CurrencyIDGV, SymbolGV, CurrencyGV, ExchangeRateGV);
        }

        private void dgvCurrency_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Main_Class.get_sno(dgvCurrency, e);
        }

        private void dgvCurrency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selected = 1;
                DataGridViewRow row = dgvCurrency.Rows[e.RowIndex];
                currencyID = Convert.ToInt32(row.Cells["CurrencyIDGV"].Value.ToString());
                tbxSymbol.Text = row.Cells["SymbolGV"].Value.ToString();
                tbxCurrency.Text = row.Cells["CurrencyGV"].Value.ToString();
                tbxExchangeRate.Text = row.Cells["ExchangeRateGV"].Value.ToString();
                Main_Class.disable(panelControls);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbxSearch.Text!=" ")
            {
                r.showCurrency(dgvCurrency, CurrencyIDGV, SymbolGV, CurrencyGV, ExchangeRateGV, tbxSearch.Text);
            }
            else
            {
                r.showCurrency(dgvCurrency, CurrencyIDGV, SymbolGV, CurrencyGV, ExchangeRateGV);
            }
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            ReportForm obj = new ReportForm("Currency List", "\\Reports\\Currency.rpt", "Without Parameters");
            obj.ShowDialog();
            
        }
    }
}

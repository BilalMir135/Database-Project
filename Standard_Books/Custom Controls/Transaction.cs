using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Books.Custom_Controls
{
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }
       
        private void butInvoice_Click(object sender, EventArgs e)
        {
            Invoice obj = new Invoice();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butPurchase_Click(object sender, EventArgs e)
        {
            Purchase obj = new Purchase();
            Main_Form.Instance.panel_loading(obj);
        }
        private void butPurchaseRecord_Click(object sender, EventArgs e)
        {
            PurchaseRecord obj = new PurchaseRecord();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butInvoiceRecord_Click(object sender, EventArgs e)
        {
            InvoiceRecord obj = new InvoiceRecord();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butChallan_Click(object sender, EventArgs e)
        {
            Challan obj = new Challan();
            Main_Form.Instance.panel_loading(obj); ;
        }

        private void butChallanDetails_Click(object sender, EventArgs e)
        {
            ChallanDetails obj = new ChallanDetails();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butQuotation_Click(object sender, EventArgs e)
        {
            Quotation obj = new Quotation();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butQuotationDetails_Click(object sender, EventArgs e)
        {
            QuotationDetails obj = new QuotationDetails();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butreceipts_Click(object sender, EventArgs e)
        {
            Receipts obj = new Receipts();
            Main_Form.Instance.panel_loading(obj);
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = false;
            Main_Form.Instance.Title.Text = "Transactions";
        }
    }
}

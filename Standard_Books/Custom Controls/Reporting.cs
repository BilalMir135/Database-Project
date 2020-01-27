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
    public partial class Reporting : UserControl
    {
        public Reporting()
        {
            InitializeComponent();
        }
        Report_ParameterForm obj;      

        private void butOutstandingChallans_Click(object sender, EventArgs e)
        {
            obj = new Report_ParameterForm("Outstanding Challans", "Enter Batch No.");
            obj.ShowDialog();
        }

        private void butOutstandingInvoices_Click(object sender, EventArgs e)
        {
            obj = new Report_ParameterForm("Outstanding Invoices", "Enter Batch No.");
            obj.ShowDialog();
        }

        private void butPartyLedger_Click(object sender, EventArgs e)
        {
            obj = new Report_ParameterForm("Party Ledger", "Enter Party Code :");
            obj.ShowDialog();
        }      
        private void butInvoiceReport_Click(object sender, EventArgs e)
        {
            obj = new Report_ParameterForm("Invoice Report", "Enter Batch No.");
            obj.ShowDialog();
        }

        private void butTagTrack_Click(object sender, EventArgs e)
        {
            obj = new Report_ParameterForm("Tag Track", "Enter ISBN :");
            obj.ShowDialog();
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = false;
            Main_Form.Instance.Title.Text = "Reports";
        }
    }
}

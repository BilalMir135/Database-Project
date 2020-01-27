using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Books
{
    public partial class Report_ParameterForm : Form
    {
        public Report_ParameterForm(string title, string content)
        {                
            InitializeComponent();
            labelTitle.Text = title;
            labelContent.Text = content;
            tbxValue.Focus();

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butPreview_Click(object sender, EventArgs e)
        {
            if (tbxValue.Text != "")
            {
                ReportForm obj;
                if (labelTitle.Text == "Outstanding Challans")
                {
                    obj = new ReportForm("Outstanding Challans", "\\Reports\\OutstandingChallans.rpt", "With Parameters", "sp_getOutstandingChallanforReport", "@Batch", tbxValue.Text);
                    obj.ShowDialog();
                }
                else if(labelTitle.Text == "Outstanding Invoices")
                {
                    obj = new ReportForm("Outstanding Invoices", "\\Reports\\OutstandingInvoices.rpt", "With Parameters", "sp_getOutstandingInvoiceforReport", "@Batch", tbxValue.Text);
                    obj.ShowDialog();
                }
                else if(labelTitle.Text == "Invoice Report")
                {
                    obj = new ReportForm("Invoice Report", "\\Reports\\InvoiceReport.rpt", "With Parameters", "sp_getInvoiceReport", "@Batch", tbxValue.Text);
                    obj.ShowDialog();
                }
                else if(labelTitle.Text == "Party Ledger")
                {
                    obj = new ReportForm("Party Ledger", "\\Reports\\PartyLedger.rpt", "With Parameters", "sp_getPartyLedgerforReport", "@Code", tbxValue.Text);
                    obj.ShowDialog();
                }
                else if (labelTitle.Text == "Tag Track")
                {
                    obj = new ReportForm("Tag Track", "\\Reports\\TagTrack.rpt", "With Parameters", "sp_getTagTrackforreport", "@ISBN", tbxValue.Text);
                    obj.ShowDialog();
                }
            }         
        }

        int x, y;
        bool isMove;
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y; isMove = true;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
    }
}

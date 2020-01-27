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
    public partial class Lists : UserControl
    {
        public Lists()
        {
            InitializeComponent();
        }
        ReportForm obj;

        private void butBooks_Click(object sender, EventArgs e)
        {
            BooksReporting obj = new BooksReporting();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butSubject_Click(object sender, EventArgs e)
        {
            obj = new ReportForm("Subject List", "\\Reports\\Subject.rpt", "Without Parameters");
            obj.ShowDialog();
        }

        private void butPublisher_Click(object sender, EventArgs e)
        {
            obj = new ReportForm("Publisher List", "\\Reports\\Publisher.rpt", "Without Parameters");
            obj.ShowDialog();
        }

        private void butAuthor_Click(object sender, EventArgs e)
        {
            obj = new ReportForm("Author List", "\\Reports\\Author.rpt", "Without Parameters");
            obj.ShowDialog();
        }

        private void butParty_Click(object sender, EventArgs e)
        {
            obj = new ReportForm("Party List", "\\Reports\\Party.rpt", "Without Parameters");
            obj.ShowDialog();
        }

        private void butSupplier_Click(object sender, EventArgs e)
        {
            obj = new ReportForm("Supplier List", "\\Reports\\Supplier.rpt", "Without Parameters");
            obj.ShowDialog();
        }

        private void butCurrency_Click(object sender, EventArgs e)
        {
            obj = new ReportForm("Currency List", "\\Reports\\Currency.rpt", "Without Parameters");
            obj.ShowDialog();
        }

        private void butFreight_Click(object sender, EventArgs e)
        {
            obj = new ReportForm("Freight List", "\\Reports\\Freight.rpt", "Without Parameters");
            obj.ShowDialog();
        }

        private void Lists_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = false;
            Main_Form.Instance.Title.Text = "Lists";
        }
    }
}

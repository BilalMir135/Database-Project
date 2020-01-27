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
    public partial class Master_Enteries : UserControl
    {
        public Master_Enteries()
        {
            InitializeComponent();
        }      
        private void butCurrency_Click(object sender, EventArgs e)
        {
            Currency obj = new Currency();
            Main_Form.Instance.panel_loading(obj); ;
        }

        private void butFreight_Click(object sender, EventArgs e)
        {
            Freight obj = new Freight();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butPublisher_Click(object sender, EventArgs e)
        {
            Publisher obj = new Publisher();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butSubject_Click(object sender, EventArgs e)
        {
            Subject obj = new Subject();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butAuthor_Click(object sender, EventArgs e)
        {
            Author obj = new Author();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butBooks_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butParty_Click(object sender, EventArgs e)
        {
            Party obj = new Party();
            Main_Form.Instance.panel_loading(obj);
        }

        private void butSupplier_Click(object sender, EventArgs e)
        {
            Supplier obj = new Supplier();
            Main_Form.Instance.panel_loading(obj);
        }

        private void Master_Enteries_Load(object sender, EventArgs e)
        {
            Main_Form.Instance.BackButton.Visible = false;
            Main_Form.Instance.Title.Text = "Master Entries";
        }
    }
}

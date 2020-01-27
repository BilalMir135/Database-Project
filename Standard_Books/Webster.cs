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
    public partial class Webster : Form
    {
        public Webster()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelFb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/WebsterDD");
        }

        private void labelLinkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/bilal-mir-ab662a181/");
        }

        private void labelWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://websterinfo.ga/");
        }
    }
}

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
    public partial class Splash_Screen : Form
    {
        byte value = 0;
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            value += 2;
            labelPercentage.Text = value.ToString();
            bunifuProgressBar1.Value = value;
            if (bunifuProgressBar1.Value >= 100)
            {
                timer1.Stop();
                Login_Form obj = new Login_Form();
                obj.Show();
                this.Hide();
            }
                
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

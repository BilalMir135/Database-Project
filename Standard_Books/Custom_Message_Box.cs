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
    public partial class Custom_Message_Box : Form
    {
        public Custom_Message_Box()
        {
            InitializeComponent();     
            
        }
        static Custom_Message_Box message;
        static DialogResult result = DialogResult.No;
        public static DialogResult Show(string text, string caption, MessageBoxIcons icon = MessageBoxIcons.None, MessageBoxButtons button = MessageBoxButtons.OK)
        {
            message = new Custom_Message_Box();
            message.tbxMessage.Text = text;
            message.labelCaption.Text = caption;

            if (icon == MessageBoxIcons.Error)
                message.pictureBox1.Image = Properties.Resources.Error;
            else if (icon == MessageBoxIcons.Information)
                message.pictureBox1.Image = Properties.Resources.Information;
            else if (icon == MessageBoxIcons.Warning)
                message.pictureBox1.Image = Properties.Resources.Warning;
            else if (icon == MessageBoxIcons.Question)
                message.pictureBox1.Image = Properties.Resources.question;

            if (button == MessageBoxButtons.OKCancel)
            {
                message.but1.ButtonText = "OK";
                message.but2.ButtonText = "Cancel";
            }
            else if(button == MessageBoxButtons.RetryCancel)
            {
                message.but1.ButtonText = "Retry";
                message.but2.ButtonText = "Cancel";
            }
            else if (button == MessageBoxButtons.YesNo)
            {
                message.but1.ButtonText = "Yes";
                message.but2.ButtonText = "No";
            }
            else
            {
                message.but1.Visible = false;
                message.but2.ButtonText = "OK";
            }  

            message.ShowDialog();
            return result;
        }
        private void butClose_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (but1.Visible)
            {
                if (but2.ButtonText == "Cancel")
                    result = DialogResult.Cancel; 
                else
                    result = DialogResult.No;
            }
            else
            {
                result = DialogResult.OK;
            }
            this.Close();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (but1.ButtonText == "Yes")
                result = DialogResult.Yes;       //OK = Yes = Retry
            else if (but1.ButtonText == "Retry")
                result = DialogResult.Retry;
            else
                result = DialogResult.OK;
            this.Close();
        }

        #region ScreenMoving
        int x, y;
        bool isMove;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y; isMove = true;
        }
        #endregion
    }
    public enum MessageBoxIcons
    {
        Error=0,
        Information=1,
        Warning=2,
        Question=3,
        None=4
    }
    public enum MessageBoxButtons
    {
        OK=0,
        OKCancel=1,
        RetryCancel=2,
        YesNo=3
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Standard_Books.Classes
{
    class Main_Class
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string connString = File.ReadAllText(path + "\\SB settings");
        public static SqlConnection connection = new SqlConnection(connString);
        public static void enable_reset(Panel p)
        {
            //Clear and enable all controls
            foreach (Control x in p.Controls)
            {
                if (x is TextBox)
                {
                    TextBox tbx = (TextBox)x;
                    tbx.Text = "";
                    tbx.Enabled = true;
                }
                else if (x is ComboBox)
                {
                    ComboBox cbx = (ComboBox)x;
                    cbx.SelectedIndex = -1;
                    cbx.Enabled = true;
                }
                else if(x is RadioButton)
                {
                    RadioButton rbut = (RadioButton)x;
                    rbut.Checked = false;
                    rbut.Enabled = true;
                }
                else if(x is CheckBox)
                {
                    CheckBox chbx = (CheckBox)x;
                    chbx.Checked = false;
                    chbx.Enabled = true;
                }
                else if (x is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)x;
                    dtp.Value = DateTime.Now;
                    dtp.Enabled = true;
                }
            }
            
        }
        public static void disable_reset(Panel p)
        {
            //Clear and disable all controls
            foreach (Control x in p.Controls)
            {
                if (x is TextBox)
                {
                    TextBox tbx = (TextBox)x;
                    tbx.Text = "";
                    tbx.Enabled = false;
                }
                else if (x is ComboBox)
                {
                    ComboBox cbx = (ComboBox)x;
                    cbx.Text = " ";
                    cbx.Enabled = false;
                }
                else if (x is RadioButton)
                {
                    RadioButton rbut = (RadioButton)x;
                    rbut.Checked = false;
                    rbut.Enabled = false;
                }
                else if (x is CheckBox)
                {
                    CheckBox chbx = (CheckBox)x;
                    chbx.Checked = false;
                    chbx.Enabled = false;
                }
                else if (x is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)x;
                    dtp.Value = DateTime.Now;
                    dtp.Enabled = false;
                }
            }

        }
        public static void disable(Panel p)
        {
            //Disable all controls
            foreach (Control x in p.Controls)
            {
                if (x is TextBox)
                {
                    TextBox tbx = (TextBox)x;
                    tbx.Enabled = false;
                }
                else if (x is ComboBox)
                {
                    ComboBox cbx = (ComboBox)x;
                    cbx.Enabled = false;
                }
                else if (x is RadioButton)
                {
                    RadioButton rbut = (RadioButton)x;
                    rbut.Enabled = false;
                }
                else if (x is CheckBox)
                {
                    CheckBox chbx = (CheckBox)x;
                    chbx.Enabled = false;
                }
                else if (x is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)x;
                    dtp.Enabled = false;
                }
            }

        }
        public static void enable(Panel p)
        {
            //Enable all controls
            foreach (Control x in p.Controls)
            {
                if (x is TextBox)
                {
                    TextBox tbx = (TextBox)x;
                    tbx.Enabled = true;
                }
                else if (x is ComboBox)
                {
                    ComboBox cbx = (ComboBox)x;
                    cbx.Enabled = true;
                }
                else if (x is RadioButton)
                {
                    RadioButton rbut = (RadioButton)x;
                    rbut.Enabled = true;
                }
                else if (x is CheckBox)
                {
                    CheckBox chbx = (CheckBox)x;
                    chbx.Enabled = true;
                }
                else if (x is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)x;
                    dtp.Enabled = true;
                }
            }

        }
        public static void reset(Panel p)
        {
            //Clear all controls
            foreach (Control x in p.Controls)
            {
                if (x is TextBox)
                {
                    TextBox tbx = (TextBox)x;
                    tbx.Text = "";
                }
                else if (x is ComboBox)
                {
                    ComboBox cbx = (ComboBox)x;
                    cbx.SelectedIndex = -1;
                }
                else if (x is RadioButton)
                {
                    RadioButton rbut = (RadioButton)x;
                    rbut.Checked = false;
                }
                else if (x is CheckBox)
                {
                    CheckBox chbx = (CheckBox)x;
                    chbx.Checked = false;
                }
                else if (x is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)x;
                    dtp.Value = DateTime.Now;
                }
            }
        }
        public static void allow_numbers(TextBox tbx, KeyPressEventArgs e)
        {
            //Only allow digits in textbox
            char ch = e.KeyChar;
            if (ch == 46 && tbx.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsNumber(ch) && ch != 46 && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }
        public static void allow_int_numbers(TextBox tbx, KeyPressEventArgs e)
        {
            //Only allow integers in textbox
            char ch = e.KeyChar;      
            if (!char.IsNumber(ch)  && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }
        public static void allow_phonenumbers(TextBox tbx, KeyPressEventArgs e)
        {
            //Only allows phone numbers with + -
            char ch = e.KeyChar;
            if (ch == 43 && tbx.Text.IndexOf('+') != -1)
            {
                e.Handled = true;
                return;
            }
            else if(ch == 45 && tbx.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsNumber(ch) && ch != 43 && ch != 45 && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }
        public static void get_sno(DataGridView dgv, DataGridViewRowPostPaintEventArgs e)
        {
            dgv.Rows[e.RowIndex].Cells["SNOGV"].Value = (e.RowIndex + 1).ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Standard_Books.Custom_Controls;

namespace Standard_Books
{
    public partial class Main_Form : Form
    {
        
        int panel_width;
        bool iscollapsed;
        public Main_Form()
        {
            InitializeComponent();
            MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            panel_width = panelMenu.Width;
            iscollapsed = false;
        }

        static Main_Form main_form;
        public static Main_Form Instance
        {
            get
            {
                if (main_form == null)
                {
                    main_form = new Main_Form();
                }
                return main_form;
            }
        }
        UserControl _obj;
        public UserControl Form
        {
            get { return _obj; }
            set { _obj = value; }
        }
        public PictureBox BackButton
        {
            get { return backbutton; }
            set { backbutton = value; }
        }    
        public Label Title
        {
            get { return labelHeading; }
            set { labelHeading = value; }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollapsed)
            {
                panelMenu.Width += 30;
                if (panelMenu.Width >= panel_width)
                {
                    timer1.Stop();
                    iscollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelMenu.Width -= 30;
                if(panelMenu.Width <= 49)
                {
                    timer1.Stop();
                    iscollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void butScroll_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbxMaximize_MouseHover(object sender, EventArgs e)
        {
            pbxMaximize.BackColor = Color.FromArgb(17, 144, 203);
            if (WindowState == FormWindowState.Normal)
                pbxMaximize.Image = Properties.Resources.Icono_Maximizar___Hover;
            else
                pbxMaximize.Image = Properties.Resources.Maximized_Hover;
        }

        private void pbxMaximize_MouseLeave(object sender, EventArgs e)
        {
            pbxMaximize.BackColor = Color.White;
            if(WindowState == FormWindowState.Normal)
                pbxMaximize.Image = Properties.Resources.Icono_Maximizar;
            else
                pbxMaximize.Image = Properties.Resources.maximized;
        }

        private void pbxMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                pbxMaximize.Image = Properties.Resources.maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                pbxMaximize.Image = Properties.Resources.Icono_Maximizar;
            }
        }

        #region ScreenMoving
        int x, y;
        bool isMove;
        private void panelControls_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void panelControls_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
     
        private void panelControls_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y; isMove = true;
        }
        #endregion

        public void panel_loading(UserControl sender)
        {          
            panelBody.Controls.Clear();
            sender.Dock = DockStyle.Fill;
            panelBody.Controls.Add(sender);
        }
        private void butTransactions_Click(object sender, EventArgs e)
        {
            Transaction obj = new Transaction();
            panel_loading(obj);
        }

        private void butSettings_Click(object sender, EventArgs e)
        {
            SettingPanel obj = new SettingPanel();
            panel_loading(obj);
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Login_Form obj = new Login_Form();
            obj.Show();
            this.Hide();
        }

        private void butReports_Click(object sender, EventArgs e)
        {
            Reporting obj = new Reporting();
            panel_loading(obj);
        }

        private void butLists_Click(object sender, EventArgs e)
        {
            Lists obj = new Lists();
            panel_loading(obj);
        }

        private void backbutton_MouseHover(object sender, EventArgs e)
        {
            backbutton.Image = Properties.Resources.back;
            backbutton.BackColor = Color.FromArgb(17, 144, 203);
        }

        private void backbutton_MouseLeave(object sender, EventArgs e)
        {
            backbutton.Image = Properties.Resources.back_hover;
            backbutton.BackColor = Color.White;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            panel_loading(_obj);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            main_form = this;
            Home obj = new Home();
            panel_loading(obj);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            panel_loading(obj);
        }

        private void butMasterEntries_Click(object sender, EventArgs e)
        {
            Master_Enteries obj = new Master_Enteries();
            panel_loading(obj);
        }




    }
}

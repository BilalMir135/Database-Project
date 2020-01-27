namespace Standard_Books
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.butLists = new ns1.BunifuFlatButton();
            this.butLogout = new ns1.BunifuFlatButton();
            this.butSettings = new ns1.BunifuFlatButton();
            this.butReports = new ns1.BunifuFlatButton();
            this.butTransactions = new ns1.BunifuFlatButton();
            this.butMasterEntries = new ns1.BunifuFlatButton();
            this.panelMenuHead = new System.Windows.Forms.Panel();
            this.butScroll = new ns1.BunifuTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelColorLine = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.butMinimize = new ns1.BunifuFlatButton();
            this.pbxMaximize = new System.Windows.Forms.PictureBox();
            this.butClose = new ns1.BunifuFlatButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelMenuHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.panelMenu.Controls.Add(this.butLists);
            this.panelMenu.Controls.Add(this.butLogout);
            this.panelMenu.Controls.Add(this.butSettings);
            this.panelMenu.Controls.Add(this.butReports);
            this.panelMenu.Controls.Add(this.butTransactions);
            this.panelMenu.Controls.Add(this.butMasterEntries);
            this.panelMenu.Controls.Add(this.panelMenuHead);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(226, 556);
            this.panelMenu.TabIndex = 0;
            // 
            // butLists
            // 
            this.butLists.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butLists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLists.BorderRadius = 0;
            this.butLists.ButtonText = "    Lists";
            this.butLists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLists.DisabledColor = System.Drawing.Color.Gray;
            this.butLists.Iconcolor = System.Drawing.Color.Transparent;
            this.butLists.Iconimage = global::Standard_Books.Properties.Resources.list;
            this.butLists.Iconimage_right = null;
            this.butLists.Iconimage_right_Selected = null;
            this.butLists.Iconimage_Selected = null;
            this.butLists.IconMarginLeft = 0;
            this.butLists.IconMarginRight = 0;
            this.butLists.IconRightVisible = true;
            this.butLists.IconRightZoom = 0D;
            this.butLists.IconVisible = true;
            this.butLists.IconZoom = 55D;
            this.butLists.IsTab = true;
            this.butLists.Location = new System.Drawing.Point(0, 200);
            this.butLists.Name = "butLists";
            this.butLists.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butLists.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butLists.OnHoverTextColor = System.Drawing.Color.White;
            this.butLists.selected = false;
            this.butLists.Size = new System.Drawing.Size(226, 41);
            this.butLists.TabIndex = 9;
            this.butLists.Text = "    Lists";
            this.butLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLists.Textcolor = System.Drawing.Color.White;
            this.butLists.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLists.Click += new System.EventHandler(this.butLists_Click);
            // 
            // butLogout
            // 
            this.butLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLogout.BorderRadius = 0;
            this.butLogout.ButtonText = "   Logout";
            this.butLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogout.DisabledColor = System.Drawing.Color.Gray;
            this.butLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.butLogout.Iconimage = global::Standard_Books.Properties.Resources.logout;
            this.butLogout.Iconimage_right = null;
            this.butLogout.Iconimage_right_Selected = null;
            this.butLogout.Iconimage_Selected = null;
            this.butLogout.IconMarginLeft = 0;
            this.butLogout.IconMarginRight = 0;
            this.butLogout.IconRightVisible = true;
            this.butLogout.IconRightZoom = 0D;
            this.butLogout.IconVisible = true;
            this.butLogout.IconZoom = 40D;
            this.butLogout.IsTab = true;
            this.butLogout.Location = new System.Drawing.Point(0, 515);
            this.butLogout.Name = "butLogout";
            this.butLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.butLogout.selected = false;
            this.butLogout.Size = new System.Drawing.Size(226, 41);
            this.butLogout.TabIndex = 8;
            this.butLogout.Text = "   Logout";
            this.butLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLogout.Textcolor = System.Drawing.Color.White;
            this.butLogout.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // butSettings
            // 
            this.butSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSettings.BorderRadius = 0;
            this.butSettings.ButtonText = "   Settings";
            this.butSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSettings.DisabledColor = System.Drawing.Color.Gray;
            this.butSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.butSettings.Iconimage = global::Standard_Books.Properties.Resources.settings;
            this.butSettings.Iconimage_right = null;
            this.butSettings.Iconimage_right_Selected = null;
            this.butSettings.Iconimage_Selected = null;
            this.butSettings.IconMarginLeft = 0;
            this.butSettings.IconMarginRight = 0;
            this.butSettings.IconRightVisible = true;
            this.butSettings.IconRightZoom = 0D;
            this.butSettings.IconVisible = true;
            this.butSettings.IconZoom = 50D;
            this.butSettings.IsTab = true;
            this.butSettings.Location = new System.Drawing.Point(0, 282);
            this.butSettings.Name = "butSettings";
            this.butSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.butSettings.selected = false;
            this.butSettings.Size = new System.Drawing.Size(226, 41);
            this.butSettings.TabIndex = 7;
            this.butSettings.Text = "   Settings";
            this.butSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSettings.Textcolor = System.Drawing.Color.White;
            this.butSettings.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // butReports
            // 
            this.butReports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butReports.BorderRadius = 0;
            this.butReports.ButtonText = "   Reports";
            this.butReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butReports.DisabledColor = System.Drawing.Color.Gray;
            this.butReports.Iconcolor = System.Drawing.Color.Transparent;
            this.butReports.Iconimage = global::Standard_Books.Properties.Resources.report;
            this.butReports.Iconimage_right = null;
            this.butReports.Iconimage_right_Selected = null;
            this.butReports.Iconimage_Selected = null;
            this.butReports.IconMarginLeft = 0;
            this.butReports.IconMarginRight = 0;
            this.butReports.IconRightVisible = true;
            this.butReports.IconRightZoom = 0D;
            this.butReports.IconVisible = true;
            this.butReports.IconZoom = 50D;
            this.butReports.IsTab = true;
            this.butReports.Location = new System.Drawing.Point(0, 241);
            this.butReports.Name = "butReports";
            this.butReports.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butReports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butReports.OnHoverTextColor = System.Drawing.Color.White;
            this.butReports.selected = false;
            this.butReports.Size = new System.Drawing.Size(226, 41);
            this.butReports.TabIndex = 6;
            this.butReports.Text = "   Reports";
            this.butReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butReports.Textcolor = System.Drawing.Color.White;
            this.butReports.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReports.Click += new System.EventHandler(this.butReports_Click);
            // 
            // butTransactions
            // 
            this.butTransactions.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butTransactions.BorderRadius = 0;
            this.butTransactions.ButtonText = "   Transactions";
            this.butTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butTransactions.DisabledColor = System.Drawing.Color.Gray;
            this.butTransactions.Iconcolor = System.Drawing.Color.Transparent;
            this.butTransactions.Iconimage = global::Standard_Books.Properties.Resources.Transaction;
            this.butTransactions.Iconimage_right = null;
            this.butTransactions.Iconimage_right_Selected = null;
            this.butTransactions.Iconimage_Selected = null;
            this.butTransactions.IconMarginLeft = 0;
            this.butTransactions.IconMarginRight = 0;
            this.butTransactions.IconRightVisible = true;
            this.butTransactions.IconRightZoom = 0D;
            this.butTransactions.IconVisible = true;
            this.butTransactions.IconZoom = 60D;
            this.butTransactions.IsTab = true;
            this.butTransactions.Location = new System.Drawing.Point(0, 159);
            this.butTransactions.Name = "butTransactions";
            this.butTransactions.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butTransactions.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butTransactions.OnHoverTextColor = System.Drawing.Color.White;
            this.butTransactions.selected = false;
            this.butTransactions.Size = new System.Drawing.Size(226, 41);
            this.butTransactions.TabIndex = 5;
            this.butTransactions.Text = "   Transactions";
            this.butTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTransactions.Textcolor = System.Drawing.Color.White;
            this.butTransactions.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTransactions.Click += new System.EventHandler(this.butTransactions_Click);
            // 
            // butMasterEntries
            // 
            this.butMasterEntries.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butMasterEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMasterEntries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMasterEntries.BorderRadius = 0;
            this.butMasterEntries.ButtonText = "   Master Entries";
            this.butMasterEntries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMasterEntries.DisabledColor = System.Drawing.Color.Gray;
            this.butMasterEntries.Iconcolor = System.Drawing.Color.Transparent;
            this.butMasterEntries.Iconimage = global::Standard_Books.Properties.Resources.MasterEntries;
            this.butMasterEntries.Iconimage_right = null;
            this.butMasterEntries.Iconimage_right_Selected = null;
            this.butMasterEntries.Iconimage_Selected = null;
            this.butMasterEntries.IconMarginLeft = 0;
            this.butMasterEntries.IconMarginRight = 0;
            this.butMasterEntries.IconRightVisible = true;
            this.butMasterEntries.IconRightZoom = 0D;
            this.butMasterEntries.IconVisible = true;
            this.butMasterEntries.IconZoom = 60D;
            this.butMasterEntries.IsTab = true;
            this.butMasterEntries.Location = new System.Drawing.Point(0, 118);
            this.butMasterEntries.Name = "butMasterEntries";
            this.butMasterEntries.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMasterEntries.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butMasterEntries.OnHoverTextColor = System.Drawing.Color.White;
            this.butMasterEntries.selected = false;
            this.butMasterEntries.Size = new System.Drawing.Size(226, 41);
            this.butMasterEntries.TabIndex = 3;
            this.butMasterEntries.Text = "   Master Entries";
            this.butMasterEntries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMasterEntries.Textcolor = System.Drawing.Color.White;
            this.butMasterEntries.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMasterEntries.Click += new System.EventHandler(this.butMasterEntries_Click);
            // 
            // panelMenuHead
            // 
            this.panelMenuHead.Controls.Add(this.butScroll);
            this.panelMenuHead.Controls.Add(this.pictureBox1);
            this.panelMenuHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHead.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHead.Name = "panelMenuHead";
            this.panelMenuHead.Size = new System.Drawing.Size(226, 118);
            this.panelMenuHead.TabIndex = 0;
            this.panelMenuHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseDown);
            this.panelMenuHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseMove);
            this.panelMenuHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseUp);
            // 
            // butScroll
            // 
            this.butScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butScroll.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butScroll.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butScroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butScroll.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.butScroll.ForeColor = System.Drawing.Color.White;
            this.butScroll.Image = global::Standard_Books.Properties.Resources.Mobile_Menu_Icon;
            this.butScroll.ImagePosition = 9;
            this.butScroll.ImageZoom = 60;
            this.butScroll.LabelPosition = 0;
            this.butScroll.LabelText = "";
            this.butScroll.Location = new System.Drawing.Point(180, 0);
            this.butScroll.Margin = new System.Windows.Forms.Padding(6);
            this.butScroll.Name = "butScroll";
            this.butScroll.Size = new System.Drawing.Size(46, 44);
            this.butScroll.TabIndex = 8;
            this.butScroll.Click += new System.EventHandler(this.butScroll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Standard_Books.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelColorLine
            // 
            this.panelColorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.panelColorLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelColorLine.Location = new System.Drawing.Point(226, 0);
            this.panelColorLine.Name = "panelColorLine";
            this.panelColorLine.Size = new System.Drawing.Size(885, 5);
            this.panelColorLine.TabIndex = 1;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.backbutton);
            this.panelControls.Controls.Add(this.labelHeading);
            this.panelControls.Controls.Add(this.butMinimize);
            this.panelControls.Controls.Add(this.pbxMaximize);
            this.panelControls.Controls.Add(this.butClose);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(226, 5);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(885, 39);
            this.panelControls.TabIndex = 2;
            this.panelControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseDown);
            this.panelControls.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseMove);
            this.panelControls.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseUp);
            // 
            // backbutton
            // 
            this.backbutton.Image = global::Standard_Books.Properties.Resources.back_hover;
            this.backbutton.Location = new System.Drawing.Point(0, 0);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(47, 39);
            this.backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backbutton.TabIndex = 12;
            this.backbutton.TabStop = false;
            this.backbutton.Visible = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            this.backbutton.MouseLeave += new System.EventHandler(this.backbutton_MouseLeave);
            this.backbutton.MouseHover += new System.EventHandler(this.backbutton_MouseHover);
            // 
            // labelHeading
            // 
            this.labelHeading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.labelHeading.Location = new System.Drawing.Point(53, 7);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(162, 23);
            this.labelHeading.TabIndex = 11;
            this.labelHeading.Text = "Standard Books";
            // 
            // butMinimize
            // 
            this.butMinimize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butMinimize.BackColor = System.Drawing.Color.White;
            this.butMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMinimize.BorderRadius = 0;
            this.butMinimize.ButtonText = "-";
            this.butMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.butMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.butMinimize.Iconimage = null;
            this.butMinimize.Iconimage_right = null;
            this.butMinimize.Iconimage_right_Selected = null;
            this.butMinimize.Iconimage_Selected = null;
            this.butMinimize.IconMarginLeft = 0;
            this.butMinimize.IconMarginRight = 0;
            this.butMinimize.IconRightVisible = true;
            this.butMinimize.IconRightZoom = 0D;
            this.butMinimize.IconVisible = true;
            this.butMinimize.IconZoom = 90D;
            this.butMinimize.IsTab = false;
            this.butMinimize.Location = new System.Drawing.Point(746, 0);
            this.butMinimize.Name = "butMinimize";
            this.butMinimize.Normalcolor = System.Drawing.Color.White;
            this.butMinimize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.butMinimize.selected = false;
            this.butMinimize.Size = new System.Drawing.Size(47, 39);
            this.butMinimize.TabIndex = 10;
            this.butMinimize.Text = "-";
            this.butMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butMinimize.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMinimize.TextFont = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMinimize.Click += new System.EventHandler(this.butMinimize_Click);
            // 
            // pbxMaximize
            // 
            this.pbxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximize.Image = global::Standard_Books.Properties.Resources.Icono_Maximizar;
            this.pbxMaximize.Location = new System.Drawing.Point(793, 0);
            this.pbxMaximize.Name = "pbxMaximize";
            this.pbxMaximize.Size = new System.Drawing.Size(47, 39);
            this.pbxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMaximize.TabIndex = 9;
            this.pbxMaximize.TabStop = false;
            this.pbxMaximize.Click += new System.EventHandler(this.pbxMaximize_Click);
            this.pbxMaximize.MouseLeave += new System.EventHandler(this.pbxMaximize_MouseLeave);
            this.pbxMaximize.MouseHover += new System.EventHandler(this.pbxMaximize_MouseHover);
            // 
            // butClose
            // 
            this.butClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butClose.BackColor = System.Drawing.Color.White;
            this.butClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClose.BorderRadius = 0;
            this.butClose.ButtonText = "X";
            this.butClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClose.DisabledColor = System.Drawing.Color.Gray;
            this.butClose.Iconcolor = System.Drawing.Color.Transparent;
            this.butClose.Iconimage = null;
            this.butClose.Iconimage_right = null;
            this.butClose.Iconimage_right_Selected = null;
            this.butClose.Iconimage_Selected = null;
            this.butClose.IconMarginLeft = 0;
            this.butClose.IconMarginRight = 0;
            this.butClose.IconRightVisible = true;
            this.butClose.IconRightZoom = 0D;
            this.butClose.IconVisible = true;
            this.butClose.IconZoom = 90D;
            this.butClose.IsTab = false;
            this.butClose.Location = new System.Drawing.Point(839, 0);
            this.butClose.Name = "butClose";
            this.butClose.Normalcolor = System.Drawing.Color.White;
            this.butClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butClose.OnHoverTextColor = System.Drawing.Color.White;
            this.butClose.selected = false;
            this.butClose.Size = new System.Drawing.Size(47, 39);
            this.butClose.TabIndex = 5;
            this.butClose.Text = "X";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butClose.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butClose.TextFont = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(226, 44);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 512);
            this.panelBody.TabIndex = 3;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 556);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelColorLine);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Books";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMenuHead;
        private ns1.BunifuFlatButton butReports;
        private ns1.BunifuFlatButton butTransactions;
        private ns1.BunifuFlatButton butMasterEntries;
        private ns1.BunifuTileButton butScroll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelColorLine;
        private System.Windows.Forms.Panel panelControls;
        private ns1.BunifuFlatButton butClose;
        private ns1.BunifuFlatButton butMinimize;
        private System.Windows.Forms.PictureBox pbxMaximize;
        private System.Windows.Forms.Panel panelBody;
        private ns1.BunifuFlatButton butLogout;
        private ns1.BunifuFlatButton butSettings;
        private ns1.BunifuFlatButton butLists;
        private System.Windows.Forms.PictureBox backbutton;
        private System.Windows.Forms.Label labelHeading;
    }
}
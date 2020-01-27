namespace Standard_Books
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxPassword = new ns1.BunifuMaterialTextbox();
            this.tbxUserName = new ns1.BunifuMaterialTextbox();
            this.butLogin = new ns1.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.butClose = new ns1.BunifuFlatButton();
            this.butMinimize = new ns1.BunifuFlatButton();
            this.chbxRM = new ns1.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxWebster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 5);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Standard_Books.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(86, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.tbxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbxPassword.HintText = "";
            this.tbxPassword.isPassword = false;
            this.tbxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.tbxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.tbxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.tbxPassword.LineThickness = 4;
            this.tbxPassword.Location = new System.Drawing.Point(74, 287);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(264, 54);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPassword.OnValueChanged += new System.EventHandler(this.tbxPassword_OnValueChanged);
            this.tbxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxUserName_KeyUp);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUserName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tbxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.tbxUserName.HintForeColor = System.Drawing.Color.Empty;
            this.tbxUserName.HintText = "";
            this.tbxUserName.isPassword = false;
            this.tbxUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.tbxUserName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.tbxUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.tbxUserName.LineThickness = 4;
            this.tbxUserName.Location = new System.Drawing.Point(74, 224);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(264, 44);
            this.tbxUserName.TabIndex = 0;
            this.tbxUserName.Text = "User Name";
            this.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxUserName_KeyUp);
            // 
            // butLogin
            // 
            this.butLogin.ActiveBorderThickness = 1;
            this.butLogin.ActiveCornerRadius = 20;
            this.butLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butLogin.ActiveForecolor = System.Drawing.Color.White;
            this.butLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butLogin.BackColor = System.Drawing.Color.White;
            this.butLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLogin.BackgroundImage")));
            this.butLogin.ButtonText = "Login";
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.IdleBorderThickness = 1;
            this.butLogin.IdleCornerRadius = 20;
            this.butLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butLogin.IdleForecolor = System.Drawing.Color.White;
            this.butLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butLogin.Location = new System.Drawing.Point(57, 400);
            this.butLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(298, 50);
            this.butLogin.TabIndex = 3;
            this.butLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Standard_Books.Properties.Resources.account_1;
            this.pictureBox2.Location = new System.Drawing.Point(33, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Standard_Books.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(20, 306);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
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
            this.butClose.Location = new System.Drawing.Point(369, 5);
            this.butClose.Name = "butClose";
            this.butClose.Normalcolor = System.Drawing.Color.White;
            this.butClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butClose.OnHoverTextColor = System.Drawing.Color.White;
            this.butClose.selected = false;
            this.butClose.Size = new System.Drawing.Size(47, 39);
            this.butClose.TabIndex = 14;
            this.butClose.Text = "X";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butClose.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butClose.TextFont = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
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
            this.butMinimize.Location = new System.Drawing.Point(321, 5);
            this.butMinimize.Name = "butMinimize";
            this.butMinimize.Normalcolor = System.Drawing.Color.White;
            this.butMinimize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.butMinimize.selected = false;
            this.butMinimize.Size = new System.Drawing.Size(47, 39);
            this.butMinimize.TabIndex = 15;
            this.butMinimize.Text = "-";
            this.butMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butMinimize.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMinimize.TextFont = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMinimize.Click += new System.EventHandler(this.butMinimize_Click);
            // 
            // chbxRM
            // 
            this.chbxRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxRM.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxRM.Checked = false;
            this.chbxRM.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxRM.ForeColor = System.Drawing.Color.White;
            this.chbxRM.Location = new System.Drawing.Point(74, 362);
            this.chbxRM.Name = "chbxRM";
            this.chbxRM.Size = new System.Drawing.Size(20, 20);
            this.chbxRM.TabIndex = 17;
            this.chbxRM.OnChange += new System.EventHandler(this.chbxRM_OnChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Remember me";
            // 
            // pbxWebster
            // 
            this.pbxWebster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxWebster.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxWebster.Image = global::Standard_Books.Properties.Resources.webster_title;
            this.pbxWebster.Location = new System.Drawing.Point(143, 447);
            this.pbxWebster.Name = "pbxWebster";
            this.pbxWebster.Size = new System.Drawing.Size(126, 39);
            this.pbxWebster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxWebster.TabIndex = 18;
            this.pbxWebster.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 487);
            this.Controls.Add(this.pbxWebster);
            this.Controls.Add(this.chbxRM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butMinimize);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Books";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuMaterialTextbox tbxPassword;
        private ns1.BunifuMaterialTextbox tbxUserName;
        private ns1.BunifuThinButton2 butLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuFlatButton butClose;
        private ns1.BunifuFlatButton butMinimize;
        private ns1.BunifuCheckbox chbxRM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxWebster;
    }
}
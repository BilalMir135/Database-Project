namespace Standard_Books.Custom_Controls
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.butPasswordSave = new ns1.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxCurrentPassword = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.butUserSave = new ns1.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNewUserName = new System.Windows.Forms.TextBox();
            this.tbxCurrentUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelUser, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.butPasswordSave);
            this.panelPassword.Controls.Add(this.label6);
            this.panelPassword.Controls.Add(this.label5);
            this.panelPassword.Controls.Add(this.label2);
            this.panelPassword.Controls.Add(this.tbxNewPassword);
            this.panelPassword.Controls.Add(this.tbxCurrentPassword);
            this.panelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPassword.Location = new System.Drawing.Point(3, 259);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(879, 250);
            this.panelPassword.TabIndex = 1;
            // 
            // butPasswordSave
            // 
            this.butPasswordSave.ActiveBorderThickness = 1;
            this.butPasswordSave.ActiveCornerRadius = 20;
            this.butPasswordSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPasswordSave.ActiveForecolor = System.Drawing.Color.White;
            this.butPasswordSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPasswordSave.BackColor = System.Drawing.Color.White;
            this.butPasswordSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butPasswordSave.BackgroundImage")));
            this.butPasswordSave.ButtonText = "Save";
            this.butPasswordSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPasswordSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPasswordSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPasswordSave.IdleBorderThickness = 1;
            this.butPasswordSave.IdleCornerRadius = 20;
            this.butPasswordSave.IdleFillColor = System.Drawing.Color.White;
            this.butPasswordSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPasswordSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPasswordSave.Location = new System.Drawing.Point(546, 164);
            this.butPasswordSave.Margin = new System.Windows.Forms.Padding(5);
            this.butPasswordSave.Name = "butPasswordSave";
            this.butPasswordSave.Size = new System.Drawing.Size(159, 56);
            this.butPasswordSave.TabIndex = 21;
            this.butPasswordSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butPasswordSave.Click += new System.EventHandler(this.butPasswordSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(36, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Change Password";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPassword.Location = new System.Drawing.Point(314, 129);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(191, 23);
            this.tbxNewPassword.TabIndex = 3;
            this.tbxNewPassword.Tag = "";
            this.tbxNewPassword.UseSystemPasswordChar = true;
            // 
            // tbxCurrentPassword
            // 
            this.tbxCurrentPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrentPassword.Location = new System.Drawing.Point(314, 84);
            this.tbxCurrentPassword.Name = "tbxCurrentPassword";
            this.tbxCurrentPassword.Size = new System.Drawing.Size(191, 23);
            this.tbxCurrentPassword.TabIndex = 2;
            this.tbxCurrentPassword.Tag = "";
            this.tbxCurrentPassword.UseSystemPasswordChar = true;
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.butUserSave);
            this.panelUser.Controls.Add(this.label3);
            this.panelUser.Controls.Add(this.label4);
            this.panelUser.Controls.Add(this.tbxNewUserName);
            this.panelUser.Controls.Add(this.tbxCurrentUserName);
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.Location = new System.Drawing.Point(3, 3);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(879, 250);
            this.panelUser.TabIndex = 0;
            // 
            // butUserSave
            // 
            this.butUserSave.ActiveBorderThickness = 1;
            this.butUserSave.ActiveCornerRadius = 20;
            this.butUserSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butUserSave.ActiveForecolor = System.Drawing.Color.White;
            this.butUserSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butUserSave.BackColor = System.Drawing.Color.White;
            this.butUserSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butUserSave.BackgroundImage")));
            this.butUserSave.ButtonText = "Save";
            this.butUserSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butUserSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUserSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butUserSave.IdleBorderThickness = 1;
            this.butUserSave.IdleCornerRadius = 20;
            this.butUserSave.IdleFillColor = System.Drawing.Color.White;
            this.butUserSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butUserSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butUserSave.Location = new System.Drawing.Point(546, 172);
            this.butUserSave.Margin = new System.Windows.Forms.Padding(5);
            this.butUserSave.Name = "butUserSave";
            this.butUserSave.Size = new System.Drawing.Size(159, 56);
            this.butUserSave.TabIndex = 21;
            this.butUserSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butUserSave.Click += new System.EventHandler(this.butUserSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "New Userame:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Current Username:";
            // 
            // tbxNewUserName
            // 
            this.tbxNewUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewUserName.Location = new System.Drawing.Point(314, 122);
            this.tbxNewUserName.Name = "tbxNewUserName";
            this.tbxNewUserName.Size = new System.Drawing.Size(191, 23);
            this.tbxNewUserName.TabIndex = 1;
            this.tbxNewUserName.Tag = "";
            // 
            // tbxCurrentUserName
            // 
            this.tbxCurrentUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrentUserName.Location = new System.Drawing.Point(314, 77);
            this.tbxCurrentUserName.Name = "tbxCurrentUserName";
            this.tbxCurrentUserName.Size = new System.Drawing.Size(191, 23);
            this.tbxCurrentUserName.TabIndex = 0;
            this.tbxCurrentUserName.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Change Username";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelUser;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxCurrentPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNewUserName;
        private System.Windows.Forms.TextBox tbxCurrentUserName;
        private ns1.BunifuThinButton2 butPasswordSave;
        private ns1.BunifuThinButton2 butUserSave;
    }
}

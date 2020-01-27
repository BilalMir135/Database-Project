namespace Standard_Books
{
    partial class Report_ParameterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_ParameterForm));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.butClose = new ns1.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.butPreview = new ns1.BunifuFlatButton();
            this.labelContent = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.butClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(534, 28);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Standard_Books.Properties.Resources.book_title_bar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(51, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 18);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Text Here";
            // 
            // butClose
            // 
            this.butClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
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
            this.butClose.Location = new System.Drawing.Point(496, -4);
            this.butClose.Name = "butClose";
            this.butClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butClose.OnHoverTextColor = System.Drawing.Color.White;
            this.butClose.selected = false;
            this.butClose.Size = new System.Drawing.Size(43, 37);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "X";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butClose.Textcolor = System.Drawing.Color.White;
            this.butClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(529, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 150);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 150);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 5);
            this.panel4.TabIndex = 10;
            // 
            // tbxValue
            // 
            this.tbxValue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValue.Location = new System.Drawing.Point(18, 90);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(369, 23);
            this.tbxValue.TabIndex = 12;
            // 
            // butPreview
            // 
            this.butPreview.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butPreview.BorderRadius = 0;
            this.butPreview.ButtonText = "Preview";
            this.butPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPreview.DisabledColor = System.Drawing.Color.Gray;
            this.butPreview.Iconcolor = System.Drawing.Color.Transparent;
            this.butPreview.Iconimage = null;
            this.butPreview.Iconimage_right = null;
            this.butPreview.Iconimage_right_Selected = null;
            this.butPreview.Iconimage_Selected = null;
            this.butPreview.IconMarginLeft = 0;
            this.butPreview.IconMarginRight = 0;
            this.butPreview.IconRightVisible = true;
            this.butPreview.IconRightZoom = 0D;
            this.butPreview.IconVisible = true;
            this.butPreview.IconZoom = 90D;
            this.butPreview.IsTab = false;
            this.butPreview.Location = new System.Drawing.Point(414, 125);
            this.butPreview.Name = "butPreview";
            this.butPreview.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPreview.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butPreview.OnHoverTextColor = System.Drawing.Color.White;
            this.butPreview.selected = false;
            this.butPreview.Size = new System.Drawing.Size(108, 41);
            this.butPreview.TabIndex = 21;
            this.butPreview.Text = "Preview";
            this.butPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butPreview.Textcolor = System.Drawing.Color.White;
            this.butPreview.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPreview.Click += new System.EventHandler(this.butPreview_Click);
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(21, 53);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(171, 21);
            this.labelContent.TabIndex = 22;
            this.labelContent.Text = "Enter some text here";
            // 
            // Report_ParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 178);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.butPreview);
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_ParameterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Books";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private ns1.BunifuFlatButton butClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbxValue;
        private ns1.BunifuFlatButton butPreview;
        private System.Windows.Forms.Label labelContent;
    }
}
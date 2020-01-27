namespace Standard_Books.Custom_Controls
{
    partial class BooksReporting
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.tbxPubYear = new System.Windows.Forms.TextBox();
            this.tbxPartialSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAuthor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPubYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butPreview = new ns1.BunifuFlatButton();
            this.chbxCR0 = new ns1.BunifuCheckbox();
            this.chbxCR = new ns1.BunifuCheckbox();
            this.chbxDeleteYear = new ns1.BunifuCheckbox();
            this.chbxDeletePublisher = new ns1.BunifuCheckbox();
            this.chbxSubject = new ns1.BunifuCheckbox();
            this.chbxAuthor = new ns1.BunifuCheckbox();
            this.label9 = new System.Windows.Forms.Label();
            this.chbxPublisher = new ns1.BunifuCheckbox();
            this.label8 = new System.Windows.Forms.Label();
            this.chbxPartialSearch = new ns1.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbxzerostock = new ns1.BunifuCheckbox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelControls);
            this.panelBody.Controls.Add(this.butPreview);
            this.panelBody.Controls.Add(this.chbxCR0);
            this.panelBody.Controls.Add(this.chbxCR);
            this.panelBody.Controls.Add(this.chbxDeleteYear);
            this.panelBody.Controls.Add(this.chbxDeletePublisher);
            this.panelBody.Controls.Add(this.chbxzerostock);
            this.panelBody.Controls.Add(this.chbxSubject);
            this.panelBody.Controls.Add(this.chbxAuthor);
            this.panelBody.Controls.Add(this.label9);
            this.panelBody.Controls.Add(this.chbxPublisher);
            this.panelBody.Controls.Add(this.label8);
            this.panelBody.Controls.Add(this.chbxPartialSearch);
            this.panelBody.Controls.Add(this.label10);
            this.panelBody.Controls.Add(this.label6);
            this.panelBody.Controls.Add(this.label5);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 512);
            this.panelBody.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.tbxPubYear);
            this.panelControls.Controls.Add(this.tbxPartialSearch);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.cbxPublisher);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.cbxAuthor);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.cbxPubYear);
            this.panelControls.Controls.Add(this.label7);
            this.panelControls.Controls.Add(this.cbxSubject);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Location = new System.Drawing.Point(227, 26);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(365, 273);
            this.panelControls.TabIndex = 19;
            // 
            // tbxPubYear
            // 
            this.tbxPubYear.Enabled = false;
            this.tbxPubYear.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPubYear.Location = new System.Drawing.Point(191, 95);
            this.tbxPubYear.Name = "tbxPubYear";
            this.tbxPubYear.Size = new System.Drawing.Size(166, 25);
            this.tbxPubYear.TabIndex = 14;
            this.tbxPubYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPubYear_KeyPress);
            // 
            // tbxPartialSearch
            // 
            this.tbxPartialSearch.Enabled = false;
            this.tbxPartialSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPartialSearch.Location = new System.Drawing.Point(136, 224);
            this.tbxPartialSearch.MaxLength = 50;
            this.tbxPartialSearch.Name = "tbxPartialSearch";
            this.tbxPartialSearch.Size = new System.Drawing.Size(222, 23);
            this.tbxPartialSearch.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Partial Search:";
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPublisher.Enabled = false;
            this.cbxPublisher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(136, 178);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(222, 25);
            this.cbxPublisher.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Publisher:";
            // 
            // cbxAuthor
            // 
            this.cbxAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAuthor.Enabled = false;
            this.cbxAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAuthor.FormattingEnabled = true;
            this.cbxAuthor.Location = new System.Drawing.Point(136, 136);
            this.cbxAuthor.Name = "cbxAuthor";
            this.cbxAuthor.Size = new System.Drawing.Size(222, 25);
            this.cbxAuthor.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Author:";
            // 
            // cbxPubYear
            // 
            this.cbxPubYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPubYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPubYear.Enabled = false;
            this.cbxPubYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPubYear.FormattingEnabled = true;
            this.cbxPubYear.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cbxPubYear.Location = new System.Drawing.Point(136, 95);
            this.cbxPubYear.Name = "cbxPubYear";
            this.cbxPubYear.Size = new System.Drawing.Size(49, 25);
            this.cbxPubYear.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Publishing Year:";
            // 
            // cbxSubject
            // 
            this.cbxSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSubject.Enabled = false;
            this.cbxSubject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(136, 56);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(222, 25);
            this.cbxSubject.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject:";
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
            this.butPreview.Location = new System.Drawing.Point(519, 305);
            this.butPreview.Name = "butPreview";
            this.butPreview.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPreview.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butPreview.OnHoverTextColor = System.Drawing.Color.White;
            this.butPreview.selected = false;
            this.butPreview.Size = new System.Drawing.Size(108, 41);
            this.butPreview.TabIndex = 16;
            this.butPreview.Text = "Preview";
            this.butPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butPreview.Textcolor = System.Drawing.Color.White;
            this.butPreview.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPreview.Click += new System.EventHandler(this.butPreview_Click);
            // 
            // chbxCR0
            // 
            this.chbxCR0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxCR0.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxCR0.Checked = false;
            this.chbxCR0.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxCR0.ForeColor = System.Drawing.Color.White;
            this.chbxCR0.Location = new System.Drawing.Point(262, 437);
            this.chbxCR0.Name = "chbxCR0";
            this.chbxCR0.Size = new System.Drawing.Size(20, 20);
            this.chbxCR0.TabIndex = 15;
            this.chbxCR0.OnChange += new System.EventHandler(this.chbxCR0_OnChange);
            // 
            // chbxCR
            // 
            this.chbxCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxCR.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxCR.Checked = false;
            this.chbxCR.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxCR.ForeColor = System.Drawing.Color.White;
            this.chbxCR.Location = new System.Drawing.Point(262, 400);
            this.chbxCR.Name = "chbxCR";
            this.chbxCR.Size = new System.Drawing.Size(20, 20);
            this.chbxCR.TabIndex = 15;
            this.chbxCR.OnChange += new System.EventHandler(this.chbxCR_OnChange);
            // 
            // chbxDeleteYear
            // 
            this.chbxDeleteYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeleteYear.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeleteYear.Checked = false;
            this.chbxDeleteYear.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxDeleteYear.ForeColor = System.Drawing.Color.White;
            this.chbxDeleteYear.Location = new System.Drawing.Point(262, 363);
            this.chbxDeleteYear.Name = "chbxDeleteYear";
            this.chbxDeleteYear.Size = new System.Drawing.Size(20, 20);
            this.chbxDeleteYear.TabIndex = 15;
            // 
            // chbxDeletePublisher
            // 
            this.chbxDeletePublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeletePublisher.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeletePublisher.Checked = false;
            this.chbxDeletePublisher.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxDeletePublisher.ForeColor = System.Drawing.Color.White;
            this.chbxDeletePublisher.Location = new System.Drawing.Point(262, 326);
            this.chbxDeletePublisher.Name = "chbxDeletePublisher";
            this.chbxDeletePublisher.Size = new System.Drawing.Size(20, 20);
            this.chbxDeletePublisher.TabIndex = 15;
            // 
            // chbxSubject
            // 
            this.chbxSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxSubject.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxSubject.Checked = false;
            this.chbxSubject.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxSubject.ForeColor = System.Drawing.Color.White;
            this.chbxSubject.Location = new System.Drawing.Point(607, 85);
            this.chbxSubject.Name = "chbxSubject";
            this.chbxSubject.Size = new System.Drawing.Size(20, 20);
            this.chbxSubject.TabIndex = 15;
            this.chbxSubject.OnChange += new System.EventHandler(this.chbxSubject_OnChange);
            // 
            // chbxAuthor
            // 
            this.chbxAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxAuthor.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxAuthor.Checked = false;
            this.chbxAuthor.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxAuthor.ForeColor = System.Drawing.Color.White;
            this.chbxAuthor.Location = new System.Drawing.Point(607, 166);
            this.chbxAuthor.Name = "chbxAuthor";
            this.chbxAuthor.Size = new System.Drawing.Size(20, 20);
            this.chbxAuthor.TabIndex = 15;
            this.chbxAuthor.OnChange += new System.EventHandler(this.chbxAuthor_OnChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Complete Record With Zero Stock Quantity";
            // 
            // chbxPublisher
            // 
            this.chbxPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxPublisher.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxPublisher.Checked = false;
            this.chbxPublisher.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxPublisher.ForeColor = System.Drawing.Color.White;
            this.chbxPublisher.Location = new System.Drawing.Point(607, 208);
            this.chbxPublisher.Name = "chbxPublisher";
            this.chbxPublisher.Size = new System.Drawing.Size(20, 20);
            this.chbxPublisher.TabIndex = 15;
            this.chbxPublisher.OnChange += new System.EventHandler(this.chbxPublisher_OnChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Complete Record";
            // 
            // chbxPartialSearch
            // 
            this.chbxPartialSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxPartialSearch.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxPartialSearch.Checked = false;
            this.chbxPartialSearch.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxPartialSearch.ForeColor = System.Drawing.Color.White;
            this.chbxPartialSearch.Location = new System.Drawing.Point(607, 254);
            this.chbxPartialSearch.Name = "chbxPartialSearch";
            this.chbxPartialSearch.Size = new System.Drawing.Size(20, 20);
            this.chbxPartialSearch.TabIndex = 15;
            this.chbxPartialSearch.OnChange += new System.EventHandler(this.chbxPartialSearch_OnChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Delete Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Delete Publisher";
            // 
            // chbxzerostock
            // 
            this.chbxzerostock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxzerostock.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxzerostock.Checked = false;
            this.chbxzerostock.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxzerostock.Enabled = false;
            this.chbxzerostock.ForeColor = System.Drawing.Color.White;
            this.chbxzerostock.Location = new System.Drawing.Point(607, 125);
            this.chbxzerostock.Name = "chbxzerostock";
            this.chbxzerostock.Size = new System.Drawing.Size(20, 20);
            this.chbxzerostock.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(633, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Zero Stock";
            // 
            // BooksReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "BooksReporting";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.BooksReporting_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private ns1.BunifuCheckbox chbxDeleteYear;
        private ns1.BunifuCheckbox chbxDeletePublisher;
        private ns1.BunifuCheckbox chbxSubject;
        private ns1.BunifuCheckbox chbxAuthor;
        private ns1.BunifuCheckbox chbxPublisher;
        private ns1.BunifuCheckbox chbxPartialSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuFlatButton butPreview;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.TextBox tbxPartialSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuCheckbox chbxCR;
        private System.Windows.Forms.Label label8;
        private ns1.BunifuCheckbox chbxCR0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxPubYear;
        private System.Windows.Forms.ComboBox cbxPubYear;
        private System.Windows.Forms.Label label7;
        private ns1.BunifuCheckbox chbxzerostock;
        private System.Windows.Forms.Label label10;
    }
}

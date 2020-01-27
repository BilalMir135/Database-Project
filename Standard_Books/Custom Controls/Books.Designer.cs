namespace Standard_Books.Custom_Controls
{
    partial class Books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.SubIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGV = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cbxCurrency = new System.Windows.Forms.ComboBox();
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.cbxAuthor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxPublishingYear = new System.Windows.Forms.TextBox();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelsearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.butCancel = new ns1.BunifuFlatButton();
            this.butPreview = new ns1.BunifuFlatButton();
            this.butDetails = new ns1.BunifuFlatButton();
            this.butSave = new ns1.BunifuFlatButton();
            this.butDelete = new ns1.BunifuFlatButton();
            this.butEdit = new ns1.BunifuFlatButton();
            this.butAdd = new ns1.BunifuFlatButton();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PubYearGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBody.SuspendLayout();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.panelGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.panelControls);
            this.panelBody.Controls.Add(this.panelButtons);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 512);
            this.panelBody.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.dgvSubjects);
            this.panelControls.Controls.Add(this.panelGV);
            this.panelControls.Controls.Add(this.cbxCurrency);
            this.panelControls.Controls.Add(this.cbxPublisher);
            this.panelControls.Controls.Add(this.cbxSubject);
            this.panelControls.Controls.Add(this.cbxAuthor);
            this.panelControls.Controls.Add(this.label5);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.label11);
            this.panelControls.Controls.Add(this.label10);
            this.panelControls.Controls.Add(this.label9);
            this.panelControls.Controls.Add(this.label8);
            this.panelControls.Controls.Add(this.label7);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.label6);
            this.panelControls.Controls.Add(this.tbxTitle);
            this.panelControls.Controls.Add(this.tbxQuantity);
            this.panelControls.Controls.Add(this.tbxPrice);
            this.panelControls.Controls.Add(this.tbxPublishingYear);
            this.panelControls.Controls.Add(this.tbxISBN);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(885, 392);
            this.panelControls.TabIndex = 2;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjects.ColumnHeadersHeight = 25;
            this.dgvSubjects.ColumnHeadersVisible = false;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubIDGV,
            this.SubjectNameGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubjects.EnableHeadersVisualStyles = false;
            this.dgvSubjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvSubjects.Location = new System.Drawing.Point(586, 128);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(296, 261);
            this.dgvSubjects.TabIndex = 12;
            // 
            // SubIDGV
            // 
            this.SubIDGV.HeaderText = "SubjectID";
            this.SubIDGV.Name = "SubIDGV";
            this.SubIDGV.ReadOnly = true;
            this.SubIDGV.Visible = false;
            // 
            // SubjectNameGV
            // 
            this.SubjectNameGV.HeaderText = "Subject Name";
            this.SubjectNameGV.Name = "SubjectNameGV";
            this.SubjectNameGV.ReadOnly = true;
            // 
            // panelGV
            // 
            this.panelGV.Controls.Add(this.dgvBooks);
            this.panelGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGV.Location = new System.Drawing.Point(0, 0);
            this.panelGV.Name = "panelGV";
            this.panelGV.Size = new System.Drawing.Size(885, 392);
            this.panelGV.TabIndex = 11;
            this.panelGV.Visible = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooks.ColumnHeadersHeight = 25;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOGV,
            this.ISBNGV,
            this.TitleGV,
            this.AuthorIDGV,
            this.AuthorGV,
            this.SubjectIDGV,
            this.SubjectGV,
            this.PublisherIDGV,
            this.PublisherGV,
            this.PubYearGV,
            this.CurrencyIDGV,
            this.CurrencyGV,
            this.PriceGV,
            this.QuantityGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(885, 392);
            this.dgvBooks.TabIndex = 10;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            this.dgvBooks.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBooks_RowPostPaint);
            // 
            // cbxCurrency
            // 
            this.cbxCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCurrency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCurrency.FormattingEnabled = true;
            this.cbxCurrency.Location = new System.Drawing.Point(222, 245);
            this.cbxCurrency.Name = "cbxCurrency";
            this.cbxCurrency.Size = new System.Drawing.Size(206, 25);
            this.cbxCurrency.TabIndex = 6;
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPublisher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(222, 185);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(206, 25);
            this.cbxPublisher.TabIndex = 4;
            // 
            // cbxSubject
            // 
            this.cbxSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSubject.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(222, 154);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(206, 25);
            this.cbxSubject.TabIndex = 3;
            // 
            // cbxAuthor
            // 
            this.cbxAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAuthor.FormattingEnabled = true;
            this.cbxAuthor.Location = new System.Drawing.Point(222, 123);
            this.cbxAuthor.Name = "cbxAuthor";
            this.cbxAuthor.Size = new System.Drawing.Size(279, 25);
            this.cbxAuthor.TabIndex = 2;
            this.cbxAuthor.SelectedIndexChanged += new System.EventHandler(this.cbxAuthor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Title:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Currency:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Publishing Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Publisher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subject:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitle.Location = new System.Drawing.Point(222, 94);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(558, 23);
            this.tbxTitle.TabIndex = 1;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(222, 305);
            this.tbxQuantity.MaxLength = 5;
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(67, 23);
            this.tbxQuantity.TabIndex = 8;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPublishingYear_KeyPress);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(222, 276);
            this.tbxPrice.MaxLength = 8;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(103, 23);
            this.tbxPrice.TabIndex = 7;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPublishingYear_KeyPress);
            // 
            // tbxPublishingYear
            // 
            this.tbxPublishingYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPublishingYear.Location = new System.Drawing.Point(222, 216);
            this.tbxPublishingYear.MaxLength = 6;
            this.tbxPublishingYear.Name = "tbxPublishingYear";
            this.tbxPublishingYear.Size = new System.Drawing.Size(67, 23);
            this.tbxPublishingYear.TabIndex = 5;
            this.tbxPublishingYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPublishingYear_KeyPress);
            // 
            // tbxISBN
            // 
            this.tbxISBN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxISBN.Location = new System.Drawing.Point(222, 65);
            this.tbxISBN.MaxLength = 50;
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(147, 23);
            this.tbxISBN.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.labelsearch);
            this.panelButtons.Controls.Add(this.tbxSearch);
            this.panelButtons.Controls.Add(this.butCancel);
            this.panelButtons.Controls.Add(this.butPreview);
            this.panelButtons.Controls.Add(this.butDetails);
            this.panelButtons.Controls.Add(this.butSave);
            this.panelButtons.Controls.Add(this.butDelete);
            this.panelButtons.Controls.Add(this.butEdit);
            this.panelButtons.Controls.Add(this.butAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 392);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(885, 120);
            this.panelButtons.TabIndex = 1;
            // 
            // labelsearch
            // 
            this.labelsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsearch.Location = new System.Drawing.Point(479, 22);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(55, 17);
            this.labelsearch.TabIndex = 11;
            this.labelsearch.Text = "Search:";
            this.labelsearch.Visible = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(543, 19);
            this.tbxSearch.MaxLength = 50;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxSearch.TabIndex = 12;
            this.tbxSearch.Visible = false;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // butCancel
            // 
            this.butCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butCancel.BorderRadius = 0;
            this.butCancel.ButtonText = "Cancel";
            this.butCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCancel.DisabledColor = System.Drawing.Color.Gray;
            this.butCancel.Enabled = false;
            this.butCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.butCancel.Iconimage = null;
            this.butCancel.Iconimage_right = null;
            this.butCancel.Iconimage_right_Selected = null;
            this.butCancel.Iconimage_Selected = null;
            this.butCancel.IconMarginLeft = 0;
            this.butCancel.IconMarginRight = 0;
            this.butCancel.IconRightVisible = true;
            this.butCancel.IconRightZoom = 0D;
            this.butCancel.IconVisible = true;
            this.butCancel.IconZoom = 90D;
            this.butCancel.IsTab = false;
            this.butCancel.Location = new System.Drawing.Point(260, 66);
            this.butCancel.Name = "butCancel";
            this.butCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.butCancel.selected = false;
            this.butCancel.Size = new System.Drawing.Size(108, 41);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Cancel";
            this.butCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butCancel.Textcolor = System.Drawing.Color.White;
            this.butCancel.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
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
            this.butPreview.Location = new System.Drawing.Point(374, 66);
            this.butPreview.Name = "butPreview";
            this.butPreview.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPreview.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butPreview.OnHoverTextColor = System.Drawing.Color.White;
            this.butPreview.selected = false;
            this.butPreview.Size = new System.Drawing.Size(108, 41);
            this.butPreview.TabIndex = 1;
            this.butPreview.Text = "Preview";
            this.butPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butPreview.Textcolor = System.Drawing.Color.White;
            this.butPreview.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPreview.Click += new System.EventHandler(this.butPreview_Click);
            // 
            // butDetails
            // 
            this.butDetails.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDetails.BorderRadius = 0;
            this.butDetails.ButtonText = "Details";
            this.butDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDetails.DisabledColor = System.Drawing.Color.Gray;
            this.butDetails.Iconcolor = System.Drawing.Color.Transparent;
            this.butDetails.Iconimage = null;
            this.butDetails.Iconimage_right = null;
            this.butDetails.Iconimage_right_Selected = null;
            this.butDetails.Iconimage_Selected = null;
            this.butDetails.IconMarginLeft = 0;
            this.butDetails.IconMarginRight = 0;
            this.butDetails.IconRightVisible = true;
            this.butDetails.IconRightZoom = 0D;
            this.butDetails.IconVisible = true;
            this.butDetails.IconZoom = 90D;
            this.butDetails.IsTab = false;
            this.butDetails.Location = new System.Drawing.Point(261, 19);
            this.butDetails.Name = "butDetails";
            this.butDetails.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butDetails.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.butDetails.selected = false;
            this.butDetails.Size = new System.Drawing.Size(108, 41);
            this.butDetails.TabIndex = 1;
            this.butDetails.Text = "Details";
            this.butDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butDetails.Textcolor = System.Drawing.Color.White;
            this.butDetails.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDetails.Click += new System.EventHandler(this.butDetails_Click);
            // 
            // butSave
            // 
            this.butSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSave.BorderRadius = 0;
            this.butSave.ButtonText = "Save";
            this.butSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSave.DisabledColor = System.Drawing.Color.Gray;
            this.butSave.Enabled = false;
            this.butSave.Iconcolor = System.Drawing.Color.Transparent;
            this.butSave.Iconimage = null;
            this.butSave.Iconimage_right = null;
            this.butSave.Iconimage_right_Selected = null;
            this.butSave.Iconimage_Selected = null;
            this.butSave.IconMarginLeft = 0;
            this.butSave.IconMarginRight = 0;
            this.butSave.IconRightVisible = true;
            this.butSave.IconRightZoom = 0D;
            this.butSave.IconVisible = true;
            this.butSave.IconZoom = 90D;
            this.butSave.IsTab = false;
            this.butSave.Location = new System.Drawing.Point(146, 66);
            this.butSave.Name = "butSave";
            this.butSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butSave.OnHoverTextColor = System.Drawing.Color.White;
            this.butSave.selected = false;
            this.butSave.Size = new System.Drawing.Size(108, 41);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "Save";
            this.butSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSave.Textcolor = System.Drawing.Color.White;
            this.butSave.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butDelete
            // 
            this.butDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDelete.BorderRadius = 0;
            this.butDelete.ButtonText = "Delete";
            this.butDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDelete.DisabledColor = System.Drawing.Color.Gray;
            this.butDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.butDelete.Iconimage = null;
            this.butDelete.Iconimage_right = null;
            this.butDelete.Iconimage_right_Selected = null;
            this.butDelete.Iconimage_Selected = null;
            this.butDelete.IconMarginLeft = 0;
            this.butDelete.IconMarginRight = 0;
            this.butDelete.IconRightVisible = true;
            this.butDelete.IconRightZoom = 0D;
            this.butDelete.IconVisible = true;
            this.butDelete.IconZoom = 90D;
            this.butDelete.IsTab = false;
            this.butDelete.Location = new System.Drawing.Point(146, 19);
            this.butDelete.Name = "butDelete";
            this.butDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.butDelete.selected = false;
            this.butDelete.Size = new System.Drawing.Size(108, 41);
            this.butDelete.TabIndex = 1;
            this.butDelete.Text = "Delete";
            this.butDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butDelete.Textcolor = System.Drawing.Color.White;
            this.butDelete.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEdit.BorderRadius = 0;
            this.butEdit.ButtonText = "Edit";
            this.butEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEdit.DisabledColor = System.Drawing.Color.Gray;
            this.butEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.butEdit.Iconimage = null;
            this.butEdit.Iconimage_right = null;
            this.butEdit.Iconimage_right_Selected = null;
            this.butEdit.Iconimage_Selected = null;
            this.butEdit.IconMarginLeft = 0;
            this.butEdit.IconMarginRight = 0;
            this.butEdit.IconRightVisible = true;
            this.butEdit.IconRightZoom = 0D;
            this.butEdit.IconVisible = true;
            this.butEdit.IconZoom = 90D;
            this.butEdit.IsTab = false;
            this.butEdit.Location = new System.Drawing.Point(32, 66);
            this.butEdit.Name = "butEdit";
            this.butEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.butEdit.selected = false;
            this.butEdit.Size = new System.Drawing.Size(108, 41);
            this.butEdit.TabIndex = 2;
            this.butEdit.Text = "Edit";
            this.butEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butEdit.Textcolor = System.Drawing.Color.White;
            this.butEdit.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAdd.BorderRadius = 0;
            this.butAdd.ButtonText = "Add";
            this.butAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAdd.DisabledColor = System.Drawing.Color.Gray;
            this.butAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.butAdd.Iconimage = null;
            this.butAdd.Iconimage_right = null;
            this.butAdd.Iconimage_right_Selected = null;
            this.butAdd.Iconimage_Selected = null;
            this.butAdd.IconMarginLeft = 0;
            this.butAdd.IconMarginRight = 0;
            this.butAdd.IconRightVisible = true;
            this.butAdd.IconRightZoom = 0D;
            this.butAdd.IconVisible = true;
            this.butAdd.IconZoom = 90D;
            this.butAdd.IsTab = false;
            this.butAdd.Location = new System.Drawing.Point(32, 19);
            this.butAdd.Name = "butAdd";
            this.butAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.butAdd.selected = false;
            this.butAdd.Size = new System.Drawing.Size(108, 41);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Add";
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butAdd.Textcolor = System.Drawing.Color.White;
            this.butAdd.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // SNOGV
            // 
            this.SNOGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            this.SNOGV.Width = 57;
            // 
            // ISBNGV
            // 
            this.ISBNGV.HeaderText = "ISBN";
            this.ISBNGV.Name = "ISBNGV";
            this.ISBNGV.ReadOnly = true;
            // 
            // TitleGV
            // 
            this.TitleGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TitleGV.HeaderText = "Title";
            this.TitleGV.Name = "TitleGV";
            this.TitleGV.ReadOnly = true;
            this.TitleGV.Width = 190;
            // 
            // AuthorIDGV
            // 
            this.AuthorIDGV.HeaderText = "AuthorID";
            this.AuthorIDGV.Name = "AuthorIDGV";
            this.AuthorIDGV.ReadOnly = true;
            this.AuthorIDGV.Visible = false;
            // 
            // AuthorGV
            // 
            this.AuthorGV.HeaderText = "Author";
            this.AuthorGV.Name = "AuthorGV";
            this.AuthorGV.ReadOnly = true;
            // 
            // SubjectIDGV
            // 
            this.SubjectIDGV.HeaderText = "SubjectID";
            this.SubjectIDGV.Name = "SubjectIDGV";
            this.SubjectIDGV.ReadOnly = true;
            this.SubjectIDGV.Visible = false;
            // 
            // SubjectGV
            // 
            this.SubjectGV.HeaderText = "Subject";
            this.SubjectGV.Name = "SubjectGV";
            this.SubjectGV.ReadOnly = true;
            // 
            // PublisherIDGV
            // 
            this.PublisherIDGV.HeaderText = "PublisherID";
            this.PublisherIDGV.Name = "PublisherIDGV";
            this.PublisherIDGV.ReadOnly = true;
            this.PublisherIDGV.Visible = false;
            // 
            // PublisherGV
            // 
            this.PublisherGV.HeaderText = "Publisher";
            this.PublisherGV.Name = "PublisherGV";
            this.PublisherGV.ReadOnly = true;
            // 
            // PubYearGV
            // 
            this.PubYearGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PubYearGV.HeaderText = "Year";
            this.PubYearGV.Name = "PubYearGV";
            this.PubYearGV.ReadOnly = true;
            this.PubYearGV.Width = 35;
            // 
            // CurrencyIDGV
            // 
            this.CurrencyIDGV.HeaderText = "CurrencyID";
            this.CurrencyIDGV.Name = "CurrencyIDGV";
            this.CurrencyIDGV.ReadOnly = true;
            this.CurrencyIDGV.Visible = false;
            // 
            // CurrencyGV
            // 
            this.CurrencyGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CurrencyGV.HeaderText = "Currency";
            this.CurrencyGV.Name = "CurrencyGV";
            this.CurrencyGV.ReadOnly = true;
            this.CurrencyGV.Width = 60;
            // 
            // PriceGV
            // 
            this.PriceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PriceGV.HeaderText = "Price";
            this.PriceGV.Name = "PriceGV";
            this.PriceGV.ReadOnly = true;
            this.PriceGV.Width = 70;
            // 
            // QuantityGV
            // 
            this.QuantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            this.QuantityGV.Width = 60;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.Books_Load);
            this.panelBody.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.panelGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelButtons;
        private ns1.BunifuFlatButton butCancel;
        private ns1.BunifuFlatButton butSave;
        private ns1.BunifuFlatButton butDelete;
        private ns1.BunifuFlatButton butEdit;
        private ns1.BunifuFlatButton butAdd;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.ComboBox cbxAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxPublishingYear;
        private System.Windows.Forms.TextBox tbxISBN;
        private ns1.BunifuFlatButton butDetails;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panelGV;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cbxCurrency;
        private ns1.BunifuFlatButton butPreview;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PubYearGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
    }
}

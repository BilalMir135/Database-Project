namespace Standard_Books.Custom_Controls
{
    partial class InvoiceRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInvoiceDetails = new System.Windows.Forms.Panel();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.SNOGV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInvoiceDetailButtons = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInvoiceDetailSearch = new System.Windows.Forms.TextBox();
            this.panelInvoice = new System.Windows.Forms.Panel();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.InvoiceIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChallanAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelInvoiceButtons = new System.Windows.Forms.Panel();
            this.chbxLetterHead = new ns1.BunifuCheckbox();
            this.label24 = new System.Windows.Forms.Label();
            this.butPreview = new ns1.BunifuFlatButton();
            this.chbxDeleteYear = new ns1.BunifuCheckbox();
            this.label25 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butCancelInvoice = new ns1.BunifuFlatButton();
            this.butDelete = new ns1.BunifuFlatButton();
            this.tbxInvoiceSearch = new System.Windows.Forms.TextBox();
            this.panelBody.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelInvoiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.panelInvoiceDetailButtons.SuspendLayout();
            this.panelInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.panelInvoiceButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.tableLayoutPanel1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 512);
            this.panelBody.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelInvoiceDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelInvoice, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 512);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelInvoiceDetails
            // 
            this.panelInvoiceDetails.Controls.Add(this.dgvInvoiceDetails);
            this.panelInvoiceDetails.Controls.Add(this.panelInvoiceDetailButtons);
            this.panelInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoiceDetails.Location = new System.Drawing.Point(3, 259);
            this.panelInvoiceDetails.Name = "panelInvoiceDetails";
            this.panelInvoiceDetails.Size = new System.Drawing.Size(879, 250);
            this.panelInvoiceDetails.TabIndex = 8;
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.AllowUserToAddRows = false;
            this.dgvInvoiceDetails.AllowUserToDeleteRows = false;
            this.dgvInvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoiceDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvInvoiceDetails.ColumnHeadersHeight = 25;
            this.dgvInvoiceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOGV1,
            this.ISBNGV,
            this.TitleGV,
            this.PriceGV,
            this.QuantityGV,
            this.AmountGV,
            this.DiscountGV,
            this.FinalAmountGV});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceDetails.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetails.EnableHeadersVisualStyles = false;
            this.dgvInvoiceDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.ReadOnly = true;
            this.dgvInvoiceDetails.RowHeadersVisible = false;
            this.dgvInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(879, 209);
            this.dgvInvoiceDetails.TabIndex = 14;
            this.dgvInvoiceDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvInvoiceDetails_RowPostPaint);
            // 
            // SNOGV1
            // 
            this.SNOGV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV1.HeaderText = "SNO";
            this.SNOGV1.Name = "SNOGV1";
            this.SNOGV1.ReadOnly = true;
            this.SNOGV1.Width = 57;
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
            this.TitleGV.Width = 200;
            // 
            // PriceGV
            // 
            this.PriceGV.HeaderText = "Price";
            this.PriceGV.Name = "PriceGV";
            this.PriceGV.ReadOnly = true;
            // 
            // QuantityGV
            // 
            this.QuantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            this.QuantityGV.Width = 81;
            // 
            // AmountGV
            // 
            this.AmountGV.HeaderText = "Amount";
            this.AmountGV.Name = "AmountGV";
            this.AmountGV.ReadOnly = true;
            // 
            // DiscountGV
            // 
            this.DiscountGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiscountGV.HeaderText = "Dis%";
            this.DiscountGV.Name = "DiscountGV";
            this.DiscountGV.ReadOnly = true;
            this.DiscountGV.Width = 56;
            // 
            // FinalAmountGV
            // 
            this.FinalAmountGV.HeaderText = "Final Amount";
            this.FinalAmountGV.Name = "FinalAmountGV";
            this.FinalAmountGV.ReadOnly = true;
            // 
            // panelInvoiceDetailButtons
            // 
            this.panelInvoiceDetailButtons.Controls.Add(this.label2);
            this.panelInvoiceDetailButtons.Controls.Add(this.tbxInvoiceDetailSearch);
            this.panelInvoiceDetailButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInvoiceDetailButtons.Location = new System.Drawing.Point(0, 209);
            this.panelInvoiceDetailButtons.Name = "panelInvoiceDetailButtons";
            this.panelInvoiceDetailButtons.Size = new System.Drawing.Size(879, 41);
            this.panelInvoiceDetailButtons.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search:";
            // 
            // tbxInvoiceDetailSearch
            // 
            this.tbxInvoiceDetailSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxInvoiceDetailSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInvoiceDetailSearch.Location = new System.Drawing.Point(77, 10);
            this.tbxInvoiceDetailSearch.MaxLength = 50;
            this.tbxInvoiceDetailSearch.Name = "tbxInvoiceDetailSearch";
            this.tbxInvoiceDetailSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxInvoiceDetailSearch.TabIndex = 5;
            this.tbxInvoiceDetailSearch.TextChanged += new System.EventHandler(this.tbxInvoiceDetailSearch_TextChanged);
            // 
            // panelInvoice
            // 
            this.panelInvoice.Controls.Add(this.dgvInvoice);
            this.panelInvoice.Controls.Add(this.panelInvoiceButtons);
            this.panelInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvoice.Location = new System.Drawing.Point(3, 3);
            this.panelInvoice.Name = "panelInvoice";
            this.panelInvoice.Size = new System.Drawing.Size(879, 250);
            this.panelInvoice.TabIndex = 7;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInvoice.ColumnHeadersHeight = 25;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceIDGV,
            this.SNOGV,
            this.InvoiceNoGV,
            this.BatchGV,
            this.DateGV,
            this.PartyIDGV,
            this.PartyGV,
            this.BooksGV,
            this.ChallanAmountGV,
            this.TotalAmountGV,
            this.ReferenceGV,
            this.ActionGV});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.EnableHeadersVisualStyles = false;
            this.dgvInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowHeadersVisible = false;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(879, 209);
            this.dgvInvoice.TabIndex = 14;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvInvoice_RowPostPaint);
            // 
            // InvoiceIDGV
            // 
            this.InvoiceIDGV.HeaderText = "InvoiceID";
            this.InvoiceIDGV.Name = "InvoiceIDGV";
            this.InvoiceIDGV.ReadOnly = true;
            this.InvoiceIDGV.Visible = false;
            // 
            // SNOGV
            // 
            this.SNOGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            this.SNOGV.Width = 57;
            // 
            // InvoiceNoGV
            // 
            this.InvoiceNoGV.HeaderText = "Invoice No.";
            this.InvoiceNoGV.Name = "InvoiceNoGV";
            this.InvoiceNoGV.ReadOnly = true;
            // 
            // BatchGV
            // 
            this.BatchGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BatchGV.HeaderText = "Batch";
            this.BatchGV.Name = "BatchGV";
            this.BatchGV.ReadOnly = true;
            this.BatchGV.Width = 65;
            // 
            // DateGV
            // 
            this.DateGV.HeaderText = "Date";
            this.DateGV.Name = "DateGV";
            this.DateGV.ReadOnly = true;
            // 
            // PartyIDGV
            // 
            this.PartyIDGV.HeaderText = "PartyID";
            this.PartyIDGV.Name = "PartyIDGV";
            this.PartyIDGV.ReadOnly = true;
            this.PartyIDGV.Visible = false;
            // 
            // PartyGV
            // 
            this.PartyGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PartyGV.HeaderText = "Party";
            this.PartyGV.Name = "PartyGV";
            this.PartyGV.ReadOnly = true;
            this.PartyGV.Width = 150;
            // 
            // BooksGV
            // 
            this.BooksGV.HeaderText = "Books";
            this.BooksGV.Name = "BooksGV";
            this.BooksGV.ReadOnly = true;
            // 
            // ChallanAmountGV
            // 
            this.ChallanAmountGV.HeaderText = "Amount";
            this.ChallanAmountGV.Name = "ChallanAmountGV";
            this.ChallanAmountGV.ReadOnly = true;
            // 
            // TotalAmountGV
            // 
            this.TotalAmountGV.HeaderText = "Total Amount";
            this.TotalAmountGV.Name = "TotalAmountGV";
            this.TotalAmountGV.ReadOnly = true;
            // 
            // ReferenceGV
            // 
            this.ReferenceGV.HeaderText = "Refrence";
            this.ReferenceGV.Name = "ReferenceGV";
            this.ReferenceGV.ReadOnly = true;
            // 
            // ActionGV
            // 
            this.ActionGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActionGV.HeaderText = "Action";
            this.ActionGV.Name = "ActionGV";
            this.ActionGV.ReadOnly = true;
            this.ActionGV.Text = "Details";
            this.ActionGV.UseColumnTextForButtonValue = true;
            // 
            // panelInvoiceButtons
            // 
            this.panelInvoiceButtons.Controls.Add(this.chbxLetterHead);
            this.panelInvoiceButtons.Controls.Add(this.label24);
            this.panelInvoiceButtons.Controls.Add(this.butPreview);
            this.panelInvoiceButtons.Controls.Add(this.chbxDeleteYear);
            this.panelInvoiceButtons.Controls.Add(this.label25);
            this.panelInvoiceButtons.Controls.Add(this.label3);
            this.panelInvoiceButtons.Controls.Add(this.butCancelInvoice);
            this.panelInvoiceButtons.Controls.Add(this.butDelete);
            this.panelInvoiceButtons.Controls.Add(this.tbxInvoiceSearch);
            this.panelInvoiceButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInvoiceButtons.Location = new System.Drawing.Point(0, 209);
            this.panelInvoiceButtons.Name = "panelInvoiceButtons";
            this.panelInvoiceButtons.Size = new System.Drawing.Size(879, 41);
            this.panelInvoiceButtons.TabIndex = 7;
            // 
            // chbxLetterHead
            // 
            this.chbxLetterHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxLetterHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxLetterHead.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxLetterHead.Checked = false;
            this.chbxLetterHead.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxLetterHead.ForeColor = System.Drawing.Color.White;
            this.chbxLetterHead.Location = new System.Drawing.Point(701, 8);
            this.chbxLetterHead.Name = "chbxLetterHead";
            this.chbxLetterHead.Size = new System.Drawing.Size(20, 20);
            this.chbxLetterHead.TabIndex = 30;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(723, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 17);
            this.label24.TabIndex = 29;
            this.label24.Text = "Letter Head";
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
            this.butPreview.Location = new System.Drawing.Point(225, 5);
            this.butPreview.Name = "butPreview";
            this.butPreview.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butPreview.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butPreview.OnHoverTextColor = System.Drawing.Color.White;
            this.butPreview.selected = false;
            this.butPreview.Size = new System.Drawing.Size(97, 30);
            this.butPreview.TabIndex = 1;
            this.butPreview.Text = "Preview";
            this.butPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butPreview.Textcolor = System.Drawing.Color.White;
            this.butPreview.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPreview.Click += new System.EventHandler(this.butPreview_Click);
            // 
            // chbxDeleteYear
            // 
            this.chbxDeleteYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxDeleteYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeleteYear.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeleteYear.Checked = false;
            this.chbxDeleteYear.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxDeleteYear.ForeColor = System.Drawing.Color.White;
            this.chbxDeleteYear.Location = new System.Drawing.Point(583, 9);
            this.chbxDeleteYear.Name = "chbxDeleteYear";
            this.chbxDeleteYear.Size = new System.Drawing.Size(20, 20);
            this.chbxDeleteYear.TabIndex = 28;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(609, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 17);
            this.label25.TabIndex = 27;
            this.label25.Text = "Delete Year";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search:";
            // 
            // butCancelInvoice
            // 
            this.butCancelInvoice.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butCancelInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butCancelInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butCancelInvoice.BorderRadius = 0;
            this.butCancelInvoice.ButtonText = "Cancel Invoice";
            this.butCancelInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCancelInvoice.DisabledColor = System.Drawing.Color.Gray;
            this.butCancelInvoice.Iconcolor = System.Drawing.Color.Transparent;
            this.butCancelInvoice.Iconimage = null;
            this.butCancelInvoice.Iconimage_right = null;
            this.butCancelInvoice.Iconimage_right_Selected = null;
            this.butCancelInvoice.Iconimage_Selected = null;
            this.butCancelInvoice.IconMarginLeft = 0;
            this.butCancelInvoice.IconMarginRight = 0;
            this.butCancelInvoice.IconRightVisible = true;
            this.butCancelInvoice.IconRightZoom = 0D;
            this.butCancelInvoice.IconVisible = true;
            this.butCancelInvoice.IconZoom = 90D;
            this.butCancelInvoice.IsTab = false;
            this.butCancelInvoice.Location = new System.Drawing.Point(116, 5);
            this.butCancelInvoice.Name = "butCancelInvoice";
            this.butCancelInvoice.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butCancelInvoice.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butCancelInvoice.OnHoverTextColor = System.Drawing.Color.White;
            this.butCancelInvoice.selected = false;
            this.butCancelInvoice.Size = new System.Drawing.Size(103, 30);
            this.butCancelInvoice.TabIndex = 1;
            this.butCancelInvoice.Text = "Cancel Invoice";
            this.butCancelInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butCancelInvoice.Textcolor = System.Drawing.Color.White;
            this.butCancelInvoice.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancelInvoice.Click += new System.EventHandler(this.butCancelInvoice_Click);
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
            this.butDelete.Location = new System.Drawing.Point(13, 5);
            this.butDelete.Name = "butDelete";
            this.butDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.butDelete.selected = false;
            this.butDelete.Size = new System.Drawing.Size(97, 30);
            this.butDelete.TabIndex = 1;
            this.butDelete.Text = "Delete";
            this.butDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butDelete.Textcolor = System.Drawing.Color.White;
            this.butDelete.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // tbxInvoiceSearch
            // 
            this.tbxInvoiceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxInvoiceSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInvoiceSearch.Location = new System.Drawing.Point(393, 8);
            this.tbxInvoiceSearch.MaxLength = 50;
            this.tbxInvoiceSearch.Name = "tbxInvoiceSearch";
            this.tbxInvoiceSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxInvoiceSearch.TabIndex = 5;
            this.tbxInvoiceSearch.TextChanged += new System.EventHandler(this.tbxInvoiceSearch_TextChanged);
            // 
            // InvoiceRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "InvoiceRecord";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.InvoiceRecord_Load);
            this.panelBody.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelInvoiceDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.panelInvoiceDetailButtons.ResumeLayout(false);
            this.panelInvoiceDetailButtons.PerformLayout();
            this.panelInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.panelInvoiceButtons.ResumeLayout(false);
            this.panelInvoiceButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelInvoiceDetails;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.Panel panelInvoiceDetailButtons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxInvoiceDetailSearch;
        private System.Windows.Forms.Panel panelInvoice;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Panel panelInvoiceButtons;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuFlatButton butDelete;
        private System.Windows.Forms.TextBox tbxInvoiceSearch;
        private ns1.BunifuFlatButton butPreview;
        private ns1.BunifuCheckbox chbxDeleteYear;
        private System.Windows.Forms.Label label25;
        private ns1.BunifuCheckbox chbxLetterHead;
        private System.Windows.Forms.Label label24;
        private ns1.BunifuFlatButton butCancelInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceGV;
        private System.Windows.Forms.DataGridViewButtonColumn ActionGV;
    }
}

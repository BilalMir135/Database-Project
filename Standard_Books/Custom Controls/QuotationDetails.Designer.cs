namespace Standard_Books.Custom_Controls
{
    partial class QuotationDetails
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelQuotationDetails = new System.Windows.Forms.Panel();
            this.dgvQuotationDetails = new System.Windows.Forms.DataGridView();
            this.panelQuotationDetailButtons = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxQuotationDetailSearch = new System.Windows.Forms.TextBox();
            this.panelQuotation = new System.Windows.Forms.Panel();
            this.dgvQuotation = new System.Windows.Forms.DataGridView();
            this.panelQuotationButtons = new System.Windows.Forms.Panel();
            this.chbxDeleteYear = new ns1.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butPreview = new ns1.BunifuFlatButton();
            this.butDelete = new ns1.BunifuFlatButton();
            this.tbxQuotationSearch = new System.Windows.Forms.TextBox();
            this.QuotationIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTitleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChallanAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SNOGV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBody.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelQuotationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotationDetails)).BeginInit();
            this.panelQuotationDetailButtons.SuspendLayout();
            this.panelQuotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotation)).BeginInit();
            this.panelQuotationButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.tableLayoutPanel1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 512);
            this.panelBody.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelQuotationDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelQuotation, 0, 0);
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
            // panelQuotationDetails
            // 
            this.panelQuotationDetails.Controls.Add(this.dgvQuotationDetails);
            this.panelQuotationDetails.Controls.Add(this.panelQuotationDetailButtons);
            this.panelQuotationDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuotationDetails.Location = new System.Drawing.Point(3, 259);
            this.panelQuotationDetails.Name = "panelQuotationDetails";
            this.panelQuotationDetails.Size = new System.Drawing.Size(879, 250);
            this.panelQuotationDetails.TabIndex = 8;
            // 
            // dgvQuotationDetails
            // 
            this.dgvQuotationDetails.AllowUserToAddRows = false;
            this.dgvQuotationDetails.AllowUserToDeleteRows = false;
            this.dgvQuotationDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuotationDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuotationDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuotationDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuotationDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuotationDetails.ColumnHeadersHeight = 25;
            this.dgvQuotationDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOGV1,
            this.ISBNGV,
            this.TitleGV,
            this.PriceGV,
            this.QuantityGV,
            this.AmountGV,
            this.DiscountGV,
            this.FinalAmountGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuotationDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuotationDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuotationDetails.EnableHeadersVisualStyles = false;
            this.dgvQuotationDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvQuotationDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvQuotationDetails.Name = "dgvQuotationDetails";
            this.dgvQuotationDetails.ReadOnly = true;
            this.dgvQuotationDetails.RowHeadersVisible = false;
            this.dgvQuotationDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuotationDetails.Size = new System.Drawing.Size(879, 209);
            this.dgvQuotationDetails.TabIndex = 14;
            this.dgvQuotationDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvQuotationDetails_RowPostPaint);
            // 
            // panelQuotationDetailButtons
            // 
            this.panelQuotationDetailButtons.Controls.Add(this.label2);
            this.panelQuotationDetailButtons.Controls.Add(this.tbxQuotationDetailSearch);
            this.panelQuotationDetailButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelQuotationDetailButtons.Location = new System.Drawing.Point(0, 209);
            this.panelQuotationDetailButtons.Name = "panelQuotationDetailButtons";
            this.panelQuotationDetailButtons.Size = new System.Drawing.Size(879, 41);
            this.panelQuotationDetailButtons.TabIndex = 7;
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
            // tbxQuotationDetailSearch
            // 
            this.tbxQuotationDetailSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxQuotationDetailSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuotationDetailSearch.Location = new System.Drawing.Point(77, 10);
            this.tbxQuotationDetailSearch.MaxLength = 50;
            this.tbxQuotationDetailSearch.Name = "tbxQuotationDetailSearch";
            this.tbxQuotationDetailSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxQuotationDetailSearch.TabIndex = 5;
            this.tbxQuotationDetailSearch.TextChanged += new System.EventHandler(this.tbxQuotationDetailSearch_TextChanged);
            // 
            // panelQuotation
            // 
            this.panelQuotation.Controls.Add(this.dgvQuotation);
            this.panelQuotation.Controls.Add(this.panelQuotationButtons);
            this.panelQuotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuotation.Location = new System.Drawing.Point(3, 3);
            this.panelQuotation.Name = "panelQuotation";
            this.panelQuotation.Size = new System.Drawing.Size(879, 250);
            this.panelQuotation.TabIndex = 7;
            // 
            // dgvQuotation
            // 
            this.dgvQuotation.AllowUserToAddRows = false;
            this.dgvQuotation.AllowUserToDeleteRows = false;
            this.dgvQuotation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuotation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuotation.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuotation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuotation.ColumnHeadersHeight = 25;
            this.dgvQuotation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuotationIDGV,
            this.SNOGV,
            this.QuotationNoGV,
            this.DateGV,
            this.QTitleGV,
            this.PartyIDGV,
            this.PartyGV,
            this.BooksGV,
            this.ChallanAmountGV,
            this.TotalAmountGV,
            this.ReferenceGV,
            this.ActionGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuotation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuotation.EnableHeadersVisualStyles = false;
            this.dgvQuotation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvQuotation.Location = new System.Drawing.Point(0, 0);
            this.dgvQuotation.Name = "dgvQuotation";
            this.dgvQuotation.ReadOnly = true;
            this.dgvQuotation.RowHeadersVisible = false;
            this.dgvQuotation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuotation.Size = new System.Drawing.Size(879, 209);
            this.dgvQuotation.TabIndex = 14;
            this.dgvQuotation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuotation_CellClick);
            this.dgvQuotation.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvQuotation_RowPostPaint);
            // 
            // panelQuotationButtons
            // 
            this.panelQuotationButtons.Controls.Add(this.chbxDeleteYear);
            this.panelQuotationButtons.Controls.Add(this.label4);
            this.panelQuotationButtons.Controls.Add(this.label3);
            this.panelQuotationButtons.Controls.Add(this.butPreview);
            this.panelQuotationButtons.Controls.Add(this.butDelete);
            this.panelQuotationButtons.Controls.Add(this.tbxQuotationSearch);
            this.panelQuotationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelQuotationButtons.Location = new System.Drawing.Point(0, 209);
            this.panelQuotationButtons.Name = "panelQuotationButtons";
            this.panelQuotationButtons.Size = new System.Drawing.Size(879, 41);
            this.panelQuotationButtons.TabIndex = 7;
            // 
            // chbxDeleteYear
            // 
            this.chbxDeleteYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxDeleteYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeleteYear.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeleteYear.Checked = false;
            this.chbxDeleteYear.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxDeleteYear.ForeColor = System.Drawing.Color.White;
            this.chbxDeleteYear.Location = new System.Drawing.Point(501, 11);
            this.chbxDeleteYear.Name = "chbxDeleteYear";
            this.chbxDeleteYear.Size = new System.Drawing.Size(20, 20);
            this.chbxDeleteYear.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Delete Year";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search:";
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
            this.butPreview.Location = new System.Drawing.Point(116, 5);
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
            // tbxQuotationSearch
            // 
            this.tbxQuotationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxQuotationSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuotationSearch.Location = new System.Drawing.Point(300, 8);
            this.tbxQuotationSearch.MaxLength = 50;
            this.tbxQuotationSearch.Name = "tbxQuotationSearch";
            this.tbxQuotationSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxQuotationSearch.TabIndex = 5;
            this.tbxQuotationSearch.TextChanged += new System.EventHandler(this.tbxQuotationSearch_TextChanged);
            // 
            // QuotationIDGV
            // 
            this.QuotationIDGV.HeaderText = "QuotationID";
            this.QuotationIDGV.Name = "QuotationIDGV";
            this.QuotationIDGV.ReadOnly = true;
            this.QuotationIDGV.Visible = false;
            // 
            // SNOGV
            // 
            this.SNOGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            this.SNOGV.Width = 57;
            // 
            // QuotationNoGV
            // 
            this.QuotationNoGV.HeaderText = "Quotation No.";
            this.QuotationNoGV.Name = "QuotationNoGV";
            this.QuotationNoGV.ReadOnly = true;
            // 
            // DateGV
            // 
            this.DateGV.HeaderText = "Date";
            this.DateGV.Name = "DateGV";
            this.DateGV.ReadOnly = true;
            // 
            // QTitleGV
            // 
            this.QTitleGV.HeaderText = "Title";
            this.QTitleGV.Name = "QTitleGV";
            this.QTitleGV.ReadOnly = true;
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
            this.PartyGV.Width = 120;
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
            // QuotationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "QuotationDetails";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.QuotationDetails_Load);
            this.panelBody.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelQuotationDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotationDetails)).EndInit();
            this.panelQuotationDetailButtons.ResumeLayout(false);
            this.panelQuotationDetailButtons.PerformLayout();
            this.panelQuotation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotation)).EndInit();
            this.panelQuotationButtons.ResumeLayout(false);
            this.panelQuotationButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelQuotationDetails;
        private System.Windows.Forms.DataGridView dgvQuotationDetails;
        private System.Windows.Forms.Panel panelQuotationDetailButtons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxQuotationDetailSearch;
        private System.Windows.Forms.Panel panelQuotation;
        private System.Windows.Forms.DataGridView dgvQuotation;
        private System.Windows.Forms.Panel panelQuotationButtons;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuFlatButton butDelete;
        private System.Windows.Forms.TextBox tbxQuotationSearch;
        private ns1.BunifuFlatButton butPreview;
        private ns1.BunifuCheckbox chbxDeleteYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTitleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceGV;
        private System.Windows.Forms.DataGridViewButtonColumn ActionGV;
    }
}

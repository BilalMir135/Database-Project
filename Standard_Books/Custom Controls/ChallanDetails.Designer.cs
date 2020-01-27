namespace Standard_Books.Custom_Controls
{
    partial class ChallanDetails
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
            this.panelChallanDetails = new System.Windows.Forms.Panel();
            this.dgvChallanDetails = new System.Windows.Forms.DataGridView();
            this.panelChallanDetailButtons = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxChallanDetailSearch = new System.Windows.Forms.TextBox();
            this.panelChallan = new System.Windows.Forms.Panel();
            this.dgvChallan = new System.Windows.Forms.DataGridView();
            this.panelChallanButtons = new System.Windows.Forms.Panel();
            this.chbxDetailChallan = new ns1.BunifuCheckbox();
            this.label19 = new System.Windows.Forms.Label();
            this.chbxDeleteYear = new ns1.BunifuCheckbox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butPreview = new ns1.BunifuFlatButton();
            this.butDelete = new ns1.BunifuFlatButton();
            this.tbxChallanSearch = new System.Windows.Forms.TextBox();
            this.ChallanIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChallanNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelChallanDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallanDetails)).BeginInit();
            this.panelChallanDetailButtons.SuspendLayout();
            this.panelChallan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallan)).BeginInit();
            this.panelChallanButtons.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.panelChallanDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelChallan, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 512);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelChallanDetails
            // 
            this.panelChallanDetails.Controls.Add(this.dgvChallanDetails);
            this.panelChallanDetails.Controls.Add(this.panelChallanDetailButtons);
            this.panelChallanDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChallanDetails.Location = new System.Drawing.Point(3, 259);
            this.panelChallanDetails.Name = "panelChallanDetails";
            this.panelChallanDetails.Size = new System.Drawing.Size(879, 250);
            this.panelChallanDetails.TabIndex = 8;
            // 
            // dgvChallanDetails
            // 
            this.dgvChallanDetails.AllowUserToAddRows = false;
            this.dgvChallanDetails.AllowUserToDeleteRows = false;
            this.dgvChallanDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChallanDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChallanDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvChallanDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChallanDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChallanDetails.ColumnHeadersHeight = 25;
            this.dgvChallanDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvChallanDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChallanDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChallanDetails.EnableHeadersVisualStyles = false;
            this.dgvChallanDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvChallanDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvChallanDetails.Name = "dgvChallanDetails";
            this.dgvChallanDetails.ReadOnly = true;
            this.dgvChallanDetails.RowHeadersVisible = false;
            this.dgvChallanDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChallanDetails.Size = new System.Drawing.Size(879, 209);
            this.dgvChallanDetails.TabIndex = 14;
            this.dgvChallanDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvChallanDetails_RowPostPaint);
            // 
            // panelChallanDetailButtons
            // 
            this.panelChallanDetailButtons.Controls.Add(this.label2);
            this.panelChallanDetailButtons.Controls.Add(this.tbxChallanDetailSearch);
            this.panelChallanDetailButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChallanDetailButtons.Location = new System.Drawing.Point(0, 209);
            this.panelChallanDetailButtons.Name = "panelChallanDetailButtons";
            this.panelChallanDetailButtons.Size = new System.Drawing.Size(879, 41);
            this.panelChallanDetailButtons.TabIndex = 7;
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
            // tbxChallanDetailSearch
            // 
            this.tbxChallanDetailSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxChallanDetailSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChallanDetailSearch.Location = new System.Drawing.Point(77, 10);
            this.tbxChallanDetailSearch.MaxLength = 50;
            this.tbxChallanDetailSearch.Name = "tbxChallanDetailSearch";
            this.tbxChallanDetailSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxChallanDetailSearch.TabIndex = 5;
            this.tbxChallanDetailSearch.TextChanged += new System.EventHandler(this.tbxChallanDetailSearch_TextChanged);
            // 
            // panelChallan
            // 
            this.panelChallan.Controls.Add(this.dgvChallan);
            this.panelChallan.Controls.Add(this.panelChallanButtons);
            this.panelChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChallan.Location = new System.Drawing.Point(3, 3);
            this.panelChallan.Name = "panelChallan";
            this.panelChallan.Size = new System.Drawing.Size(879, 250);
            this.panelChallan.TabIndex = 7;
            // 
            // dgvChallan
            // 
            this.dgvChallan.AllowUserToAddRows = false;
            this.dgvChallan.AllowUserToDeleteRows = false;
            this.dgvChallan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChallan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChallan.BackgroundColor = System.Drawing.Color.White;
            this.dgvChallan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChallan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChallan.ColumnHeadersHeight = 25;
            this.dgvChallan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChallanIDGV,
            this.SNOGV,
            this.ChallanNoGV,
            this.BatchGV,
            this.DateGV,
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
            this.dgvChallan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChallan.EnableHeadersVisualStyles = false;
            this.dgvChallan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvChallan.Location = new System.Drawing.Point(0, 0);
            this.dgvChallan.Name = "dgvChallan";
            this.dgvChallan.ReadOnly = true;
            this.dgvChallan.RowHeadersVisible = false;
            this.dgvChallan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChallan.Size = new System.Drawing.Size(879, 209);
            this.dgvChallan.TabIndex = 14;
            this.dgvChallan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChallan_CellClick);
            this.dgvChallan.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvChallan_RowPostPaint);
            // 
            // panelChallanButtons
            // 
            this.panelChallanButtons.Controls.Add(this.chbxDetailChallan);
            this.panelChallanButtons.Controls.Add(this.label19);
            this.panelChallanButtons.Controls.Add(this.chbxDeleteYear);
            this.panelChallanButtons.Controls.Add(this.label18);
            this.panelChallanButtons.Controls.Add(this.label3);
            this.panelChallanButtons.Controls.Add(this.butPreview);
            this.panelChallanButtons.Controls.Add(this.butDelete);
            this.panelChallanButtons.Controls.Add(this.tbxChallanSearch);
            this.panelChallanButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChallanButtons.Location = new System.Drawing.Point(0, 209);
            this.panelChallanButtons.Name = "panelChallanButtons";
            this.panelChallanButtons.Size = new System.Drawing.Size(879, 41);
            this.panelChallanButtons.TabIndex = 7;
            // 
            // chbxDetailChallan
            // 
            this.chbxDetailChallan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxDetailChallan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDetailChallan.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDetailChallan.Checked = false;
            this.chbxDetailChallan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxDetailChallan.ForeColor = System.Drawing.Color.White;
            this.chbxDetailChallan.Location = new System.Drawing.Point(612, 11);
            this.chbxDetailChallan.Name = "chbxDetailChallan";
            this.chbxDetailChallan.Size = new System.Drawing.Size(20, 20);
            this.chbxDetailChallan.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(638, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 17);
            this.label19.TabIndex = 23;
            this.label19.Text = "Detail Challan";
            // 
            // chbxDeleteYear
            // 
            this.chbxDeleteYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxDeleteYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeleteYear.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDeleteYear.Checked = false;
            this.chbxDeleteYear.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxDeleteYear.ForeColor = System.Drawing.Color.White;
            this.chbxDeleteYear.Location = new System.Drawing.Point(481, 11);
            this.chbxDeleteYear.Name = "chbxDeleteYear";
            this.chbxDeleteYear.Size = new System.Drawing.Size(20, 20);
            this.chbxDeleteYear.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(507, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Delete Year";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 11);
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
            // tbxChallanSearch
            // 
            this.tbxChallanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxChallanSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChallanSearch.Location = new System.Drawing.Point(288, 8);
            this.tbxChallanSearch.MaxLength = 50;
            this.tbxChallanSearch.Name = "tbxChallanSearch";
            this.tbxChallanSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxChallanSearch.TabIndex = 5;
            this.tbxChallanSearch.TextChanged += new System.EventHandler(this.tbxChallanSearch_TextChanged);
            // 
            // ChallanIDGV
            // 
            this.ChallanIDGV.HeaderText = "ChallanID";
            this.ChallanIDGV.Name = "ChallanIDGV";
            this.ChallanIDGV.ReadOnly = true;
            this.ChallanIDGV.Visible = false;
            // 
            // SNOGV
            // 
            this.SNOGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            this.SNOGV.Width = 57;
            // 
            // ChallanNoGV
            // 
            this.ChallanNoGV.HeaderText = "Challan No.";
            this.ChallanNoGV.Name = "ChallanNoGV";
            this.ChallanNoGV.ReadOnly = true;
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
            // ChallanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "ChallanDetails";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.ChallanDetails_Load);
            this.panelBody.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelChallanDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallanDetails)).EndInit();
            this.panelChallanDetailButtons.ResumeLayout(false);
            this.panelChallanDetailButtons.PerformLayout();
            this.panelChallan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallan)).EndInit();
            this.panelChallanButtons.ResumeLayout(false);
            this.panelChallanButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelChallanDetails;
        private System.Windows.Forms.Panel panelChallanDetailButtons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxChallanDetailSearch;
        private System.Windows.Forms.Panel panelChallan;
        private System.Windows.Forms.Panel panelChallanButtons;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuFlatButton butDelete;
        private System.Windows.Forms.TextBox tbxChallanSearch;
        private System.Windows.Forms.DataGridView dgvChallan;
        private System.Windows.Forms.DataGridView dgvChallanDetails;
        private ns1.BunifuFlatButton butPreview;
        private ns1.BunifuCheckbox chbxDeleteYear;
        private System.Windows.Forms.Label label18;
        private ns1.BunifuCheckbox chbxDetailChallan;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanNoGV;
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

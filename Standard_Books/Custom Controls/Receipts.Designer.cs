namespace Standard_Books.Custom_Controls
{
    partial class Receipts
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelsearch = new System.Windows.Forms.Label();
            this.butDetails = new ns1.BunifuFlatButton();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.butPreview = new ns1.BunifuFlatButton();
            this.butCancel = new ns1.BunifuFlatButton();
            this.butSave = new ns1.BunifuFlatButton();
            this.butDelete = new ns1.BunifuFlatButton();
            this.butEdit = new ns1.BunifuFlatButton();
            this.butAdd = new ns1.BunifuFlatButton();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelGV = new System.Windows.Forms.Panel();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNoGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarksGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeTaxGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelinvoice = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxIncomeTax = new System.Windows.Forms.TextBox();
            this.tbxOutstandingAmount = new System.Windows.Forms.TextBox();
            this.tbxInvoiceAmount = new System.Windows.Forms.TextBox();
            this.tbxInvoiceDate = new System.Windows.Forms.TextBox();
            this.tbxInvoiceNo = new System.Windows.Forms.TextBox();
            this.dtpReceipt = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxCC = new System.Windows.Forms.TextBox();
            this.tbxRemarks = new System.Windows.Forms.TextBox();
            this.tbxReceipt = new System.Windows.Forms.TextBox();
            this.panelButtons.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.panelinvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.labelsearch);
            this.panelButtons.Controls.Add(this.butDetails);
            this.panelButtons.Controls.Add(this.tbxSearch);
            this.panelButtons.Controls.Add(this.butPreview);
            this.panelButtons.Controls.Add(this.butCancel);
            this.panelButtons.Controls.Add(this.butSave);
            this.panelButtons.Controls.Add(this.butDelete);
            this.panelButtons.Controls.Add(this.butEdit);
            this.panelButtons.Controls.Add(this.butAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 392);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(885, 120);
            this.panelButtons.TabIndex = 2;
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsearch.Location = new System.Drawing.Point(479, 22);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(55, 17);
            this.labelsearch.TabIndex = 15;
            this.labelsearch.Text = "Search:";
            this.labelsearch.Visible = false;
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
            this.butDetails.Location = new System.Drawing.Point(260, 19);
            this.butDetails.Name = "butDetails";
            this.butDetails.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butDetails.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.butDetails.selected = false;
            this.butDetails.Size = new System.Drawing.Size(108, 41);
            this.butDetails.TabIndex = 52;
            this.butDetails.Text = "Details";
            this.butDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butDetails.Textcolor = System.Drawing.Color.White;
            this.butDetails.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDetails.Click += new System.EventHandler(this.butDetails_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(543, 19);
            this.tbxSearch.MaxLength = 50;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxSearch.TabIndex = 16;
            this.tbxSearch.Visible = false;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
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
            this.butPreview.TabIndex = 51;
            this.butPreview.Text = "Preview";
            this.butPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butPreview.Textcolor = System.Drawing.Color.White;
            this.butPreview.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPreview.Click += new System.EventHandler(this.butPreview_Click);
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
            this.butCancel.TabIndex = 8;
            this.butCancel.Text = "Cancel";
            this.butCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butCancel.Textcolor = System.Drawing.Color.White;
            this.butCancel.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
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
            this.butSave.TabIndex = 7;
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
            // panelControls
            // 
            this.panelControls.Controls.Add(this.panelGV);
            this.panelControls.Controls.Add(this.panelinvoice);
            this.panelControls.Controls.Add(this.dtpReceipt);
            this.panelControls.Controls.Add(this.label11);
            this.panelControls.Controls.Add(this.label10);
            this.panelControls.Controls.Add(this.label9);
            this.panelControls.Controls.Add(this.label8);
            this.panelControls.Controls.Add(this.label7);
            this.panelControls.Controls.Add(this.tbxAmount);
            this.panelControls.Controls.Add(this.tbxCC);
            this.panelControls.Controls.Add(this.tbxRemarks);
            this.panelControls.Controls.Add(this.tbxReceipt);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(885, 392);
            this.panelControls.TabIndex = 7;
            // 
            // panelGV
            // 
            this.panelGV.Controls.Add(this.dgvReceipt);
            this.panelGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGV.Location = new System.Drawing.Point(0, 101);
            this.panelGV.Name = "panelGV";
            this.panelGV.Size = new System.Drawing.Size(885, 291);
            this.panelGV.TabIndex = 15;
            this.panelGV.Visible = false;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceipt.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceipt.ColumnHeadersHeight = 25;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOGV,
            this.InvoiceDateGV,
            this.InvoiceAmountGV,
            this.IDGV,
            this.InvoiceNoGv,
            this.ReceiptNoGv,
            this.DateGV,
            this.RemarksGv,
            this.CCGV,
            this.IncomeTaxGV,
            this.AmountGV,
            this.PaidAmountGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceipt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceipt.EnableHeadersVisualStyles = false;
            this.dgvReceipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvReceipt.Location = new System.Drawing.Point(0, 0);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersVisible = false;
            this.dgvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipt.Size = new System.Drawing.Size(885, 291);
            this.dgvReceipt.TabIndex = 12;
            this.dgvReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellClick);
            this.dgvReceipt.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvReceipt_RowPostPaint);
            // 
            // SNOGV
            // 
            this.SNOGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            this.SNOGV.Width = 57;
            // 
            // InvoiceDateGV
            // 
            this.InvoiceDateGV.HeaderText = "InvoiceDate";
            this.InvoiceDateGV.Name = "InvoiceDateGV";
            this.InvoiceDateGV.ReadOnly = true;
            this.InvoiceDateGV.Visible = false;
            // 
            // InvoiceAmountGV
            // 
            this.InvoiceAmountGV.HeaderText = "InvoiceAmount";
            this.InvoiceAmountGV.Name = "InvoiceAmountGV";
            this.InvoiceAmountGV.ReadOnly = true;
            this.InvoiceAmountGV.Visible = false;
            // 
            // IDGV
            // 
            this.IDGV.HeaderText = "ID";
            this.IDGV.Name = "IDGV";
            this.IDGV.ReadOnly = true;
            this.IDGV.Visible = false;
            // 
            // InvoiceNoGv
            // 
            this.InvoiceNoGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InvoiceNoGv.HeaderText = "Invoice No.";
            this.InvoiceNoGv.Name = "InvoiceNoGv";
            this.InvoiceNoGv.ReadOnly = true;
            this.InvoiceNoGv.Width = 95;
            // 
            // ReceiptNoGv
            // 
            this.ReceiptNoGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReceiptNoGv.HeaderText = "Receipt No.";
            this.ReceiptNoGv.Name = "ReceiptNoGv";
            this.ReceiptNoGv.ReadOnly = true;
            this.ReceiptNoGv.Width = 96;
            // 
            // DateGV
            // 
            this.DateGV.HeaderText = "Date";
            this.DateGV.Name = "DateGV";
            this.DateGV.ReadOnly = true;
            // 
            // RemarksGv
            // 
            this.RemarksGv.HeaderText = "Remarks";
            this.RemarksGv.Name = "RemarksGv";
            this.RemarksGv.ReadOnly = true;
            // 
            // CCGV
            // 
            this.CCGV.HeaderText = "Cheque/Cash";
            this.CCGV.Name = "CCGV";
            this.CCGV.ReadOnly = true;
            // 
            // IncomeTaxGV
            // 
            this.IncomeTaxGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IncomeTaxGV.HeaderText = "Income Tax";
            this.IncomeTaxGV.Name = "IncomeTaxGV";
            this.IncomeTaxGV.ReadOnly = true;
            this.IncomeTaxGV.Width = 96;
            // 
            // AmountGV
            // 
            this.AmountGV.HeaderText = "Received Amount";
            this.AmountGV.Name = "AmountGV";
            this.AmountGV.ReadOnly = true;
            // 
            // PaidAmountGV
            // 
            this.PaidAmountGV.HeaderText = "PaidAmount";
            this.PaidAmountGV.Name = "PaidAmountGV";
            this.PaidAmountGV.ReadOnly = true;
            this.PaidAmountGV.Visible = false;
            // 
            // panelinvoice
            // 
            this.panelinvoice.Controls.Add(this.label6);
            this.panelinvoice.Controls.Add(this.label2);
            this.panelinvoice.Controls.Add(this.label5);
            this.panelinvoice.Controls.Add(this.label4);
            this.panelinvoice.Controls.Add(this.label3);
            this.panelinvoice.Controls.Add(this.tbxIncomeTax);
            this.panelinvoice.Controls.Add(this.tbxOutstandingAmount);
            this.panelinvoice.Controls.Add(this.tbxInvoiceAmount);
            this.panelinvoice.Controls.Add(this.tbxInvoiceDate);
            this.panelinvoice.Controls.Add(this.tbxInvoiceNo);
            this.panelinvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelinvoice.Location = new System.Drawing.Point(0, 0);
            this.panelinvoice.Name = "panelinvoice";
            this.panelinvoice.Size = new System.Drawing.Size(885, 101);
            this.panelinvoice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(598, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Income Tax Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Outstanding Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Invoice Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Invoice Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Invoice No:";
            // 
            // tbxIncomeTax
            // 
            this.tbxIncomeTax.Enabled = false;
            this.tbxIncomeTax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIncomeTax.Location = new System.Drawing.Point(741, 19);
            this.tbxIncomeTax.Name = "tbxIncomeTax";
            this.tbxIncomeTax.Size = new System.Drawing.Size(120, 23);
            this.tbxIncomeTax.TabIndex = 1;
            // 
            // tbxOutstandingAmount
            // 
            this.tbxOutstandingAmount.Enabled = false;
            this.tbxOutstandingAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOutstandingAmount.Location = new System.Drawing.Point(441, 58);
            this.tbxOutstandingAmount.Name = "tbxOutstandingAmount";
            this.tbxOutstandingAmount.Size = new System.Drawing.Size(120, 23);
            this.tbxOutstandingAmount.TabIndex = 11;
            // 
            // tbxInvoiceAmount
            // 
            this.tbxInvoiceAmount.Enabled = false;
            this.tbxInvoiceAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInvoiceAmount.Location = new System.Drawing.Point(441, 19);
            this.tbxInvoiceAmount.Name = "tbxInvoiceAmount";
            this.tbxInvoiceAmount.Size = new System.Drawing.Size(120, 23);
            this.tbxInvoiceAmount.TabIndex = 12;
            // 
            // tbxInvoiceDate
            // 
            this.tbxInvoiceDate.Enabled = false;
            this.tbxInvoiceDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInvoiceDate.Location = new System.Drawing.Point(124, 58);
            this.tbxInvoiceDate.Name = "tbxInvoiceDate";
            this.tbxInvoiceDate.Size = new System.Drawing.Size(120, 23);
            this.tbxInvoiceDate.TabIndex = 9;
            // 
            // tbxInvoiceNo
            // 
            this.tbxInvoiceNo.Enabled = false;
            this.tbxInvoiceNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInvoiceNo.Location = new System.Drawing.Point(124, 19);
            this.tbxInvoiceNo.MaxLength = 20;
            this.tbxInvoiceNo.Name = "tbxInvoiceNo";
            this.tbxInvoiceNo.Size = new System.Drawing.Size(120, 23);
            this.tbxInvoiceNo.TabIndex = 0;
            this.tbxInvoiceNo.Validated += new System.EventHandler(this.tbxInvoiceNo_Validated);
            // 
            // dtpReceipt
            // 
            this.dtpReceipt.CustomFormat = "dd-MMM-yyyy";
            this.dtpReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceipt.Location = new System.Drawing.Point(260, 177);
            this.dtpReceipt.Name = "dtpReceipt";
            this.dtpReceipt.Size = new System.Drawing.Size(168, 20);
            this.dtpReceipt.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(151, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(151, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cheque/Cash:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Remarks:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Receipt Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Receipt No:";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAmount.Location = new System.Drawing.Point(260, 317);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(168, 23);
            this.tbxAmount.TabIndex = 6;
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAmount_KeyPress);
            this.tbxAmount.Validated += new System.EventHandler(this.tbxAmount_Validated);
            // 
            // tbxCC
            // 
            this.tbxCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCC.Location = new System.Drawing.Point(260, 260);
            this.tbxCC.Multiline = true;
            this.tbxCC.Name = "tbxCC";
            this.tbxCC.Size = new System.Drawing.Size(488, 51);
            this.tbxCC.TabIndex = 5;
            // 
            // tbxRemarks
            // 
            this.tbxRemarks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRemarks.Location = new System.Drawing.Point(260, 203);
            this.tbxRemarks.Multiline = true;
            this.tbxRemarks.Name = "tbxRemarks";
            this.tbxRemarks.Size = new System.Drawing.Size(488, 51);
            this.tbxRemarks.TabIndex = 4;
            // 
            // tbxReceipt
            // 
            this.tbxReceipt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReceipt.Location = new System.Drawing.Point(260, 148);
            this.tbxReceipt.Name = "tbxReceipt";
            this.tbxReceipt.Size = new System.Drawing.Size(168, 23);
            this.tbxReceipt.TabIndex = 2;
            // 
            // Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelButtons);
            this.Name = "Receipts";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.Receipts_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.panelinvoice.ResumeLayout(false);
            this.panelinvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private ns1.BunifuFlatButton butPreview;
        private ns1.BunifuFlatButton butCancel;
        private ns1.BunifuFlatButton butSave;
        private ns1.BunifuFlatButton butDelete;
        private ns1.BunifuFlatButton butAdd;
        private ns1.BunifuFlatButton butEdit;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.DateTimePicker dtpReceipt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.TextBox tbxCC;
        private System.Windows.Forms.TextBox tbxRemarks;
        private System.Windows.Forms.TextBox tbxReceipt;
        private ns1.BunifuFlatButton butDetails;
        private System.Windows.Forms.Panel panelinvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxIncomeTax;
        private System.Windows.Forms.TextBox tbxOutstandingAmount;
        private System.Windows.Forms.TextBox tbxInvoiceAmount;
        private System.Windows.Forms.TextBox tbxInvoiceDate;
        private System.Windows.Forms.TextBox tbxInvoiceNo;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel panelGV;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNoGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarksGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeTaxGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmountGV;
    }
}

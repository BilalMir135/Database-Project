namespace Standard_Books.Custom_Controls
{
    partial class Freight
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCharges = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.tbxAbbrevation = new System.Windows.Forms.TextBox();
            this.panelGV = new System.Windows.Forms.Panel();
            this.dgvFreight = new System.Windows.Forms.DataGridView();
            this.FreightIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbbreGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargesGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.butPreview = new ns1.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.butCancel = new ns1.BunifuFlatButton();
            this.butSave = new ns1.BunifuFlatButton();
            this.butDelete = new ns1.BunifuFlatButton();
            this.butEdit = new ns1.BunifuFlatButton();
            this.butAdd = new ns1.BunifuFlatButton();
            this.panelBody.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreight)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelControls);
            this.panelBody.Controls.Add(this.panelGV);
            this.panelBody.Controls.Add(this.panelButtons);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 512);
            this.panelBody.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.label5);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.tbxCharges);
            this.panelControls.Controls.Add(this.tbxDestination);
            this.panelControls.Controls.Add(this.tbxAbbrevation);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(444, 392);
            this.panelControls.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Destination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Abbrevation:";
            // 
            // tbxCharges
            // 
            this.tbxCharges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCharges.Location = new System.Drawing.Point(170, 214);
            this.tbxCharges.MaxLength = 8;
            this.tbxCharges.Name = "tbxCharges";
            this.tbxCharges.Size = new System.Drawing.Size(100, 23);
            this.tbxCharges.TabIndex = 2;
            this.tbxCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCharges_KeyPress);
            // 
            // tbxDestination
            // 
            this.tbxDestination.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDestination.Location = new System.Drawing.Point(170, 185);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(222, 23);
            this.tbxDestination.TabIndex = 1;
            // 
            // tbxAbbrevation
            // 
            this.tbxAbbrevation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAbbrevation.Location = new System.Drawing.Point(170, 156);
            this.tbxAbbrevation.MaxLength = 5;
            this.tbxAbbrevation.Name = "tbxAbbrevation";
            this.tbxAbbrevation.Size = new System.Drawing.Size(100, 23);
            this.tbxAbbrevation.TabIndex = 0;
            // 
            // panelGV
            // 
            this.panelGV.Controls.Add(this.dgvFreight);
            this.panelGV.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGV.Location = new System.Drawing.Point(444, 0);
            this.panelGV.Name = "panelGV";
            this.panelGV.Size = new System.Drawing.Size(441, 392);
            this.panelGV.TabIndex = 4;
            // 
            // dgvFreight
            // 
            this.dgvFreight.AllowUserToAddRows = false;
            this.dgvFreight.AllowUserToDeleteRows = false;
            this.dgvFreight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFreight.BackgroundColor = System.Drawing.Color.White;
            this.dgvFreight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFreight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFreight.ColumnHeadersHeight = 25;
            this.dgvFreight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FreightIDGV,
            this.SNOGV,
            this.AbbreGV,
            this.DestinationGV,
            this.ChargesGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFreight.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFreight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFreight.EnableHeadersVisualStyles = false;
            this.dgvFreight.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvFreight.Location = new System.Drawing.Point(0, 0);
            this.dgvFreight.Name = "dgvFreight";
            this.dgvFreight.ReadOnly = true;
            this.dgvFreight.RowHeadersVisible = false;
            this.dgvFreight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFreight.Size = new System.Drawing.Size(441, 392);
            this.dgvFreight.TabIndex = 2;
            this.dgvFreight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFreight_CellClick);
            this.dgvFreight.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvFreight_RowPostPaint);
            // 
            // FreightIDGV
            // 
            this.FreightIDGV.HeaderText = "FreightID";
            this.FreightIDGV.Name = "FreightIDGV";
            this.FreightIDGV.ReadOnly = true;
            this.FreightIDGV.Visible = false;
            // 
            // SNOGV
            // 
            this.SNOGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            this.SNOGV.Width = 57;
            // 
            // AbbreGV
            // 
            this.AbbreGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AbbreGV.HeaderText = "Abbre.";
            this.AbbreGV.Name = "AbbreGV";
            this.AbbreGV.ReadOnly = true;
            this.AbbreGV.Width = 69;
            // 
            // DestinationGV
            // 
            this.DestinationGV.HeaderText = "Destination";
            this.DestinationGV.Name = "DestinationGV";
            this.DestinationGV.ReadOnly = true;
            // 
            // ChargesGV
            // 
            this.ChargesGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ChargesGV.HeaderText = "Charges";
            this.ChargesGV.Name = "ChargesGV";
            this.ChargesGV.ReadOnly = true;
            this.ChargesGV.Width = 78;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.butPreview);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Controls.Add(this.tbxSearch);
            this.panelButtons.Controls.Add(this.butCancel);
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
            this.butPreview.Location = new System.Drawing.Point(260, 19);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(542, 19);
            this.tbxSearch.MaxLength = 5;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxSearch.TabIndex = 50;
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
            // Freight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "Freight";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.Freight_Load);
            this.panelBody.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreight)).EndInit();
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
        private System.Windows.Forms.Panel panelGV;
        private System.Windows.Forms.DataGridView dgvFreight;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCharges;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.TextBox tbxAbbrevation;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreightIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbbreGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChargesGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearch;
        private ns1.BunifuFlatButton butPreview;
    }
}

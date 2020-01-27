namespace Standard_Books.Custom_Controls
{
    partial class Supplier
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
            this.panelGV = new System.Windows.Forms.Panel();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.SupplierIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxFax = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxProvince = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.butPreview = new ns1.BunifuFlatButton();
            this.butDetails = new ns1.BunifuFlatButton();
            this.labelsearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.butCancel = new ns1.BunifuFlatButton();
            this.butSave = new ns1.BunifuFlatButton();
            this.butDelete = new ns1.BunifuFlatButton();
            this.butEdit = new ns1.BunifuFlatButton();
            this.butAdd = new ns1.BunifuFlatButton();
            this.panelBody.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
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
            this.panelControls.Controls.Add(this.panelGV);
            this.panelControls.Controls.Add(this.tbxEmail);
            this.panelControls.Controls.Add(this.tbxCity);
            this.panelControls.Controls.Add(this.tbxFax);
            this.panelControls.Controls.Add(this.tbxName);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.label9);
            this.panelControls.Controls.Add(this.tbxCountry);
            this.panelControls.Controls.Add(this.tbxProvince);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.tbxPhone);
            this.panelControls.Controls.Add(this.tbxAddress);
            this.panelControls.Controls.Add(this.label5);
            this.panelControls.Controls.Add(this.label6);
            this.panelControls.Controls.Add(this.label7);
            this.panelControls.Controls.Add(this.label10);
            this.panelControls.Controls.Add(this.label8);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(885, 392);
            this.panelControls.TabIndex = 11;
            // 
            // panelGV
            // 
            this.panelGV.Controls.Add(this.dgvSupplier);
            this.panelGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGV.Location = new System.Drawing.Point(0, 0);
            this.panelGV.Name = "panelGV";
            this.panelGV.Size = new System.Drawing.Size(885, 392);
            this.panelGV.TabIndex = 9;
            this.panelGV.Visible = false;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.ColumnHeadersHeight = 25;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierIDGV,
            this.SNOGV,
            this.NameGV,
            this.AddressGV,
            this.CityGV,
            this.ProvinceGV,
            this.CountryGV,
            this.PhoneGV,
            this.FaxGV,
            this.EmailGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplier.EnableHeadersVisualStyles = false;
            this.dgvSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvSupplier.Location = new System.Drawing.Point(0, 0);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(885, 392);
            this.dgvSupplier.TabIndex = 12;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
            this.dgvSupplier.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSupplier_RowPostPaint);
            // 
            // SupplierIDGV
            // 
            this.SupplierIDGV.HeaderText = "SupplierID";
            this.SupplierIDGV.Name = "SupplierIDGV";
            this.SupplierIDGV.ReadOnly = true;
            this.SupplierIDGV.Visible = false;
            // 
            // SNOGV
            // 
            this.SNOGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            this.SNOGV.Width = 57;
            // 
            // NameGV
            // 
            this.NameGV.FillWeight = 28.16903F;
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // AddressGV
            // 
            this.AddressGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AddressGV.FillWeight = 602.8168F;
            this.AddressGV.HeaderText = "Address";
            this.AddressGV.Name = "AddressGV";
            this.AddressGV.ReadOnly = true;
            this.AddressGV.Width = 180;
            // 
            // CityGV
            // 
            this.CityGV.FillWeight = 28.16903F;
            this.CityGV.HeaderText = "City";
            this.CityGV.Name = "CityGV";
            this.CityGV.ReadOnly = true;
            // 
            // ProvinceGV
            // 
            this.ProvinceGV.FillWeight = 28.16903F;
            this.ProvinceGV.HeaderText = "Province";
            this.ProvinceGV.Name = "ProvinceGV";
            this.ProvinceGV.ReadOnly = true;
            // 
            // CountryGV
            // 
            this.CountryGV.FillWeight = 28.16903F;
            this.CountryGV.HeaderText = "Country";
            this.CountryGV.Name = "CountryGV";
            this.CountryGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.FillWeight = 28.16903F;
            this.PhoneGV.HeaderText = "Cell";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // FaxGV
            // 
            this.FaxGV.FillWeight = 28.16903F;
            this.FaxGV.HeaderText = "Tell";
            this.FaxGV.Name = "FaxGV";
            this.FaxGV.ReadOnly = true;
            // 
            // EmailGV
            // 
            this.EmailGV.FillWeight = 28.16903F;
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(195, 286);
            this.tbxEmail.MaxLength = 100;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(215, 23);
            this.tbxEmail.TabIndex = 7;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.Location = new System.Drawing.Point(195, 141);
            this.tbxCity.MaxLength = 50;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(100, 23);
            this.tbxCity.TabIndex = 2;
            // 
            // tbxFax
            // 
            this.tbxFax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFax.Location = new System.Drawing.Point(195, 257);
            this.tbxFax.MaxLength = 20;
            this.tbxFax.Name = "tbxFax";
            this.tbxFax.Size = new System.Drawing.Size(215, 23);
            this.tbxFax.TabIndex = 6;
            this.tbxFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(195, 83);
            this.tbxName.MaxLength = 100;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(215, 23);
            this.tbxName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tell:";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCountry.Location = new System.Drawing.Point(195, 199);
            this.tbxCountry.MaxLength = 50;
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(100, 23);
            this.tbxCountry.TabIndex = 4;
            // 
            // tbxProvince
            // 
            this.tbxProvince.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProvince.Location = new System.Drawing.Point(195, 170);
            this.tbxProvince.MaxLength = 50;
            this.tbxProvince.Name = "tbxProvince";
            this.tbxProvince.Size = new System.Drawing.Size(100, 23);
            this.tbxProvince.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(195, 228);
            this.tbxPhone.MaxLength = 20;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(215, 23);
            this.tbxPhone.TabIndex = 5;
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(195, 112);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(611, 23);
            this.tbxAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Province:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Country:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cell:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.butPreview);
            this.panelButtons.Controls.Add(this.butDetails);
            this.panelButtons.Controls.Add(this.labelsearch);
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
            this.panelButtons.TabIndex = 2;
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
            this.butPreview.TabIndex = 2;
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
            this.butDetails.Location = new System.Drawing.Point(260, 19);
            this.butDetails.Name = "butDetails";
            this.butDetails.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butDetails.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.butDetails.selected = false;
            this.butDetails.Size = new System.Drawing.Size(108, 41);
            this.butDetails.TabIndex = 9;
            this.butDetails.Text = "Details";
            this.butDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butDetails.Textcolor = System.Drawing.Color.White;
            this.butDetails.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDetails.Click += new System.EventHandler(this.butDetails_Click);
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsearch.Location = new System.Drawing.Point(479, 22);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(55, 17);
            this.labelsearch.TabIndex = 3;
            this.labelsearch.Text = "Search:";
            this.labelsearch.Visible = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(543, 19);
            this.tbxSearch.MaxLength = 50;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(175, 23);
            this.tbxSearch.TabIndex = 3;
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
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "Supplier";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.panelBody.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelButtons;
        private ns1.BunifuFlatButton butDetails;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private ns1.BunifuFlatButton butCancel;
        private ns1.BunifuFlatButton butSave;
        private ns1.BunifuFlatButton butDelete;
        private ns1.BunifuFlatButton butEdit;
        private ns1.BunifuFlatButton butAdd;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxFax;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxProvince;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelGV;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private ns1.BunifuFlatButton butPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
    }
}

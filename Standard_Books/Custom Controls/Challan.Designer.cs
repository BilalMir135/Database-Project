﻿namespace Standard_Books.Custom_Controls
{
    partial class Challan
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
            this.panelGV = new System.Windows.Forms.Panel();
            this.dgvChallan = new System.Windows.Forms.DataGridView();
            this.panelControls = new System.Windows.Forms.Panel();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxExchangeRate = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxCurrency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBookTotalAmount = new System.Windows.Forms.TextBox();
            this.tbxBookAmount = new System.Windows.Forms.TextBox();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelChallan = new System.Windows.Forms.Panel();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.butChallanSave = new ns1.BunifuFlatButton();
            this.tbxChallanNo = new System.Windows.Forms.TextBox();
            this.cbxParty = new System.Windows.Forms.ComboBox();
            this.dtpChallan = new System.Windows.Forms.DateTimePicker();
            this.tbxReference = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxBatchNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.chbxDetailChallan = new ns1.BunifuCheckbox();
            this.label19 = new System.Windows.Forms.Label();
            this.chbxDeleteYear = new ns1.BunifuCheckbox();
            this.label18 = new System.Windows.Forms.Label();
            this.butPreview = new ns1.BunifuFlatButton();
            this.butAddtocart = new ns1.BunifuFlatButton();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxTotalAmount = new System.Windows.Forms.TextBox();
            this.tbxTotalQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.butEdit = new ns1.BunifuFlatButton();
            this.butSearch = new ns1.BunifuFlatButton();
            this.butCancel = new ns1.BunifuFlatButton();
            this.butSave = new ns1.BunifuFlatButton();
            this.butAdd = new ns1.BunifuFlatButton();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelBody.SuspendLayout();
            this.panelGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallan)).BeginInit();
            this.panelControls.SuspendLayout();
            this.panelChallan.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelGV);
            this.panelBody.Controls.Add(this.panelControls);
            this.panelBody.Controls.Add(this.panelButtons);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(885, 512);
            this.panelBody.TabIndex = 0;
            // 
            // panelGV
            // 
            this.panelGV.Controls.Add(this.dgvChallan);
            this.panelGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGV.Location = new System.Drawing.Point(0, 162);
            this.panelGV.Name = "panelGV";
            this.panelGV.Size = new System.Drawing.Size(885, 230);
            this.panelGV.TabIndex = 4;
            // 
            // dgvChallan
            // 
            this.dgvChallan.AllowUserToAddRows = false;
            this.dgvChallan.AllowUserToDeleteRows = false;
            this.dgvChallan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChallan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChallan.BackgroundColor = System.Drawing.Color.White;
            this.dgvChallan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChallan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChallan.ColumnHeadersHeight = 25;
            this.dgvChallan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOGV,
            this.ISBNGV,
            this.TitleGV,
            this.PriceGV,
            this.QuantityGV,
            this.AmountGV,
            this.DiscountGV,
            this.FinalAmountGV,
            this.DeleteGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChallan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChallan.EnableHeadersVisualStyles = false;
            this.dgvChallan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.dgvChallan.Location = new System.Drawing.Point(0, 0);
            this.dgvChallan.Name = "dgvChallan";
            this.dgvChallan.ReadOnly = true;
            this.dgvChallan.RowHeadersVisible = false;
            this.dgvChallan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChallan.Size = new System.Drawing.Size(885, 230);
            this.dgvChallan.TabIndex = 13;
            this.dgvChallan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChallan_CellClick);
            this.dgvChallan.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvChallan_RowPostPaint);
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.tbxQuantity);
            this.panelControls.Controls.Add(this.tbxExchangeRate);
            this.panelControls.Controls.Add(this.tbxPrice);
            this.panelControls.Controls.Add(this.tbxCurrency);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.tbxBookTotalAmount);
            this.panelControls.Controls.Add(this.tbxBookAmount);
            this.panelControls.Controls.Add(this.tbxISBN);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.label5);
            this.panelControls.Controls.Add(this.tbxDiscount);
            this.panelControls.Controls.Add(this.label16);
            this.panelControls.Controls.Add(this.label6);
            this.panelControls.Controls.Add(this.label15);
            this.panelControls.Controls.Add(this.label7);
            this.panelControls.Controls.Add(this.label17);
            this.panelControls.Controls.Add(this.panelChallan);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(885, 162);
            this.panelControls.TabIndex = 3;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(346, 26);
            this.tbxQuantity.MaxLength = 6;
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(57, 23);
            this.tbxQuantity.TabIndex = 10;
            this.tbxQuantity.TextChanged += new System.EventHandler(this.tbxQuantity_TextChanged);
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // tbxExchangeRate
            // 
            this.tbxExchangeRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxExchangeRate.Enabled = false;
            this.tbxExchangeRate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExchangeRate.Location = new System.Drawing.Point(126, 113);
            this.tbxExchangeRate.MaxLength = 50;
            this.tbxExchangeRate.Name = "tbxExchangeRate";
            this.tbxExchangeRate.Size = new System.Drawing.Size(100, 23);
            this.tbxExchangeRate.TabIndex = 9;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxPrice.Enabled = false;
            this.tbxPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(126, 84);
            this.tbxPrice.MaxLength = 50;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 23);
            this.tbxPrice.TabIndex = 8;
            this.tbxPrice.Validated += new System.EventHandler(this.tbxPrice_Validated);
            // 
            // tbxCurrency
            // 
            this.tbxCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCurrency.Enabled = false;
            this.tbxCurrency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrency.Location = new System.Drawing.Point(126, 55);
            this.tbxCurrency.MaxLength = 50;
            this.tbxCurrency.Name = "tbxCurrency";
            this.tbxCurrency.Size = new System.Drawing.Size(100, 23);
            this.tbxCurrency.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantity:";
            // 
            // tbxBookTotalAmount
            // 
            this.tbxBookTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxBookTotalAmount.Enabled = false;
            this.tbxBookTotalAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookTotalAmount.Location = new System.Drawing.Point(346, 113);
            this.tbxBookTotalAmount.MaxLength = 50;
            this.tbxBookTotalAmount.Name = "tbxBookTotalAmount";
            this.tbxBookTotalAmount.Size = new System.Drawing.Size(136, 23);
            this.tbxBookTotalAmount.TabIndex = 13;
            // 
            // tbxBookAmount
            // 
            this.tbxBookAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxBookAmount.Enabled = false;
            this.tbxBookAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookAmount.Location = new System.Drawing.Point(346, 55);
            this.tbxBookAmount.MaxLength = 50;
            this.tbxBookAmount.Name = "tbxBookAmount";
            this.tbxBookAmount.Size = new System.Drawing.Size(136, 23);
            this.tbxBookAmount.TabIndex = 11;
            // 
            // tbxISBN
            // 
            this.tbxISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxISBN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxISBN.Location = new System.Drawing.Point(126, 26);
            this.tbxISBN.MaxLength = 50;
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(100, 23);
            this.tbxISBN.TabIndex = 6;
            this.tbxISBN.Validated += new System.EventHandler(this.tbxISBN_Validated);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Exchange Rate:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price:";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxDiscount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiscount.Location = new System.Drawing.Point(346, 84);
            this.tbxDiscount.MaxLength = 10;
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(57, 23);
            this.tbxDiscount.TabIndex = 12;
            this.tbxDiscount.TextChanged += new System.EventHandler(this.tbxDiscount_TextChanged);
            this.tbxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(242, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Total Amount:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Currency:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(242, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Discount %:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "ISBN:";
            // 
            // panelChallan
            // 
            this.panelChallan.Controls.Add(this.tbxCode);
            this.panelChallan.Controls.Add(this.butChallanSave);
            this.panelChallan.Controls.Add(this.tbxChallanNo);
            this.panelChallan.Controls.Add(this.cbxParty);
            this.panelChallan.Controls.Add(this.dtpChallan);
            this.panelChallan.Controls.Add(this.tbxReference);
            this.panelChallan.Controls.Add(this.label8);
            this.panelChallan.Controls.Add(this.tbxBatchNo);
            this.panelChallan.Controls.Add(this.label2);
            this.panelChallan.Controls.Add(this.label12);
            this.panelChallan.Controls.Add(this.label13);
            this.panelChallan.Controls.Add(this.label14);
            this.panelChallan.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChallan.Location = new System.Drawing.Point(488, 0);
            this.panelChallan.Name = "panelChallan";
            this.panelChallan.Size = new System.Drawing.Size(397, 162);
            this.panelChallan.TabIndex = 13;
            // 
            // tbxCode
            // 
            this.tbxCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCode.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCode.Location = new System.Drawing.Point(132, 66);
            this.tbxCode.MaxLength = 10;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(64, 25);
            this.tbxCode.TabIndex = 3;
            this.tbxCode.Validated += new System.EventHandler(this.tbxCode_Validated);
            // 
            // butChallanSave
            // 
            this.butChallanSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butChallanSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butChallanSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butChallanSave.BorderRadius = 0;
            this.butChallanSave.ButtonText = "Save";
            this.butChallanSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butChallanSave.DisabledColor = System.Drawing.Color.Gray;
            this.butChallanSave.Enabled = false;
            this.butChallanSave.Iconcolor = System.Drawing.Color.Transparent;
            this.butChallanSave.Iconimage = null;
            this.butChallanSave.Iconimage_right = null;
            this.butChallanSave.Iconimage_right_Selected = null;
            this.butChallanSave.Iconimage_Selected = null;
            this.butChallanSave.IconMarginLeft = 0;
            this.butChallanSave.IconMarginRight = 0;
            this.butChallanSave.IconRightVisible = true;
            this.butChallanSave.IconRightZoom = 0D;
            this.butChallanSave.IconVisible = true;
            this.butChallanSave.IconZoom = 90D;
            this.butChallanSave.IsTab = false;
            this.butChallanSave.Location = new System.Drawing.Point(23, 118);
            this.butChallanSave.Name = "butChallanSave";
            this.butChallanSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butChallanSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butChallanSave.OnHoverTextColor = System.Drawing.Color.White;
            this.butChallanSave.selected = false;
            this.butChallanSave.Size = new System.Drawing.Size(74, 33);
            this.butChallanSave.TabIndex = 12;
            this.butChallanSave.Text = "Save";
            this.butChallanSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butChallanSave.Textcolor = System.Drawing.Color.White;
            this.butChallanSave.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChallanSave.Click += new System.EventHandler(this.butChallanSave_Click);
            // 
            // tbxChallanNo
            // 
            this.tbxChallanNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxChallanNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChallanNo.Location = new System.Drawing.Point(132, 11);
            this.tbxChallanNo.MaxLength = 20;
            this.tbxChallanNo.Name = "tbxChallanNo";
            this.tbxChallanNo.Size = new System.Drawing.Size(131, 23);
            this.tbxChallanNo.TabIndex = 0;
            // 
            // cbxParty
            // 
            this.cbxParty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxParty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxParty.FormattingEnabled = true;
            this.cbxParty.Location = new System.Drawing.Point(202, 66);
            this.cbxParty.Name = "cbxParty";
            this.cbxParty.Size = new System.Drawing.Size(184, 25);
            this.cbxParty.TabIndex = 4;
            this.cbxParty.SelectedIndexChanged += new System.EventHandler(this.cbxParty_SelectedIndexChanged);
            // 
            // dtpChallan
            // 
            this.dtpChallan.CustomFormat = "dd-MMM-yyyy";
            this.dtpChallan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChallan.Location = new System.Drawing.Point(132, 40);
            this.dtpChallan.Name = "dtpChallan";
            this.dtpChallan.Size = new System.Drawing.Size(254, 20);
            this.dtpChallan.TabIndex = 2;
            // 
            // tbxReference
            // 
            this.tbxReference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxReference.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReference.Location = new System.Drawing.Point(132, 97);
            this.tbxReference.Multiline = true;
            this.tbxReference.Name = "tbxReference";
            this.tbxReference.Size = new System.Drawing.Size(254, 54);
            this.tbxReference.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Reference:";
            // 
            // tbxBatchNo
            // 
            this.tbxBatchNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxBatchNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBatchNo.Location = new System.Drawing.Point(347, 11);
            this.tbxBatchNo.MaxLength = 5;
            this.tbxBatchNo.Name = "tbxBatchNo";
            this.tbxBatchNo.Size = new System.Drawing.Size(39, 23);
            this.tbxBatchNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Batch No:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Challan No:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Party:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Challan Date:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.chbxDetailChallan);
            this.panelButtons.Controls.Add(this.label19);
            this.panelButtons.Controls.Add(this.chbxDeleteYear);
            this.panelButtons.Controls.Add(this.label18);
            this.panelButtons.Controls.Add(this.butPreview);
            this.panelButtons.Controls.Add(this.butAddtocart);
            this.panelButtons.Controls.Add(this.tbxAmount);
            this.panelButtons.Controls.Add(this.tbxTotalAmount);
            this.panelButtons.Controls.Add(this.tbxTotalQuantity);
            this.panelButtons.Controls.Add(this.label11);
            this.panelButtons.Controls.Add(this.label10);
            this.panelButtons.Controls.Add(this.label9);
            this.panelButtons.Controls.Add(this.butEdit);
            this.panelButtons.Controls.Add(this.butSearch);
            this.panelButtons.Controls.Add(this.butCancel);
            this.panelButtons.Controls.Add(this.butSave);
            this.panelButtons.Controls.Add(this.butAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 392);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(885, 120);
            this.panelButtons.TabIndex = 2;
            // 
            // chbxDetailChallan
            // 
            this.chbxDetailChallan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxDetailChallan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDetailChallan.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chbxDetailChallan.Checked = false;
            this.chbxDetailChallan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.chbxDetailChallan.ForeColor = System.Drawing.Color.White;
            this.chbxDetailChallan.Location = new System.Drawing.Point(513, 87);
            this.chbxDetailChallan.Name = "chbxDetailChallan";
            this.chbxDetailChallan.Size = new System.Drawing.Size(20, 20);
            this.chbxDetailChallan.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(539, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 17);
            this.label19.TabIndex = 19;
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
            this.chbxDeleteYear.Location = new System.Drawing.Point(513, 62);
            this.chbxDeleteYear.Name = "chbxDeleteYear";
            this.chbxDeleteYear.Size = new System.Drawing.Size(20, 20);
            this.chbxDeleteYear.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(539, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "Delete Year";
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
            // butAddtocart
            // 
            this.butAddtocart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butAddtocart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butAddtocart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddtocart.BorderRadius = 0;
            this.butAddtocart.ButtonText = "Add to cart";
            this.butAddtocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddtocart.DisabledColor = System.Drawing.Color.Gray;
            this.butAddtocart.Enabled = false;
            this.butAddtocart.Iconcolor = System.Drawing.Color.Transparent;
            this.butAddtocart.Iconimage = null;
            this.butAddtocart.Iconimage_right = null;
            this.butAddtocart.Iconimage_right_Selected = null;
            this.butAddtocart.Iconimage_Selected = null;
            this.butAddtocart.IconMarginLeft = 0;
            this.butAddtocart.IconMarginRight = 0;
            this.butAddtocart.IconRightVisible = true;
            this.butAddtocart.IconRightZoom = 0D;
            this.butAddtocart.IconVisible = true;
            this.butAddtocart.IconZoom = 90D;
            this.butAddtocart.IsTab = false;
            this.butAddtocart.Location = new System.Drawing.Point(146, 19);
            this.butAddtocart.Name = "butAddtocart";
            this.butAddtocart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butAddtocart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butAddtocart.OnHoverTextColor = System.Drawing.Color.White;
            this.butAddtocart.selected = false;
            this.butAddtocart.Size = new System.Drawing.Size(108, 41);
            this.butAddtocart.TabIndex = 18;
            this.butAddtocart.Text = "Add to cart";
            this.butAddtocart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butAddtocart.Textcolor = System.Drawing.Color.White;
            this.butAddtocart.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddtocart.Click += new System.EventHandler(this.butAddtocart_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAmount.Enabled = false;
            this.tbxAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAmount.Location = new System.Drawing.Point(601, 33);
            this.tbxAmount.MaxLength = 20;
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(116, 23);
            this.tbxAmount.TabIndex = 16;
            this.tbxAmount.Text = "0";
            this.tbxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxTotalAmount
            // 
            this.tbxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTotalAmount.Enabled = false;
            this.tbxTotalAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalAmount.Location = new System.Drawing.Point(723, 33);
            this.tbxTotalAmount.MaxLength = 20;
            this.tbxTotalAmount.Name = "tbxTotalAmount";
            this.tbxTotalAmount.Size = new System.Drawing.Size(116, 23);
            this.tbxTotalAmount.TabIndex = 17;
            this.tbxTotalAmount.Text = "0";
            this.tbxTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxTotalQuantity
            // 
            this.tbxTotalQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTotalQuantity.Enabled = false;
            this.tbxTotalQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalQuantity.Location = new System.Drawing.Point(513, 33);
            this.tbxTotalQuantity.MaxLength = 10;
            this.tbxTotalQuantity.Name = "tbxTotalQuantity";
            this.tbxTotalQuantity.Size = new System.Drawing.Size(82, 23);
            this.tbxTotalQuantity.TabIndex = 12;
            this.tbxTotalQuantity.Text = "0";
            this.tbxTotalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(726, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Amount";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(624, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Amount";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quantity";
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
            this.butEdit.Enabled = false;
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
            this.butEdit.Location = new System.Drawing.Point(260, 19);
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
            // butSearch
            // 
            this.butSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSearch.BorderRadius = 0;
            this.butSearch.ButtonText = "Search";
            this.butSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSearch.DisabledColor = System.Drawing.Color.Gray;
            this.butSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.butSearch.Iconimage = null;
            this.butSearch.Iconimage_right = null;
            this.butSearch.Iconimage_right_Selected = null;
            this.butSearch.Iconimage_Selected = null;
            this.butSearch.IconMarginLeft = 0;
            this.butSearch.IconMarginRight = 0;
            this.butSearch.IconRightVisible = true;
            this.butSearch.IconRightZoom = 0D;
            this.butSearch.IconVisible = true;
            this.butSearch.IconZoom = 90D;
            this.butSearch.IsTab = false;
            this.butSearch.Location = new System.Drawing.Point(260, 66);
            this.butSearch.Name = "butSearch";
            this.butSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.butSearch.selected = false;
            this.butSearch.Size = new System.Drawing.Size(108, 41);
            this.butSearch.TabIndex = 2;
            this.butSearch.Text = "Search";
            this.butSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butSearch.Textcolor = System.Drawing.Color.White;
            this.butSearch.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
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
            this.butCancel.Location = new System.Drawing.Point(146, 66);
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
            this.butSave.Location = new System.Drawing.Point(32, 66);
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
            // DeleteGV
            // 
            this.DeleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteGV.HeaderText = "Action";
            this.DeleteGV.Name = "DeleteGV";
            this.DeleteGV.ReadOnly = true;
            this.DeleteGV.Text = "Delete";
            this.DeleteGV.UseColumnTextForButtonValue = true;
            // 
            // Challan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBody);
            this.Name = "Challan";
            this.Size = new System.Drawing.Size(885, 512);
            this.Load += new System.EventHandler(this.Challan_Load);
            this.panelBody.ResumeLayout(false);
            this.panelGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallan)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelChallan.ResumeLayout(false);
            this.panelChallan.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelButtons;
        private ns1.BunifuFlatButton butAddtocart;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.TextBox tbxTotalAmount;
        private System.Windows.Forms.TextBox tbxTotalQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private ns1.BunifuFlatButton butCancel;
        private ns1.BunifuFlatButton butSave;
        private ns1.BunifuFlatButton butAdd;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxExchangeRate;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBookTotalAmount;
        private System.Windows.Forms.TextBox tbxBookAmount;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelChallan;
        private ns1.BunifuFlatButton butChallanSave;
        private System.Windows.Forms.TextBox tbxChallanNo;
        private System.Windows.Forms.ComboBox cbxParty;
        private System.Windows.Forms.DateTimePicker dtpChallan;
        private System.Windows.Forms.TextBox tbxReference;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxBatchNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelGV;
        private System.Windows.Forms.DataGridView dgvChallan;
        private ns1.BunifuFlatButton butSearch;
        private ns1.BunifuFlatButton butEdit;
        private System.Windows.Forms.TextBox tbxCode;
        private ns1.BunifuFlatButton butPreview;
        private ns1.BunifuCheckbox chbxDetailChallan;
        private System.Windows.Forms.Label label19;
        private ns1.BunifuCheckbox chbxDeleteYear;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGV;
    }
}

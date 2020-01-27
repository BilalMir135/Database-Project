namespace Standard_Books.Custom_Controls
{
    partial class TitleBar
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
            this.butMinimize = new ns1.BunifuFlatButton();
            this.butClose = new ns1.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxMaximize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // butMinimize
            // 
            this.butMinimize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMinimize.BorderRadius = 0;
            this.butMinimize.ButtonText = "-";
            this.butMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.butMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.butMinimize.Iconimage = null;
            this.butMinimize.Iconimage_right = null;
            this.butMinimize.Iconimage_right_Selected = null;
            this.butMinimize.Iconimage_Selected = null;
            this.butMinimize.IconMarginLeft = 0;
            this.butMinimize.IconMarginRight = 0;
            this.butMinimize.IconRightVisible = true;
            this.butMinimize.IconRightZoom = 0D;
            this.butMinimize.IconVisible = true;
            this.butMinimize.IconZoom = 90D;
            this.butMinimize.IsTab = false;
            this.butMinimize.Location = new System.Drawing.Point(586, -5);
            this.butMinimize.Name = "butMinimize";
            this.butMinimize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butMinimize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.butMinimize.selected = false;
            this.butMinimize.Size = new System.Drawing.Size(43, 37);
            this.butMinimize.TabIndex = 14;
            this.butMinimize.Text = "-";
            this.butMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butMinimize.Textcolor = System.Drawing.Color.White;
            this.butMinimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMinimize.Click += new System.EventHandler(this.butMinimize_Click);
            // 
            // butClose
            // 
            this.butClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.butClose.Location = new System.Drawing.Point(679, -5);
            this.butClose.Name = "butClose";
            this.butClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.butClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.butClose.OnHoverTextColor = System.Drawing.Color.White;
            this.butClose.selected = false;
            this.butClose.Size = new System.Drawing.Size(43, 37);
            this.butClose.TabIndex = 12;
            this.butClose.Text = "X";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butClose.Textcolor = System.Drawing.Color.White;
            this.butClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Text Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Standard_Books.Properties.Resources.book_title_bar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pbxMaximize
            // 
            this.pbxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximize.Image = global::Standard_Books.Properties.Resources.Icono_Maximizar___Hover;
            this.pbxMaximize.Location = new System.Drawing.Point(630, -5);
            this.pbxMaximize.Name = "pbxMaximize";
            this.pbxMaximize.Size = new System.Drawing.Size(47, 39);
            this.pbxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMaximize.TabIndex = 13;
            this.pbxMaximize.TabStop = false;
            this.pbxMaximize.Click += new System.EventHandler(this.pbxMaximize_Click);
            this.pbxMaximize.MouseLeave += new System.EventHandler(this.pbxMaximize_MouseLeave);
            this.pbxMaximize.MouseHover += new System.EventHandler(this.pbxMaximize_MouseHover);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(144)))), ((int)(((byte)(203)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butMinimize);
            this.Controls.Add(this.pbxMaximize);
            this.Controls.Add(this.butClose);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(721, 28);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuFlatButton butMinimize;
        private System.Windows.Forms.PictureBox pbxMaximize;
        private ns1.BunifuFlatButton butClose;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

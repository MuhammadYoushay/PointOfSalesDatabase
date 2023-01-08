namespace POS_Project
{
    partial class Adjustments
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adjustments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.products_footer_panel = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtSearch1 = new MetroFramework.Controls.MetroTextBox();
            this.products_label1 = new System.Windows.Forms.Label();
            this.Brand_mod_header = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Category_mod_label = new System.Windows.Forms.Label();
            this.grid_stkadj = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.products_footer_panel.SuspendLayout();
            this.Brand_mod_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stkadj)).BeginInit();
            this.SuspendLayout();
            // 
            // products_footer_panel
            // 
            this.products_footer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.products_footer_panel.Controls.Add(this.btn_save);
            this.products_footer_panel.Controls.Add(this.txtSearch1);
            this.products_footer_panel.Controls.Add(this.products_label1);
            this.products_footer_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.products_footer_panel.Location = new System.Drawing.Point(0, 427);
            this.products_footer_panel.Name = "products_footer_panel";
            this.products_footer_panel.Size = new System.Drawing.Size(921, 52);
            this.products_footer_panel.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.Enabled = false;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(805, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 31);
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSearch1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch1.BackColor = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.txtSearch1.CustomButton.Image = null;
            this.txtSearch1.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.txtSearch1.CustomButton.Name = "";
            this.txtSearch1.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSearch1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch1.CustomButton.TabIndex = 1;
            this.txtSearch1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch1.CustomButton.UseSelectable = true;
            this.txtSearch1.CustomButton.Visible = false;
            this.txtSearch1.DisplayIcon = true;
            this.txtSearch1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch1.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch1.Icon")));
            this.txtSearch1.Lines = new string[0];
            this.txtSearch1.Location = new System.Drawing.Point(327, 9);
            this.txtSearch1.MaxLength = 32767;
            this.txtSearch1.Multiline = true;
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.PasswordChar = '\0';
            this.txtSearch1.PromptText = "Search Here";
            this.txtSearch1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch1.SelectedText = "";
            this.txtSearch1.SelectionLength = 0;
            this.txtSearch1.SelectionStart = 0;
            this.txtSearch1.ShortcutsEnabled = true;
            this.txtSearch1.Size = new System.Drawing.Size(344, 31);
            this.txtSearch1.TabIndex = 2;
            this.txtSearch1.UseCustomBackColor = true;
            this.txtSearch1.UseSelectable = true;
            this.txtSearch1.WaterMark = "Search Here";
            this.txtSearch1.WaterMarkColor = System.Drawing.Color.White;
            this.txtSearch1.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch1.TextChanged += new System.EventHandler(this.txtSearch1_TextChanged);
            // 
            // products_label1
            // 
            this.products_label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.products_label1.Image = ((System.Drawing.Image)(resources.GetObject("products_label1.Image")));
            this.products_label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_label1.Location = new System.Drawing.Point(8, 5);
            this.products_label1.Name = "products_label1";
            this.products_label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.products_label1.Size = new System.Drawing.Size(207, 40);
            this.products_label1.TabIndex = 0;
            this.products_label1.Text = "Stock Adjustment";
            this.products_label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.products_label1.Click += new System.EventHandler(this.products_label1_Click);
            // 
            // Brand_mod_header
            // 
            this.Brand_mod_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.Brand_mod_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Brand_mod_header.Controls.Add(this.textBox2);
            this.Brand_mod_header.Controls.Add(this.textBox1);
            this.Brand_mod_header.Controls.Add(this.comboBox1);
            this.Brand_mod_header.Controls.Add(this.label9);
            this.Brand_mod_header.Controls.Add(this.label8);
            this.Brand_mod_header.Controls.Add(this.label7);
            this.Brand_mod_header.Controls.Add(this.label6);
            this.Brand_mod_header.Controls.Add(this.label5);
            this.Brand_mod_header.Controls.Add(this.label4);
            this.Brand_mod_header.Controls.Add(this.label3);
            this.Brand_mod_header.Controls.Add(this.label2);
            this.Brand_mod_header.Controls.Add(this.label1);
            this.Brand_mod_header.Controls.Add(this.Category_mod_label);
            this.Brand_mod_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Brand_mod_header.Location = new System.Drawing.Point(0, 0);
            this.Brand_mod_header.Name = "Brand_mod_header";
            this.Brand_mod_header.Size = new System.Drawing.Size(921, 102);
            this.Brand_mod_header.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(684, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 26);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(683, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Remove From Inventory",
            "Add To Inventory"});
            this.comboBox1.Location = new System.Drawing.Point(684, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(583, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Remarks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(586, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(584, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Action";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(360, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Product Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(145, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Product Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(145, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "RefNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(285, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference No.";
            // 
            // Category_mod_label
            // 
            this.Category_mod_label.AutoSize = true;
            this.Category_mod_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_mod_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Category_mod_label.Location = new System.Drawing.Point(3, 3);
            this.Category_mod_label.Name = "Category_mod_label";
            this.Category_mod_label.Size = new System.Drawing.Size(134, 18);
            this.Category_mod_label.TabIndex = 0;
            this.Category_mod_label.Text = "Stock Adjustment";
            // 
            // grid_stkadj
            // 
            this.grid_stkadj.AllowUserToAddRows = false;
            this.grid_stkadj.AllowUserToResizeColumns = false;
            this.grid_stkadj.AllowUserToResizeRows = false;
            this.grid_stkadj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stkadj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_stkadj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_stkadj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Pcode,
            this.Barcode,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Select});
            this.grid_stkadj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_stkadj.EnableHeadersVisualStyles = false;
            this.grid_stkadj.Location = new System.Drawing.Point(0, 102);
            this.grid_stkadj.Name = "grid_stkadj";
            this.grid_stkadj.RowHeadersVisible = false;
            this.grid_stkadj.Size = new System.Drawing.Size(921, 325);
            this.grid_stkadj.TabIndex = 9;
            this.grid_stkadj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_stkadj_CellContentClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 55;
            // 
            // Pcode
            // 
            this.Pcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pcode.HeaderText = "Product code";
            this.Pcode.Name = "Pcode";
            this.Pcode.Width = 136;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 98;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Brand";
            this.Column5.Name = "Column5";
            this.Column5.Width = 77;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Category";
            this.Column6.Name = "Column6";
            this.Column6.Width = 104;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Price";
            this.Column7.Name = "Column7";
            this.Column7.Width = 71;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Stock Available";
            this.Column8.Name = "Column8";
            this.Column8.Width = 135;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Select.Name = "Select";
            this.Select.Width = 5;
            // 
            // Adjustments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 479);
            this.ControlBox = false;
            this.Controls.Add(this.grid_stkadj);
            this.Controls.Add(this.Brand_mod_header);
            this.Controls.Add(this.products_footer_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Adjustments";
            this.Text = "Adjustments";
            this.products_footer_panel.ResumeLayout(false);
            this.Brand_mod_header.ResumeLayout(false);
            this.Brand_mod_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stkadj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel products_footer_panel;
        public System.Windows.Forms.Button btn_save;
        private MetroFramework.Controls.MetroTextBox txtSearch1;
        private System.Windows.Forms.Label products_label1;
        private System.Windows.Forms.Panel Brand_mod_header;
        private System.Windows.Forms.Label Category_mod_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView grid_stkadj;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Select;
    }
}
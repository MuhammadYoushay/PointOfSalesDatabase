namespace POS_Project
{
    partial class ProductsModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsModule));
            this.Brand_mod_header = new System.Windows.Forms.Panel();
            this.Products_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Products_mod_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.Products_cancel_btn = new System.Windows.Forms.Button();
            this.Products_update_btn = new System.Windows.Forms.Button();
            this.Products_save_btn = new System.Windows.Forms.Button();
            this.Product_textBox1 = new System.Windows.Forms.TextBox();
            this.Product_code_label = new System.Windows.Forms.Label();
            this.Barcode = new System.Windows.Forms.Label();
            this.Barcode_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Description_textBox1 = new System.Windows.Forms.TextBox();
            this.Brand_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Brand_label2 = new System.Windows.Forms.Label();
            this.Category_label2 = new System.Windows.Forms.Label();
            this.Category_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Price_label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReOrder_label2 = new System.Windows.Forms.Label();
            this.ReOrder_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Brand_mod_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReOrder_numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Brand_mod_header
            // 
            this.Brand_mod_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.Brand_mod_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Brand_mod_header.Controls.Add(this.Products_pictureBox1);
            this.Brand_mod_header.Controls.Add(this.Products_mod_label);
            this.Brand_mod_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Brand_mod_header.Location = new System.Drawing.Point(0, 0);
            this.Brand_mod_header.Name = "Brand_mod_header";
            this.Brand_mod_header.Size = new System.Drawing.Size(633, 41);
            this.Brand_mod_header.TabIndex = 7;
            // 
            // Products_pictureBox1
            // 
            this.Products_pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Products_pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("Products_pictureBox1.Image")));
            this.Products_pictureBox1.Location = new System.Drawing.Point(590, 6);
            this.Products_pictureBox1.Name = "Products_pictureBox1";
            this.Products_pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.Products_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Products_pictureBox1.TabIndex = 1;
            this.Products_pictureBox1.TabStop = false;
            this.Products_pictureBox1.Click += new System.EventHandler(this.Products_pictureBox1_Click);
            // 
            // Products_mod_label
            // 
            this.Products_mod_label.AutoSize = true;
            this.Products_mod_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_mod_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Products_mod_label.Location = new System.Drawing.Point(12, 9);
            this.Products_mod_label.Name = "Products_mod_label";
            this.Products_mod_label.Size = new System.Drawing.Size(131, 18);
            this.Products_mod_label.TabIndex = 0;
            this.Products_mod_label.Text = "Products Module";
            // 
            // id_label
            // 
            this.id_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(45, 376);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(25, 20);
            this.id_label.TabIndex = 13;
            this.id_label.Text = "ID";
            this.id_label.Visible = false;
            // 
            // Products_cancel_btn
            // 
            this.Products_cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Products_cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Products_cancel_btn.Location = new System.Drawing.Point(542, 371);
            this.Products_cancel_btn.Name = "Products_cancel_btn";
            this.Products_cancel_btn.Size = new System.Drawing.Size(79, 31);
            this.Products_cancel_btn.TabIndex = 12;
            this.Products_cancel_btn.Text = "Cancel";
            this.Products_cancel_btn.UseVisualStyleBackColor = false;
            this.Products_cancel_btn.Click += new System.EventHandler(this.Products_cancel_btn_Click);
            // 
            // Products_update_btn
            // 
            this.Products_update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_update_btn.BackColor = System.Drawing.Color.Olive;
            this.Products_update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Products_update_btn.Location = new System.Drawing.Point(456, 371);
            this.Products_update_btn.Name = "Products_update_btn";
            this.Products_update_btn.Size = new System.Drawing.Size(79, 31);
            this.Products_update_btn.TabIndex = 11;
            this.Products_update_btn.Text = "Update";
            this.Products_update_btn.UseVisualStyleBackColor = false;
            this.Products_update_btn.Click += new System.EventHandler(this.Products_update_btn_Click);
            // 
            // Products_save_btn
            // 
            this.Products_save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.Products_save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Products_save_btn.Location = new System.Drawing.Point(368, 371);
            this.Products_save_btn.Name = "Products_save_btn";
            this.Products_save_btn.Size = new System.Drawing.Size(79, 31);
            this.Products_save_btn.TabIndex = 10;
            this.Products_save_btn.Text = "Save";
            this.Products_save_btn.UseVisualStyleBackColor = false;
            this.Products_save_btn.Click += new System.EventHandler(this.Products_save_btn_Click);
            // 
            // Product_textBox1
            // 
            this.Product_textBox1.BackColor = System.Drawing.Color.LightGray;
            this.Product_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Product_textBox1.Location = new System.Drawing.Point(177, 65);
            this.Product_textBox1.Name = "Product_textBox1";
            this.Product_textBox1.Size = new System.Drawing.Size(141, 26);
            this.Product_textBox1.TabIndex = 9;
            // 
            // Product_code_label
            // 
            this.Product_code_label.AutoSize = true;
            this.Product_code_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_code_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Product_code_label.Location = new System.Drawing.Point(40, 68);
            this.Product_code_label.Name = "Product_code_label";
            this.Product_code_label.Size = new System.Drawing.Size(114, 18);
            this.Product_code_label.TabIndex = 8;
            this.Product_code_label.Text = "Product Code:";
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Barcode.Location = new System.Drawing.Point(371, 68);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(76, 18);
            this.Barcode.TabIndex = 14;
            this.Barcode.Text = "Barcode:";
            // 
            // Barcode_textBox1
            // 
            this.Barcode_textBox1.BackColor = System.Drawing.Color.LightGray;
            this.Barcode_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Barcode_textBox1.Location = new System.Drawing.Point(471, 65);
            this.Barcode_textBox1.Name = "Barcode_textBox1";
            this.Barcode_textBox1.Size = new System.Drawing.Size(141, 26);
            this.Barcode_textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(40, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Description:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Description_textBox1
            // 
            this.Description_textBox1.BackColor = System.Drawing.Color.LightGray;
            this.Description_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description_textBox1.Location = new System.Drawing.Point(177, 121);
            this.Description_textBox1.Name = "Description_textBox1";
            this.Description_textBox1.Size = new System.Drawing.Size(435, 26);
            this.Description_textBox1.TabIndex = 17;
            // 
            // Brand_comboBox1
            // 
            this.Brand_comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Brand_comboBox1.FormattingEnabled = true;
            this.Brand_comboBox1.Location = new System.Drawing.Point(177, 182);
            this.Brand_comboBox1.Name = "Brand_comboBox1";
            this.Brand_comboBox1.Size = new System.Drawing.Size(435, 28);
            this.Brand_comboBox1.TabIndex = 18;
            // 
            // Brand_label2
            // 
            this.Brand_label2.AutoSize = true;
            this.Brand_label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Brand_label2.Location = new System.Drawing.Point(40, 186);
            this.Brand_label2.Name = "Brand_label2";
            this.Brand_label2.Size = new System.Drawing.Size(55, 18);
            this.Brand_label2.TabIndex = 19;
            this.Brand_label2.Text = "Brand:";
            // 
            // Category_label2
            // 
            this.Category_label2.AutoSize = true;
            this.Category_label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Category_label2.Location = new System.Drawing.Point(40, 250);
            this.Category_label2.Name = "Category_label2";
            this.Category_label2.Size = new System.Drawing.Size(82, 18);
            this.Category_label2.TabIndex = 20;
            this.Category_label2.Text = "Category:";
            // 
            // Category_comboBox1
            // 
            this.Category_comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Category_comboBox1.FormattingEnabled = true;
            this.Category_comboBox1.Location = new System.Drawing.Point(177, 246);
            this.Category_comboBox1.Name = "Category_comboBox1";
            this.Category_comboBox1.Size = new System.Drawing.Size(435, 28);
            this.Category_comboBox1.TabIndex = 21;
            // 
            // Price_label2
            // 
            this.Price_label2.AutoSize = true;
            this.Price_label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Price_label2.Location = new System.Drawing.Point(46, 310);
            this.Price_label2.Name = "Price_label2";
            this.Price_label2.Size = new System.Drawing.Size(49, 18);
            this.Price_label2.TabIndex = 22;
            this.Price_label2.Text = "Price:";
            this.Price_label2.Click += new System.EventHandler(this.Price_label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(177, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 26);
            this.textBox1.TabIndex = 23;
            // 
            // ReOrder_label2
            // 
            this.ReOrder_label2.AutoSize = true;
            this.ReOrder_label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReOrder_label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReOrder_label2.Location = new System.Drawing.Point(365, 310);
            this.ReOrder_label2.Name = "ReOrder_label2";
            this.ReOrder_label2.Size = new System.Drawing.Size(80, 18);
            this.ReOrder_label2.TabIndex = 24;
            this.ReOrder_label2.Text = "Re-Order:";
            // 
            // ReOrder_numericUpDown1
            // 
            this.ReOrder_numericUpDown1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ReOrder_numericUpDown1.Location = new System.Drawing.Point(471, 307);
            this.ReOrder_numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ReOrder_numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ReOrder_numericUpDown1.Name = "ReOrder_numericUpDown1";
            this.ReOrder_numericUpDown1.Size = new System.Drawing.Size(141, 26);
            this.ReOrder_numericUpDown1.TabIndex = 25;
            this.ReOrder_numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 410);
            this.ControlBox = false;
            this.Controls.Add(this.ReOrder_numericUpDown1);
            this.Controls.Add(this.ReOrder_label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Price_label2);
            this.Controls.Add(this.Category_comboBox1);
            this.Controls.Add(this.Category_label2);
            this.Controls.Add(this.Brand_label2);
            this.Controls.Add(this.Brand_comboBox1);
            this.Controls.Add(this.Description_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Barcode_textBox1);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.Brand_mod_header);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.Products_cancel_btn);
            this.Controls.Add(this.Products_update_btn);
            this.Controls.Add(this.Products_save_btn);
            this.Controls.Add(this.Product_textBox1);
            this.Controls.Add(this.Product_code_label);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductsModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsModule";
            this.Brand_mod_header.ResumeLayout(false);
            this.Brand_mod_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReOrder_numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Brand_mod_header;
        private System.Windows.Forms.PictureBox Products_pictureBox1;
        private System.Windows.Forms.Label Products_mod_label;
        public System.Windows.Forms.Label id_label;
        public System.Windows.Forms.Button Products_cancel_btn;
        public System.Windows.Forms.Button Products_update_btn;
        public System.Windows.Forms.Button Products_save_btn;
        public System.Windows.Forms.TextBox Product_textBox1;
        private System.Windows.Forms.Label Product_code_label;
        private System.Windows.Forms.Label Barcode;
        public System.Windows.Forms.TextBox Barcode_textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Description_textBox1;
        private System.Windows.Forms.Label Brand_label2;
        private System.Windows.Forms.Label Category_label2;
        private System.Windows.Forms.Label Price_label2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ReOrder_label2;
        public System.Windows.Forms.ComboBox Brand_comboBox1;
        public System.Windows.Forms.ComboBox Category_comboBox1;
        public System.Windows.Forms.NumericUpDown ReOrder_numericUpDown1;
    }
}
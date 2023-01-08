namespace POS_Project
{
    partial class ProductStockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductStockIn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.products_footer_panel = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.txtSearch1 = new MetroFramework.Controls.MetroTextBox();
            this.produsts_add_btn = new System.Windows.Forms.Button();
            this.products_label1 = new System.Windows.Forms.Label();
            this.grid_products = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.products_footer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).BeginInit();
            this.SuspendLayout();
            // 
            // products_footer_panel
            // 
            this.products_footer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.products_footer_panel.Controls.Add(this.btn_close);
            this.products_footer_panel.Controls.Add(this.txtSearch1);
            this.products_footer_panel.Controls.Add(this.produsts_add_btn);
            this.products_footer_panel.Controls.Add(this.products_label1);
            this.products_footer_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.products_footer_panel.Location = new System.Drawing.Point(0, 503);
            this.products_footer_panel.Name = "products_footer_panel";
            this.products_footer_panel.Size = new System.Drawing.Size(716, 85);
            this.products_footer_panel.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.DarkRed;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Location = new System.Drawing.Point(613, 26);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(79, 31);
            this.btn_close.TabIndex = 34;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            this.txtSearch1.CustomButton.Location = new System.Drawing.Point(262, 1);
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
            this.txtSearch1.Location = new System.Drawing.Point(240, 26);
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
            this.txtSearch1.Size = new System.Drawing.Size(292, 31);
            this.txtSearch1.TabIndex = 2;
            this.txtSearch1.UseCustomBackColor = true;
            this.txtSearch1.UseSelectable = true;
            this.txtSearch1.WaterMark = "Search Here";
            this.txtSearch1.WaterMarkColor = System.Drawing.Color.White;
            this.txtSearch1.WaterMarkFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // produsts_add_btn
            // 
            this.produsts_add_btn.FlatAppearance.BorderSize = 0;
            this.produsts_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produsts_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("produsts_add_btn.Image")));
            this.produsts_add_btn.Location = new System.Drawing.Point(888, 3);
            this.produsts_add_btn.Name = "produsts_add_btn";
            this.produsts_add_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.produsts_add_btn.Size = new System.Drawing.Size(84, 75);
            this.produsts_add_btn.TabIndex = 1;
            this.produsts_add_btn.Text = " ";
            this.produsts_add_btn.UseVisualStyleBackColor = true;
            // 
            // products_label1
            // 
            this.products_label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.products_label1.Image = ((System.Drawing.Image)(resources.GetObject("products_label1.Image")));
            this.products_label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_label1.Location = new System.Drawing.Point(3, 5);
            this.products_label1.Name = "products_label1";
            this.products_label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.products_label1.Size = new System.Drawing.Size(206, 71);
            this.products_label1.TabIndex = 0;
            this.products_label1.Text = "Produc StockIn";
            this.products_label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grid_products
            // 
            this.grid_products.AllowUserToAddRows = false;
            this.grid_products.AllowUserToResizeColumns = false;
            this.grid_products.AllowUserToResizeRows = false;
            this.grid_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Pcode,
            this.Column4,
            this.Column8,
            this.Select});
            this.grid_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_products.EnableHeadersVisualStyles = false;
            this.grid_products.Location = new System.Drawing.Point(0, 0);
            this.grid_products.Name = "grid_products";
            this.grid_products.RowHeadersVisible = false;
            this.grid_products.Size = new System.Drawing.Size(716, 588);
            this.grid_products.TabIndex = 5;
            this.grid_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_products_CellContentClick);
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
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Qty";
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.Width = 5;
            // 
            // ProductStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 588);
            this.ControlBox = false;
            this.Controls.Add(this.products_footer_panel);
            this.Controls.Add(this.grid_products);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductStockIn";
            this.products_footer_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel products_footer_panel;
        private MetroFramework.Controls.MetroTextBox txtSearch1;
        private System.Windows.Forms.Button produsts_add_btn;
        private System.Windows.Forms.Label products_label1;
        private System.Windows.Forms.DataGridView grid_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        public System.Windows.Forms.Button btn_close;
    }
}
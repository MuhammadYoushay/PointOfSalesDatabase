namespace POS_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.Supplier_btn = new System.Windows.Forms.Button();
            this.inStock_subpanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StockEntry_btn = new System.Windows.Forms.Button();
            this.instock_btn = new System.Windows.Forms.Button();
            this.products_subpanel = new System.Windows.Forms.Panel();
            this.products_brand_btn = new System.Windows.Forms.Button();
            this.products_category_btn = new System.Windows.Forms.Button();
            this.product_lst_btn = new System.Windows.Forms.Button();
            this.Products_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.role = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.inStock_subpanel.SuspendLayout();
            this.products_subpanel.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.AutoScroll = true;
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.logout_btn);
            this.sidebar.Controls.Add(this.settings_btn);
            this.sidebar.Controls.Add(this.Supplier_btn);
            this.sidebar.Controls.Add(this.inStock_subpanel);
            this.sidebar.Controls.Add(this.instock_btn);
            this.sidebar.Controls.Add(this.products_subpanel);
            this.sidebar.Controls.Add(this.Products_btn);
            this.sidebar.Controls.Add(this.Dashboard_btn);
            this.sidebar.Controls.Add(this.logo);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 661);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // logout_btn
            // 
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_btn.Location = new System.Drawing.Point(0, 616);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.logout_btn.Size = new System.Drawing.Size(200, 45);
            this.logout_btn.TabIndex = 12;
            this.logout_btn.Text = "LogOut";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // settings_btn
            // 
            this.settings_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_btn.FlatAppearance.BorderSize = 0;
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings_btn.Location = new System.Drawing.Point(0, 505);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.settings_btn.Size = new System.Drawing.Size(200, 45);
            this.settings_btn.TabIndex = 10;
            this.settings_btn.Text = "Settings";
            this.settings_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Supplier_btn
            // 
            this.Supplier_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Supplier_btn.FlatAppearance.BorderSize = 0;
            this.Supplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supplier_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Supplier_btn.Location = new System.Drawing.Point(0, 460);
            this.Supplier_btn.Name = "Supplier_btn";
            this.Supplier_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Supplier_btn.Size = new System.Drawing.Size(200, 45);
            this.Supplier_btn.TabIndex = 7;
            this.Supplier_btn.Text = "Supplier";
            this.Supplier_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Supplier_btn.UseVisualStyleBackColor = true;
            this.Supplier_btn.Click += new System.EventHandler(this.Supplier_btn_Click);
            // 
            // inStock_subpanel
            // 
            this.inStock_subpanel.Controls.Add(this.button2);
            this.inStock_subpanel.Controls.Add(this.button1);
            this.inStock_subpanel.Controls.Add(this.StockEntry_btn);
            this.inStock_subpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inStock_subpanel.Location = new System.Drawing.Point(0, 422);
            this.inStock_subpanel.Name = "inStock_subpanel";
            this.inStock_subpanel.Size = new System.Drawing.Size(200, 38);
            this.inStock_subpanel.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 83);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Stock Entry";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 38);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Stock Entry";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StockEntry_btn
            // 
            this.StockEntry_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockEntry_btn.FlatAppearance.BorderSize = 0;
            this.StockEntry_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockEntry_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StockEntry_btn.Location = new System.Drawing.Point(0, 0);
            this.StockEntry_btn.Name = "StockEntry_btn";
            this.StockEntry_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.StockEntry_btn.Size = new System.Drawing.Size(200, 38);
            this.StockEntry_btn.TabIndex = 6;
            this.StockEntry_btn.Text = "Stock Entry";
            this.StockEntry_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StockEntry_btn.UseVisualStyleBackColor = true;
            this.StockEntry_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // instock_btn
            // 
            this.instock_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.instock_btn.FlatAppearance.BorderSize = 0;
            this.instock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instock_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instock_btn.Location = new System.Drawing.Point(0, 377);
            this.instock_btn.Name = "instock_btn";
            this.instock_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.instock_btn.Size = new System.Drawing.Size(200, 45);
            this.instock_btn.TabIndex = 5;
            this.instock_btn.Text = "Stock Adjustment";
            this.instock_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.instock_btn.UseVisualStyleBackColor = true;
            this.instock_btn.Click += new System.EventHandler(this.instock_btn_Click);
            // 
            // products_subpanel
            // 
            this.products_subpanel.Controls.Add(this.products_brand_btn);
            this.products_subpanel.Controls.Add(this.products_category_btn);
            this.products_subpanel.Controls.Add(this.product_lst_btn);
            this.products_subpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.products_subpanel.Location = new System.Drawing.Point(0, 242);
            this.products_subpanel.Name = "products_subpanel";
            this.products_subpanel.Size = new System.Drawing.Size(200, 135);
            this.products_subpanel.TabIndex = 4;
            // 
            // products_brand_btn
            // 
            this.products_brand_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.products_brand_btn.FlatAppearance.BorderSize = 0;
            this.products_brand_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_brand_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.products_brand_btn.Location = new System.Drawing.Point(0, 90);
            this.products_brand_btn.Name = "products_brand_btn";
            this.products_brand_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.products_brand_btn.Size = new System.Drawing.Size(200, 45);
            this.products_brand_btn.TabIndex = 6;
            this.products_brand_btn.Text = "Brands";
            this.products_brand_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.products_brand_btn.UseVisualStyleBackColor = true;
            this.products_brand_btn.Click += new System.EventHandler(this.products_brand_btn_Click);
            // 
            // products_category_btn
            // 
            this.products_category_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.products_category_btn.FlatAppearance.BorderSize = 0;
            this.products_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_category_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.products_category_btn.Location = new System.Drawing.Point(0, 45);
            this.products_category_btn.Name = "products_category_btn";
            this.products_category_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.products_category_btn.Size = new System.Drawing.Size(200, 45);
            this.products_category_btn.TabIndex = 5;
            this.products_category_btn.Text = "Category";
            this.products_category_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.products_category_btn.UseVisualStyleBackColor = true;
            this.products_category_btn.Click += new System.EventHandler(this.products_category_btn_Click);
            // 
            // product_lst_btn
            // 
            this.product_lst_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_lst_btn.FlatAppearance.BorderSize = 0;
            this.product_lst_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_lst_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product_lst_btn.Location = new System.Drawing.Point(0, 0);
            this.product_lst_btn.Name = "product_lst_btn";
            this.product_lst_btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.product_lst_btn.Size = new System.Drawing.Size(200, 45);
            this.product_lst_btn.TabIndex = 4;
            this.product_lst_btn.Text = "Products List";
            this.product_lst_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.product_lst_btn.UseVisualStyleBackColor = true;
            this.product_lst_btn.Click += new System.EventHandler(this.product_lst_btn_Click);
            // 
            // Products_btn
            // 
            this.Products_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Products_btn.FlatAppearance.BorderSize = 0;
            this.Products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Products_btn.Location = new System.Drawing.Point(0, 197);
            this.Products_btn.Name = "Products_btn";
            this.Products_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Products_btn.Size = new System.Drawing.Size(200, 45);
            this.Products_btn.TabIndex = 3;
            this.Products_btn.Text = "Products";
            this.Products_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Products_btn.UseVisualStyleBackColor = true;
            this.Products_btn.Click += new System.EventHandler(this.Products_btn_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard_btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboard_btn.Location = new System.Drawing.Point(0, 152);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Dashboard_btn.Size = new System.Drawing.Size(200, 45);
            this.Dashboard_btn.TabIndex = 2;
            this.Dashboard_btn.Text = "Dashboard";
            this.Dashboard_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // logo
            // 
            this.logo.Controls.Add(this.role);
            this.logo.Controls.Add(this.username);
            this.logo.Controls.Add(this.picture);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 152);
            this.logo.TabIndex = 1;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.role.Location = new System.Drawing.Point(35, 121);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(104, 20);
            this.role.TabIndex = 2;
            this.role.Text = "Administrator";
            this.role.Click += new System.EventHandler(this.role_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(47, 100);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(83, 20);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(39, 2);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 97);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // title
            // 
            this.title.Controls.Add(this.lbl_title);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(200, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(984, 40);
            this.title.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(349, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(47, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title";
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.LightGray;
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(200, 40);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(984, 621);
            this.main.TabIndex = 2;
            this.main.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 550);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sales";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.main);
            this.Controls.Add(this.title);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.inStock_subpanel.ResumeLayout(false);
            this.products_subpanel.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Panel inStock_subpanel;
        private System.Windows.Forms.Button StockEntry_btn;
        private System.Windows.Forms.Button instock_btn;
        private System.Windows.Forms.Panel products_subpanel;
        private System.Windows.Forms.Button products_brand_btn;
        private System.Windows.Forms.Button products_category_btn;
        private System.Windows.Forms.Button product_lst_btn;
        private System.Windows.Forms.Button Products_btn;
        private System.Windows.Forms.Button Supplier_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label username;
        private System.Windows.Forms.Button button3;
    }
}


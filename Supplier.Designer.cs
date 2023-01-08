namespace POS_Project
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.products_footer_panel = new System.Windows.Forms.Panel();
            this.suppliers_add_btn = new System.Windows.Forms.Button();
            this.suppliers_label1 = new System.Windows.Forms.Label();
            this.grid_suppliers = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.products_footer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // products_footer_panel
            // 
            this.products_footer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.products_footer_panel.Controls.Add(this.suppliers_add_btn);
            this.products_footer_panel.Controls.Add(this.suppliers_label1);
            this.products_footer_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.products_footer_panel.Location = new System.Drawing.Point(0, 476);
            this.products_footer_panel.Name = "products_footer_panel";
            this.products_footer_panel.Size = new System.Drawing.Size(984, 85);
            this.products_footer_panel.TabIndex = 4;
            // 
            // suppliers_add_btn
            // 
            this.suppliers_add_btn.FlatAppearance.BorderSize = 0;
            this.suppliers_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliers_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("suppliers_add_btn.Image")));
            this.suppliers_add_btn.Location = new System.Drawing.Point(888, 3);
            this.suppliers_add_btn.Name = "suppliers_add_btn";
            this.suppliers_add_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.suppliers_add_btn.Size = new System.Drawing.Size(84, 75);
            this.suppliers_add_btn.TabIndex = 1;
            this.suppliers_add_btn.Text = " ";
            this.suppliers_add_btn.UseVisualStyleBackColor = true;
            this.suppliers_add_btn.Click += new System.EventHandler(this.suppliers_add_btn_Click);
            // 
            // suppliers_label1
            // 
            this.suppliers_label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suppliers_label1.Image = ((System.Drawing.Image)(resources.GetObject("suppliers_label1.Image")));
            this.suppliers_label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliers_label1.Location = new System.Drawing.Point(12, 5);
            this.suppliers_label1.Name = "suppliers_label1";
            this.suppliers_label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.suppliers_label1.Size = new System.Drawing.Size(210, 71);
            this.suppliers_label1.TabIndex = 0;
            this.suppliers_label1.Text = "Suppliers Manager";
            this.suppliers_label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grid_suppliers
            // 
            this.grid_suppliers.AllowUserToAddRows = false;
            this.grid_suppliers.AllowUserToResizeColumns = false;
            this.grid_suppliers.AllowUserToResizeRows = false;
            this.grid_suppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_suppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column1,
            this.Pcode,
            this.Barcode,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Edit,
            this.Delete});
            this.grid_suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_suppliers.EnableHeadersVisualStyles = false;
            this.grid_suppliers.Location = new System.Drawing.Point(0, 0);
            this.grid_suppliers.Name = "grid_suppliers";
            this.grid_suppliers.RowHeadersVisible = false;
            this.grid_suppliers.Size = new System.Drawing.Size(984, 561);
            this.grid_suppliers.TabIndex = 5;
            this.grid_suppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_suppliers_CellContentClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 55;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Pcode
            // 
            this.Pcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pcode.HeaderText = "Supplier";
            this.Pcode.Name = "Pcode";
            this.Pcode.Width = 91;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barcode.HeaderText = "Address";
            this.Barcode.Name = "Barcode";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Contact Person";
            this.Column4.Name = "Column4";
            this.Column4.Width = 135;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            this.Column5.Width = 81;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.Width = 71;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.products_footer_panel);
            this.Controls.Add(this.grid_suppliers);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.products_footer_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_suppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel products_footer_panel;
        private System.Windows.Forms.Button suppliers_add_btn;
        private System.Windows.Forms.Label suppliers_label1;
        private System.Windows.Forms.DataGridView grid_suppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
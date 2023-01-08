namespace POS_Project
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.grid_category = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.category_footer_panel = new System.Windows.Forms.Panel();
            this.categoy_add_btn = new System.Windows.Forms.Button();
            this.Category_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).BeginInit();
            this.category_footer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_category
            // 
            this.grid_category.AllowUserToAddRows = false;
            this.grid_category.AllowUserToResizeColumns = false;
            this.grid_category.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            this.grid_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_category.EnableHeadersVisualStyles = false;
            this.grid_category.Location = new System.Drawing.Point(0, 0);
            this.grid_category.Name = "grid_category";
            this.grid_category.RowHeadersVisible = false;
            this.grid_category.Size = new System.Drawing.Size(941, 384);
            this.grid_category.TabIndex = 2;
            this.grid_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_category_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
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
            // category_footer_panel
            // 
            this.category_footer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.category_footer_panel.Controls.Add(this.categoy_add_btn);
            this.category_footer_panel.Controls.Add(this.Category_label);
            this.category_footer_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.category_footer_panel.Location = new System.Drawing.Point(0, 299);
            this.category_footer_panel.Name = "category_footer_panel";
            this.category_footer_panel.Size = new System.Drawing.Size(941, 85);
            this.category_footer_panel.TabIndex = 3;
            // 
            // categoy_add_btn
            // 
            this.categoy_add_btn.FlatAppearance.BorderSize = 0;
            this.categoy_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoy_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("categoy_add_btn.Image")));
            this.categoy_add_btn.Location = new System.Drawing.Point(846, 5);
            this.categoy_add_btn.Name = "categoy_add_btn";
            this.categoy_add_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoy_add_btn.Size = new System.Drawing.Size(84, 75);
            this.categoy_add_btn.TabIndex = 1;
            this.categoy_add_btn.Text = " ";
            this.categoy_add_btn.UseVisualStyleBackColor = true;
            this.categoy_add_btn.Click += new System.EventHandler(this.categoy_add_btn_Click);
            // 
            // Category_label
            // 
            this.Category_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Category_label.Image = ((System.Drawing.Image)(resources.GetObject("Category_label.Image")));
            this.Category_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Category_label.Location = new System.Drawing.Point(12, 5);
            this.Category_label.Name = "Category_label";
            this.Category_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Category_label.Size = new System.Drawing.Size(212, 71);
            this.Category_label.TabIndex = 0;
            this.Category_label.Text = "Category Manager";
            this.Category_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 384);
            this.ControlBox = false;
            this.Controls.Add(this.category_footer_panel);
            this.Controls.Add(this.grid_category);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).EndInit();
            this.category_footer_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_category;
        private System.Windows.Forms.Panel category_footer_panel;
        private System.Windows.Forms.Button categoy_add_btn;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
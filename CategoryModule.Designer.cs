namespace POS_Project
{
    partial class CategoryModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryModule));
            this.Brand_mod_header = new System.Windows.Forms.Panel();
            this.cat_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Category_mod_label = new System.Windows.Forms.Label();
            this.cat_id_label = new System.Windows.Forms.Label();
            this.cat_cancel_btn = new System.Windows.Forms.Button();
            this.cat_update_btn = new System.Windows.Forms.Button();
            this.cat_save_btn = new System.Windows.Forms.Button();
            this.cat_textBox1 = new System.Windows.Forms.TextBox();
            this.Category_name_label = new System.Windows.Forms.Label();
            this.Brand_mod_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cat_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Brand_mod_header
            // 
            this.Brand_mod_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.Brand_mod_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Brand_mod_header.Controls.Add(this.cat_pictureBox1);
            this.Brand_mod_header.Controls.Add(this.Category_mod_label);
            this.Brand_mod_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Brand_mod_header.Location = new System.Drawing.Point(0, 0);
            this.Brand_mod_header.Name = "Brand_mod_header";
            this.Brand_mod_header.Size = new System.Drawing.Size(534, 41);
            this.Brand_mod_header.TabIndex = 7;
            // 
            // cat_pictureBox1
            // 
            this.cat_pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cat_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cat_pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cat_pictureBox1.Image")));
            this.cat_pictureBox1.Location = new System.Drawing.Point(491, 6);
            this.cat_pictureBox1.Name = "cat_pictureBox1";
            this.cat_pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.cat_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cat_pictureBox1.TabIndex = 1;
            this.cat_pictureBox1.TabStop = false;
            this.cat_pictureBox1.Click += new System.EventHandler(this.cat_pictureBox1_Click);
            // 
            // Category_mod_label
            // 
            this.Category_mod_label.AutoSize = true;
            this.Category_mod_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_mod_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Category_mod_label.Location = new System.Drawing.Point(12, 9);
            this.Category_mod_label.Name = "Category_mod_label";
            this.Category_mod_label.Size = new System.Drawing.Size(139, 18);
            this.Category_mod_label.TabIndex = 0;
            this.Category_mod_label.Text = "Category Module";
            // 
            // cat_id_label
            // 
            this.cat_id_label.AutoSize = true;
            this.cat_id_label.Location = new System.Drawing.Point(23, 104);
            this.cat_id_label.Name = "cat_id_label";
            this.cat_id_label.Size = new System.Drawing.Size(25, 20);
            this.cat_id_label.TabIndex = 13;
            this.cat_id_label.Text = "ID";
            this.cat_id_label.Visible = false;
            // 
            // cat_cancel_btn
            // 
            this.cat_cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cat_cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cat_cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cat_cancel_btn.Location = new System.Drawing.Point(448, 104);
            this.cat_cancel_btn.Name = "cat_cancel_btn";
            this.cat_cancel_btn.Size = new System.Drawing.Size(79, 31);
            this.cat_cancel_btn.TabIndex = 12;
            this.cat_cancel_btn.Text = "Cancel";
            this.cat_cancel_btn.UseVisualStyleBackColor = false;
            this.cat_cancel_btn.Click += new System.EventHandler(this.cat_cancel_btn_Click);
            // 
            // cat_update_btn
            // 
            this.cat_update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cat_update_btn.BackColor = System.Drawing.Color.Olive;
            this.cat_update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cat_update_btn.Location = new System.Drawing.Point(362, 104);
            this.cat_update_btn.Name = "cat_update_btn";
            this.cat_update_btn.Size = new System.Drawing.Size(79, 31);
            this.cat_update_btn.TabIndex = 11;
            this.cat_update_btn.Text = "Update";
            this.cat_update_btn.UseVisualStyleBackColor = false;
            this.cat_update_btn.Click += new System.EventHandler(this.cat_update_btn_Click);
            // 
            // cat_save_btn
            // 
            this.cat_save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cat_save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.cat_save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cat_save_btn.Location = new System.Drawing.Point(274, 104);
            this.cat_save_btn.Name = "cat_save_btn";
            this.cat_save_btn.Size = new System.Drawing.Size(79, 31);
            this.cat_save_btn.TabIndex = 10;
            this.cat_save_btn.Text = "Save";
            this.cat_save_btn.UseVisualStyleBackColor = false;
            this.cat_save_btn.Click += new System.EventHandler(this.cat_save_btn_Click);
            // 
            // cat_textBox1
            // 
            this.cat_textBox1.BackColor = System.Drawing.Color.LightGray;
            this.cat_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cat_textBox1.Location = new System.Drawing.Point(131, 61);
            this.cat_textBox1.Name = "cat_textBox1";
            this.cat_textBox1.Size = new System.Drawing.Size(393, 26);
            this.cat_textBox1.TabIndex = 9;
            // 
            // Category_name_label
            // 
            this.Category_name_label.AutoSize = true;
            this.Category_name_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_name_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Category_name_label.Location = new System.Drawing.Point(1, 63);
            this.Category_name_label.Name = "Category_name_label";
            this.Category_name_label.Size = new System.Drawing.Size(131, 18);
            this.Category_name_label.TabIndex = 8;
            this.Category_name_label.Text = "Category Name:";
            // 
            // CategoryModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 142);
            this.ControlBox = false;
            this.Controls.Add(this.Brand_mod_header);
            this.Controls.Add(this.cat_id_label);
            this.Controls.Add(this.cat_cancel_btn);
            this.Controls.Add(this.cat_update_btn);
            this.Controls.Add(this.cat_save_btn);
            this.Controls.Add(this.cat_textBox1);
            this.Controls.Add(this.Category_name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryModule";
            this.Brand_mod_header.ResumeLayout(false);
            this.Brand_mod_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cat_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Brand_mod_header;
        private System.Windows.Forms.PictureBox cat_pictureBox1;
        private System.Windows.Forms.Label Category_mod_label;
        public System.Windows.Forms.Label cat_id_label;
        public System.Windows.Forms.Button cat_cancel_btn;
        public System.Windows.Forms.Button cat_update_btn;
        public System.Windows.Forms.Button cat_save_btn;
        public System.Windows.Forms.TextBox cat_textBox1;
        private System.Windows.Forms.Label Category_name_label;
    }
}
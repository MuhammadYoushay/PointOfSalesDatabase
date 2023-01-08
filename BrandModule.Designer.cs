namespace POS_Project
{
    partial class BrandModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandModule));
            this.Brand_mod_header = new System.Windows.Forms.Panel();
            this.Brand_mod_label = new System.Windows.Forms.Label();
            this.Brand_name_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_label = new System.Windows.Forms.Label();
            this.Brand_mod_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Brand_mod_header
            // 
            this.Brand_mod_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.Brand_mod_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Brand_mod_header.Controls.Add(this.pictureBox1);
            this.Brand_mod_header.Controls.Add(this.Brand_mod_label);
            this.Brand_mod_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Brand_mod_header.Location = new System.Drawing.Point(0, 0);
            this.Brand_mod_header.Name = "Brand_mod_header";
            this.Brand_mod_header.Size = new System.Drawing.Size(538, 41);
            this.Brand_mod_header.TabIndex = 0;
            // 
            // Brand_mod_label
            // 
            this.Brand_mod_label.AutoSize = true;
            this.Brand_mod_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_mod_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Brand_mod_label.Location = new System.Drawing.Point(12, 9);
            this.Brand_mod_label.Name = "Brand_mod_label";
            this.Brand_mod_label.Size = new System.Drawing.Size(112, 18);
            this.Brand_mod_label.TabIndex = 0;
            this.Brand_mod_label.Text = "Brand Module";
            // 
            // Brand_name_label
            // 
            this.Brand_name_label.AutoSize = true;
            this.Brand_name_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_name_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Brand_name_label.Location = new System.Drawing.Point(21, 77);
            this.Brand_name_label.Name = "Brand_name_label";
            this.Brand_name_label.Size = new System.Drawing.Size(104, 18);
            this.Brand_name_label.TabIndex = 1;
            this.Brand_name_label.Text = "Brand Name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(132, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 26);
            this.textBox1.TabIndex = 2;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(263, 118);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(79, 31);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_btn.BackColor = System.Drawing.Color.Olive;
            this.update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_btn.Location = new System.Drawing.Point(351, 118);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(79, 31);
            this.update_btn.TabIndex = 4;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(437, 118);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(79, 31);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(24, 118);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(25, 20);
            this.id_label.TabIndex = 6;
            this.id_label.Text = "ID";
            this.id_label.Visible = false;
            // 
            // BrandModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(538, 160);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Brand_name_label);
            this.Controls.Add(this.Brand_mod_header);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BrandModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandModule";
            this.Brand_mod_header.ResumeLayout(false);
            this.Brand_mod_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Brand_mod_header;
        private System.Windows.Forms.Label Brand_mod_label;
        private System.Windows.Forms.Label Brand_name_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button save_btn;
        public System.Windows.Forms.Button update_btn;
        public System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.Label id_label;
    }
}
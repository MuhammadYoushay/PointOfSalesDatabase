namespace POS_Project
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.products_footer_panel = new System.Windows.Forms.Panel();
            this.userSetting_label1 = new System.Windows.Forms.Label();
            this.ChangePassword = new MetroFramework.Controls.MetroTabPage();
            this.Chnage_Pass_Username = new System.Windows.Forms.Label();
            this.Current_Password = new System.Windows.Forms.Label();
            this.New_Password = new System.Windows.Forms.Label();
            this.currentPass_textBox2 = new System.Windows.Forms.TextBox();
            this.New_Pass_textBox1 = new System.Windows.Forms.TextBox();
            this.Retype_Pass_textBox4 = new System.Windows.Forms.TextBox();
            this.ReTypePas = new System.Windows.Forms.Label();
            this.Save_ChangePassbutton2 = new System.Windows.Forms.Button();
            this.Cancel_ChangePass_button1 = new System.Windows.Forms.Button();
            this.CreateAccount = new MetroFramework.Controls.MetroTabPage();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ReTypePassword = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.Username_textBox1 = new System.Windows.Forms.TextBox();
            this.Password_textBox2 = new System.Windows.Forms.TextBox();
            this.ReTypePass_textBox3 = new System.Windows.Forms.TextBox();
            this.Name_textBox4 = new System.Windows.Forms.TextBox();
            this.Role_comboBox1 = new System.Windows.Forms.ComboBox();
            this.UserAccount_save_btn = new System.Windows.Forms.Button();
            this.UserAccount_cancel_btn = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username_textBox3 = new System.Windows.Forms.TextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.grid_cashier_load = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dlt = new System.Windows.Forms.DataGridViewImageColumn();
            this.products_footer_panel.SuspendLayout();
            this.ChangePassword.SuspendLayout();
            this.CreateAccount.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cashier_load)).BeginInit();
            this.SuspendLayout();
            // 
            // products_footer_panel
            // 
            this.products_footer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.products_footer_panel.Controls.Add(this.userSetting_label1);
            this.products_footer_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.products_footer_panel.Location = new System.Drawing.Point(0, 476);
            this.products_footer_panel.Name = "products_footer_panel";
            this.products_footer_panel.Size = new System.Drawing.Size(984, 85);
            this.products_footer_panel.TabIndex = 3;
            // 
            // userSetting_label1
            // 
            this.userSetting_label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSetting_label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userSetting_label1.Image = ((System.Drawing.Image)(resources.GetObject("userSetting_label1.Image")));
            this.userSetting_label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userSetting_label1.Location = new System.Drawing.Point(60, 7);
            this.userSetting_label1.Name = "userSetting_label1";
            this.userSetting_label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userSetting_label1.Size = new System.Drawing.Size(187, 71);
            this.userSetting_label1.TabIndex = 0;
            this.userSetting_label1.Text = "Accounts Manager";
            this.userSetting_label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChangePassword
            // 
            this.ChangePassword.Controls.Add(this.Cancel_ChangePass_button1);
            this.ChangePassword.Controls.Add(this.Save_ChangePassbutton2);
            this.ChangePassword.Controls.Add(this.ReTypePas);
            this.ChangePassword.Controls.Add(this.Retype_Pass_textBox4);
            this.ChangePassword.Controls.Add(this.New_Pass_textBox1);
            this.ChangePassword.Controls.Add(this.currentPass_textBox2);
            this.ChangePassword.Controls.Add(this.username_textBox3);
            this.ChangePassword.Controls.Add(this.New_Password);
            this.ChangePassword.Controls.Add(this.Current_Password);
            this.ChangePassword.Controls.Add(this.Chnage_Pass_Username);
            this.ChangePassword.HorizontalScrollbarBarColor = true;
            this.ChangePassword.HorizontalScrollbarHighlightOnWheel = false;
            this.ChangePassword.HorizontalScrollbarSize = 0;
            this.ChangePassword.Location = new System.Drawing.Point(4, 38);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(853, 333);
            this.ChangePassword.TabIndex = 1;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.VerticalScrollbarBarColor = true;
            this.ChangePassword.VerticalScrollbarHighlightOnWheel = false;
            this.ChangePassword.VerticalScrollbarSize = 0;
            // 
            // Chnage_Pass_Username
            // 
            this.Chnage_Pass_Username.AutoEllipsis = true;
            this.Chnage_Pass_Username.AutoSize = true;
            this.Chnage_Pass_Username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Chnage_Pass_Username.Location = new System.Drawing.Point(49, 66);
            this.Chnage_Pass_Username.Name = "Chnage_Pass_Username";
            this.Chnage_Pass_Username.Size = new System.Drawing.Size(87, 20);
            this.Chnage_Pass_Username.TabIndex = 11;
            this.Chnage_Pass_Username.Text = "Username:";
            // 
            // Current_Password
            // 
            this.Current_Password.AutoEllipsis = true;
            this.Current_Password.AutoSize = true;
            this.Current_Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Current_Password.Location = new System.Drawing.Point(49, 109);
            this.Current_Password.Name = "Current_Password";
            this.Current_Password.Size = new System.Drawing.Size(142, 20);
            this.Current_Password.TabIndex = 12;
            this.Current_Password.Text = "Current Password:";
            // 
            // New_Password
            // 
            this.New_Password.AutoEllipsis = true;
            this.New_Password.AutoSize = true;
            this.New_Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.New_Password.Location = new System.Drawing.Point(49, 153);
            this.New_Password.Name = "New_Password";
            this.New_Password.Size = new System.Drawing.Size(122, 20);
            this.New_Password.TabIndex = 13;
            this.New_Password.Text = "New Password:";
            // 
            // currentPass_textBox2
            // 
            this.currentPass_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPass_textBox2.Location = new System.Drawing.Point(271, 106);
            this.currentPass_textBox2.Name = "currentPass_textBox2";
            this.currentPass_textBox2.Size = new System.Drawing.Size(565, 26);
            this.currentPass_textBox2.TabIndex = 15;
            // 
            // New_Pass_textBox1
            // 
            this.New_Pass_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.New_Pass_textBox1.Location = new System.Drawing.Point(271, 150);
            this.New_Pass_textBox1.Name = "New_Pass_textBox1";
            this.New_Pass_textBox1.Size = new System.Drawing.Size(565, 26);
            this.New_Pass_textBox1.TabIndex = 16;
            // 
            // Retype_Pass_textBox4
            // 
            this.Retype_Pass_textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Retype_Pass_textBox4.Location = new System.Drawing.Point(271, 196);
            this.Retype_Pass_textBox4.Name = "Retype_Pass_textBox4";
            this.Retype_Pass_textBox4.Size = new System.Drawing.Size(565, 26);
            this.Retype_Pass_textBox4.TabIndex = 17;
            // 
            // ReTypePas
            // 
            this.ReTypePas.AutoEllipsis = true;
            this.ReTypePas.AutoSize = true;
            this.ReTypePas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReTypePas.Location = new System.Drawing.Point(49, 199);
            this.ReTypePas.Name = "ReTypePas";
            this.ReTypePas.Size = new System.Drawing.Size(144, 20);
            this.ReTypePas.TabIndex = 18;
            this.ReTypePas.Text = "Re-Type Password:";
            this.ReTypePas.Click += new System.EventHandler(this.label2_Click);
            // 
            // Save_ChangePassbutton2
            // 
            this.Save_ChangePassbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_ChangePassbutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.Save_ChangePassbutton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_ChangePassbutton2.Location = new System.Drawing.Point(672, 256);
            this.Save_ChangePassbutton2.Name = "Save_ChangePassbutton2";
            this.Save_ChangePassbutton2.Size = new System.Drawing.Size(79, 31);
            this.Save_ChangePassbutton2.TabIndex = 34;
            this.Save_ChangePassbutton2.Text = "Save";
            this.Save_ChangePassbutton2.UseVisualStyleBackColor = false;
            // 
            // Cancel_ChangePass_button1
            // 
            this.Cancel_ChangePass_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_ChangePass_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cancel_ChangePass_button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_ChangePass_button1.Location = new System.Drawing.Point(757, 256);
            this.Cancel_ChangePass_button1.Name = "Cancel_ChangePass_button1";
            this.Cancel_ChangePass_button1.Size = new System.Drawing.Size(79, 31);
            this.Cancel_ChangePass_button1.TabIndex = 35;
            this.Cancel_ChangePass_button1.Text = "Cancel";
            this.Cancel_ChangePass_button1.UseVisualStyleBackColor = false;
            // 
            // CreateAccount
            // 
            this.CreateAccount.Controls.Add(this.UserAccount_cancel_btn);
            this.CreateAccount.Controls.Add(this.UserAccount_save_btn);
            this.CreateAccount.Controls.Add(this.Role_comboBox1);
            this.CreateAccount.Controls.Add(this.Name_textBox4);
            this.CreateAccount.Controls.Add(this.ReTypePass_textBox3);
            this.CreateAccount.Controls.Add(this.Password_textBox2);
            this.CreateAccount.Controls.Add(this.Username_textBox1);
            this.CreateAccount.Controls.Add(this.FullName);
            this.CreateAccount.Controls.Add(this.Role);
            this.CreateAccount.Controls.Add(this.ReTypePassword);
            this.CreateAccount.Controls.Add(this.Password);
            this.CreateAccount.Controls.Add(this.UserName);
            this.CreateAccount.HorizontalScrollbarBarColor = true;
            this.CreateAccount.HorizontalScrollbarHighlightOnWheel = false;
            this.CreateAccount.HorizontalScrollbarSize = 3;
            this.CreateAccount.Location = new System.Drawing.Point(4, 38);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(853, 333);
            this.CreateAccount.TabIndex = 0;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.VerticalScrollbarBarColor = true;
            this.CreateAccount.VerticalScrollbarHighlightOnWheel = false;
            this.CreateAccount.VerticalScrollbarSize = 3;
            // 
            // UserName
            // 
            this.UserName.AutoEllipsis = true;
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserName.Location = new System.Drawing.Point(41, 49);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(87, 20);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoEllipsis = true;
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password.Location = new System.Drawing.Point(41, 91);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(83, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // ReTypePassword
            // 
            this.ReTypePassword.AutoEllipsis = true;
            this.ReTypePassword.AutoSize = true;
            this.ReTypePassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReTypePassword.Location = new System.Drawing.Point(41, 135);
            this.ReTypePassword.Name = "ReTypePassword";
            this.ReTypePassword.Size = new System.Drawing.Size(144, 20);
            this.ReTypePassword.TabIndex = 4;
            this.ReTypePassword.Text = "Re-type Password:";
            // 
            // Role
            // 
            this.Role.AutoEllipsis = true;
            this.Role.AutoSize = true;
            this.Role.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Role.Location = new System.Drawing.Point(41, 177);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(45, 20);
            this.Role.TabIndex = 5;
            this.Role.Text = "Role:";
            // 
            // FullName
            // 
            this.FullName.AutoEllipsis = true;
            this.FullName.AutoSize = true;
            this.FullName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FullName.Location = new System.Drawing.Point(41, 221);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(83, 20);
            this.FullName.TabIndex = 7;
            this.FullName.Text = "Full Name:";
            // 
            // Username_textBox1
            // 
            this.Username_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username_textBox1.Location = new System.Drawing.Point(263, 49);
            this.Username_textBox1.Name = "Username_textBox1";
            this.Username_textBox1.Size = new System.Drawing.Size(565, 26);
            this.Username_textBox1.TabIndex = 8;
            // 
            // Password_textBox2
            // 
            this.Password_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_textBox2.Location = new System.Drawing.Point(263, 91);
            this.Password_textBox2.Name = "Password_textBox2";
            this.Password_textBox2.Size = new System.Drawing.Size(565, 26);
            this.Password_textBox2.TabIndex = 9;
            this.Password_textBox2.UseSystemPasswordChar = true;
            // 
            // ReTypePass_textBox3
            // 
            this.ReTypePass_textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReTypePass_textBox3.Location = new System.Drawing.Point(263, 135);
            this.ReTypePass_textBox3.Name = "ReTypePass_textBox3";
            this.ReTypePass_textBox3.Size = new System.Drawing.Size(565, 26);
            this.ReTypePass_textBox3.TabIndex = 10;
            this.ReTypePass_textBox3.UseSystemPasswordChar = true;
            // 
            // Name_textBox4
            // 
            this.Name_textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_textBox4.Location = new System.Drawing.Point(263, 221);
            this.Name_textBox4.Name = "Name_textBox4";
            this.Name_textBox4.Size = new System.Drawing.Size(565, 26);
            this.Name_textBox4.TabIndex = 11;
            // 
            // Role_comboBox1
            // 
            this.Role_comboBox1.FormattingEnabled = true;
            this.Role_comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Cashier"});
            this.Role_comboBox1.Location = new System.Drawing.Point(263, 177);
            this.Role_comboBox1.Name = "Role_comboBox1";
            this.Role_comboBox1.Size = new System.Drawing.Size(565, 28);
            this.Role_comboBox1.TabIndex = 12;
            // 
            // UserAccount_save_btn
            // 
            this.UserAccount_save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserAccount_save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.UserAccount_save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserAccount_save_btn.Location = new System.Drawing.Point(664, 267);
            this.UserAccount_save_btn.Name = "UserAccount_save_btn";
            this.UserAccount_save_btn.Size = new System.Drawing.Size(79, 31);
            this.UserAccount_save_btn.TabIndex = 32;
            this.UserAccount_save_btn.Text = "Save";
            this.UserAccount_save_btn.UseVisualStyleBackColor = false;
            this.UserAccount_save_btn.Click += new System.EventHandler(this.Supplier_save_btn_Click_1);
            // 
            // UserAccount_cancel_btn
            // 
            this.UserAccount_cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserAccount_cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserAccount_cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserAccount_cancel_btn.Location = new System.Drawing.Point(749, 267);
            this.UserAccount_cancel_btn.Name = "UserAccount_cancel_btn";
            this.UserAccount_cancel_btn.Size = new System.Drawing.Size(79, 31);
            this.UserAccount_cancel_btn.TabIndex = 33;
            this.UserAccount_cancel_btn.Text = "Cancel";
            this.UserAccount_cancel_btn.UseVisualStyleBackColor = false;
            this.UserAccount_cancel_btn.Click += new System.EventHandler(this.UserAccount_cancel_btn_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.CreateAccount);
            this.metroTabControl1.Controls.Add(this.ChangePassword);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(45, 21);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(861, 355);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.Name = "Delete";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Edit.Name = "Edit";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "IsActive";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Account Owners Name";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // username_textBox3
            // 
            this.username_textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_textBox3.Location = new System.Drawing.Point(271, 64);
            this.username_textBox3.Name = "username_textBox3";
            this.username_textBox3.Size = new System.Drawing.Size(565, 26);
            this.username_textBox3.TabIndex = 14;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.grid_cashier_load);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(853, 313);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Manage Cashier";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // grid_cashier_load
            // 
            this.grid_cashier_load.AllowUserToAddRows = false;
            this.grid_cashier_load.AllowUserToResizeColumns = false;
            this.grid_cashier_load.AllowUserToResizeRows = false;
            this.grid_cashier_load.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_cashier_load.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_cashier_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cashier_load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column8,
            this.Dlt});
            this.grid_cashier_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_cashier_load.EnableHeadersVisualStyles = false;
            this.grid_cashier_load.Location = new System.Drawing.Point(0, 0);
            this.grid_cashier_load.Name = "grid_cashier_load";
            this.grid_cashier_load.RowHeadersVisible = false;
            this.grid_cashier_load.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_cashier_load.Size = new System.Drawing.Size(853, 313);
            this.grid_cashier_load.TabIndex = 4;
            this.grid_cashier_load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_cashier_load_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Username";
            this.Column5.Name = "Column5";
            this.Column5.Width = 108;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Cashiers Name";
            this.Column8.Name = "Column8";
            // 
            // Dlt
            // 
            this.Dlt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dlt.HeaderText = "";
            this.Dlt.Image = ((System.Drawing.Image)(resources.GetObject("Dlt.Image")));
            this.Dlt.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Dlt.Name = "Dlt";
            this.Dlt.Width = 5;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.products_footer_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserAccount";
            this.Text = "UserAccount";
            this.products_footer_panel.ResumeLayout(false);
            this.ChangePassword.ResumeLayout(false);
            this.ChangePassword.PerformLayout();
            this.CreateAccount.ResumeLayout(false);
            this.CreateAccount.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cashier_load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel products_footer_panel;
        private System.Windows.Forms.Label userSetting_label1;
        private MetroFramework.Controls.MetroTabPage ChangePassword;
        public System.Windows.Forms.Button Cancel_ChangePass_button1;
        public System.Windows.Forms.Button Save_ChangePassbutton2;
        private System.Windows.Forms.Label ReTypePas;
        private System.Windows.Forms.TextBox Retype_Pass_textBox4;
        private System.Windows.Forms.TextBox New_Pass_textBox1;
        private System.Windows.Forms.TextBox currentPass_textBox2;
        private System.Windows.Forms.TextBox username_textBox3;
        private System.Windows.Forms.Label New_Password;
        private System.Windows.Forms.Label Current_Password;
        private System.Windows.Forms.Label Chnage_Pass_Username;
        private MetroFramework.Controls.MetroTabPage CreateAccount;
        public System.Windows.Forms.Button UserAccount_cancel_btn;
        public System.Windows.Forms.Button UserAccount_save_btn;
        private System.Windows.Forms.ComboBox Role_comboBox1;
        private System.Windows.Forms.TextBox Name_textBox4;
        private System.Windows.Forms.TextBox ReTypePass_textBox3;
        private System.Windows.Forms.TextBox Password_textBox2;
        private System.Windows.Forms.TextBox Username_textBox1;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label ReTypePassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView grid_cashier_load;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Dlt;
    }
}
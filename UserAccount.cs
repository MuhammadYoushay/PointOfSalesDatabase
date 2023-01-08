using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Project
{
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        Form1 form1;
        public UserAccount(Form1 mn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            form1 = mn;
            LoadCashier();
        }
        public void clear()
        {
            Name_textBox4.Clear();
            Username_textBox1.Clear();
            Password_textBox2.Clear();
            Role_comboBox1.Text = "";
            Name_textBox4.Focus();

        }
        public void LoadCashier()
        {
            int i = 0;
            grid_cashier_load.Rows.Clear();
            cm = new SqlCommand("SELECT username, name FROM tbUser where role like 'Cashier'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_cashier_load.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void Products_cancel_btn_Click(object sender, EventArgs e)
        {

        }

        private void Supplier_save_btn_Click(object sender, EventArgs e)
        {

        }

        private void Supplier_save_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(Password_textBox2.Text!= ReTypePass_textBox3.Text)
                {
                    MessageBox.Show("Passwords did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cn.Open();
                cm = new SqlCommand("Insert into tbUser(username,password,role,name) Values (@username,@password,@role,@name)",cn);
                cm.Parameters.AddWithValue("@username",Username_textBox1.Text);
                cm.Parameters.AddWithValue("@password",Password_textBox2.Text);
                cm.Parameters.AddWithValue("@role",Role_comboBox1.Text);
                cm.Parameters.AddWithValue("@name", Name_textBox4.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grid_brand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserAccount_cancel_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Save_ChangePassbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPass_textBox2.Text != form1._pass)
                {
                    MessageBox.Show("Current Password did not match!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (New_Pass_textBox1.Text != Retype_Pass_textBox4.Text)
                {
                    MessageBox.Show("New Passwords did not match!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("UPDATE tbUser SET password= '" + New_Pass_textBox1 + "' WHERE username='" + Chnage_Pass_Username.Text + "'");
                MessageBox.Show("Password has been successfully changed", "Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            Chnage_Pass_Username.Text = form1.username.Text;
        }

        private void Cancel_ChangePass_button1_Click(object sender, EventArgs e)
        {
            currentPass_textBox2.Clear();
            New_Pass_textBox1.Clear();
            Retype_Pass_textBox4.Clear();
        }

        private void grid_cashier_load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_cashier_load.Columns[e.ColumnIndex].Name;
            if (colName == "Dlt")
            {
                if (MessageBox.Show("Are you sure you want to delete this cashier from record?", "Delete Cashier Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbUser WHERE username LIKE '" + grid_cashier_load[0, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Cashier has been successfully deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            LoadCashier();
        }
    }
}

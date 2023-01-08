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
    public partial class SupplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        Supplier supplier;
        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            supplier = sp;
        }

        private void Products_cancel_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Products_pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            Suppier_name_textBox1.Clear();
            Supplier_Address_textBox1.Clear();
            Supplier_ContactPersonTextBox.Clear();
            Supplier_Phone_Number_Textbox.Clear();
            Supplier_Emial_TextBox.Clear();
            Supplier_save_btn.Enabled = true;
            Supplier_update_btn.Enabled = false;
            Suppier_name_textBox1.Focus(); 
        }

        private void Supplier_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Record?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Insert into tbSupplier (supplier,address,contactperson,phone,email) values (@supplier,@address,@contactperson,@phone,@email)", cn);
                    cm.Parameters.AddWithValue("@supplier", Suppier_name_textBox1.Text);
                    cm.Parameters.AddWithValue("@address", Supplier_Address_textBox1.Text);
                    cm.Parameters.AddWithValue("@contactperson", Supplier_ContactPersonTextBox.Text);
                    cm.Parameters.AddWithValue("@phone", Supplier_Phone_Number_Textbox.Text);
                    cm.Parameters.AddWithValue("@email", Supplier_Emial_TextBox.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    supplier.LoadSupplier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POS");
            }

        }

        private void Supplier_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Update this Record? Click Yes to confirm.", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Update tbSupplier set supplier=@supplier, address=@address, contactperson = @contactperson, phone = @phone, email=@email where id = @id",cn);
                    cm.Parameters.AddWithValue("@id", id_label.Text);
                    cm.Parameters.AddWithValue("@supplier", Suppier_name_textBox1.Text);
                    cm.Parameters.AddWithValue("@address", Supplier_Address_textBox1.Text);
                    cm.Parameters.AddWithValue("@contactperson", Supplier_ContactPersonTextBox.Text);
                    cm.Parameters.AddWithValue("@phone", Supplier_Phone_Number_Textbox.Text);
                    cm.Parameters.AddWithValue("@email", Supplier_Emial_TextBox.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully update!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}

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
    public partial class ProductsModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        Products product;
        public ProductsModule(Products pd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            product = pd;
            LoadCategory();
            LoadBrand();

        }

        public void LoadCategory()
        {
            Category_comboBox1.Items.Clear();
            Category_comboBox1.DataSource = dbcon.GetTable("SELECT * FROM tbCategory1");
            Category_comboBox1.DisplayMember = "category";
            Category_comboBox1.ValueMember = "id";
        }
        public void LoadBrand()
        {
            Brand_comboBox1.Items.Clear();
            Brand_comboBox1.DataSource = dbcon.GetTable("SELECT * FROM tbBrand");
            Brand_comboBox1.DisplayMember = "brand";
            Brand_comboBox1.ValueMember = "id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Price_label2_Click(object sender, EventArgs e)
        {

        }

        private void Products_pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            Product_textBox1.Clear();
            Barcode_textBox1.Clear();
            Description_textBox1.Clear();
            Brand_comboBox1.SelectedValue = 0;
            Category_comboBox1.SelectedValue = 0;
            ReOrder_numericUpDown1.Value = 1;
            Product_textBox1.Enabled = true;
            Product_textBox1.Focus();
            Products_save_btn.Enabled = true;
            Products_update_btn.Enabled = false;
        }

        private void Products_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pcode, barcode, pdesc, bid, cid, price, reorder)VALUES (@pcode,@barcode,@pdesc, @bid, @cid, @price, @reorder)", cn);
                    cm.Parameters.AddWithValue("@pcode", Product_textBox1.Text);
                    cm.Parameters.AddWithValue("@barcode",Barcode_textBox1.Text);
                    cm.Parameters.AddWithValue("@pdesc", Description_textBox1.Text);
                    cm.Parameters.AddWithValue("@bid", Brand_comboBox1.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", Category_comboBox1.SelectedValue);
                    cm.Parameters.AddWithValue("@price", textBox1.Text);
                    cm.Parameters.AddWithValue("@reorder", ReOrder_numericUpDown1.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully saved!", "POS");
                    Clear();
                    product.LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Products_cancel_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Products_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET barcode=@barcode,pdesc=@pdesc,bid=@bid,cid=@cid,price=@price,reorder=@reorder WHERE pcode LIKE @pcode", cn);
                    cm.Parameters.AddWithValue("@pcode", Product_textBox1.Text);
                    cm.Parameters.AddWithValue("@barcode", Barcode_textBox1.Text);
                    cm.Parameters.AddWithValue("@pdesc", Description_textBox1.Text);
                    cm.Parameters.AddWithValue("@bid", Brand_comboBox1.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", Category_comboBox1.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(textBox1.Text));
                    cm.Parameters.AddWithValue("@reorder", ReOrder_numericUpDown1.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully updated!", "POS");
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

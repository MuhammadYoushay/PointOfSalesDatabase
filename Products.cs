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
    public partial class Products : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public Products()
        {
            InitializeComponent();
                    cn = new SqlConnection(dbcon.myConnection());
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            grid_products.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder FROM tbProduct AS p INNER JOIN  tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory1 AS c on c.id = p.cid WHERE CONCAT(p.pdesc,b.brand, c.category) LIKE '%" + txtSearch1.Text + "%'",cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_products.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();


        }

        private void produsts_add_btn_Click(object sender, EventArgs e)
        {
            ProductsModule productModule = new ProductsModule(this);
            productModule.ShowDialog();
        }

        private void grid_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_products.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                ProductsModule product = new ProductsModule(this);
                product.Product_textBox1.Text = grid_products.Rows [e.RowIndex].Cells[1].Value.ToString();
                product.Barcode_textBox1.Text = grid_products.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.Description_textBox1.Text = grid_products.Rows [e.RowIndex].Cells[3].Value.ToString();
                product.Brand_comboBox1.Text = grid_products.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.Category_comboBox1.Text = grid_products.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.textBox1.Text = grid_products.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.ReOrder_numericUpDown1.Value = int.Parse(grid_products.Rows[e.RowIndex].Cells[7].Value.ToString());

                product.Product_textBox1.Enabled = false;
                product.Products_save_btn.Enabled = false;
                product.Products_update_btn.Enabled = true;
                product.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pcode LIKE '" + grid_products[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            LoadProduct();
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void products_footer_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch1_Click(object sender, EventArgs e)
        {

        }

        private void products_label1_Click(object sender, EventArgs e)
        {

        }
    }
}

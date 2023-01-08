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
    public partial class ProductStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        StockEntry stockIn;
        public ProductStockIn(StockEntry stock)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            stockIn = stock;
            LoadProduct();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadProduct()
        {
            int i = 0;
            grid_products.Rows.Clear();
            cm = new SqlCommand("SELECT pcode, pdesc, qty FROM tbProduct WHERE pdesc LIKE '%" + txtSearch1.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_products.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void grid_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_products.Columns[e.ColumnIndex].Name;
            if(colName == "Select")
            {
                if(stockIn.textBox2.Text == String.Empty)
                {
                    MessageBox.Show("Please enter the stock-in-by name", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockIn.textBox2.Focus();
                    this.Dispose();
   
                }
                if (MessageBox.Show("Add this Item?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbStockIn(refno, pcode, sdate, stockinby, supplierid) VALUES (@refno, @pcode, @sdate, @stockinby, @supplierid)", cn);
                        cm.Parameters.AddWithValue("@refno", stockIn.textBox1.Text);
                        cm.Parameters.AddWithValue("@pcode", grid_products.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@sdate", stockIn.dateTimePicker1.Value);
                        cm.Parameters.AddWithValue("@stockinby", stockIn.textBox2.Text);
                        cm.Parameters.AddWithValue("@supplierid",stockIn.lblid.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        stockIn.LoadStockIn();
                        MessageBox.Show("Successfully added", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "POS");
                    }
                }
            }

        }
    }
}

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
    public partial class SearchProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        string stitle = "POS";
        Cashier cashier;
        public SearchProduct(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadProduct();
            cashier = cash;
            LoadProduct();
        }

        private void UserAccount_save_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadProduct()
        {
            int i = 0;
            grid_products.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tbProduct AS p INNER JOIN  tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory1 AS c on c.id = p.cid WHERE CONCAT(p.pdesc,b.brand, c.category) LIKE '%" + txtSearch1.Text + "%'", cn);
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

        private void grid_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_products.Columns[e.ColumnIndex].Name;
            if((colName == "Select") && (grid_products.Rows[e.RowIndex].Cells[7].Value.ToString() != "0"))
            {
                Qty qty = new Qty(cashier);
                qty.productDetails(grid_products.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(grid_products.Rows[e.RowIndex].Cells[6].Value.ToString()),cashier.label4.Text, int.Parse(grid_products.Rows[e.RowIndex].Cells[7].Value.ToString()));
                qty.ShowDialog();

            }
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}

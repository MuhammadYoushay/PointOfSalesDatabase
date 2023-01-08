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
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;

        public Brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            load_brand();

        }
        public void load_brand()
        {
            int i = 0;
            grid_brand.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbBrand ORDER BY brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_brand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrandModule moduleform = new BrandModule(this);
            moduleform.ShowDialog();
        }

        private void Brand_Load(object sender, EventArgs e)
        {

        }

        private void grid_brand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_brand.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbBrand WHERE id LIKE '" + grid_brand[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (colName == "Edit")
            {
                BrandModule brandModule = new BrandModule(this);
                brandModule.id_label.Text = grid_brand[1, e.RowIndex].Value.ToString();
                brandModule.textBox1.Text = grid_brand[2, e.RowIndex].Value.ToString();
                brandModule.save_btn.Enabled = false;
                brandModule.update_btn.Enabled = true;
                brandModule.ShowDialog();
            }
            load_brand();
        }
    }
}
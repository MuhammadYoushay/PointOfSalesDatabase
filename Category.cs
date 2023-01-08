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
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            load_Category();
        }
        public void load_Category()
        {
            int i = 0;
            grid_category.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbCategory1 ORDER BY category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_category.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void categoy_add_btn_Click(object sender, EventArgs e)
        {
            CategoryModule moduleform = new CategoryModule(this);
            moduleform.ShowDialog();
        }

        private void grid_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_category.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory1 WHERE id LIKE '" + grid_category[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (colName == "Edit")
            {
                CategoryModule categoryModule = new CategoryModule(this);
                categoryModule.cat_id_label.Text = grid_category[1, e.RowIndex].Value.ToString();
                categoryModule.cat_textBox1.Text = grid_category[2, e.RowIndex].Value.ToString();
                categoryModule.cat_save_btn.Enabled = false;
                categoryModule.cat_update_btn.Enabled = true;
                categoryModule.ShowDialog();
            }
            load_Category();
        }
    }
}

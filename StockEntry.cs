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
    public partial class StockEntry : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        StockEntry stockIn;
        public StockEntry()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
            getrefno();
        }
        public void getrefno()
        {
            Random rnd = new Random();
            textBox1.Clear();
            textBox1.Text += rnd.Next();
        }
        public void LoadSupplier()
        {
            comboBox1.Items.Clear();
            comboBox1.DataSource = dbcon.GetTable("SELECT * FROM tbSupplier");
            comboBox1.DisplayMember = "supplier";
        }

        public void LoadStockIn()
        {
            int i = 0;
            grid_products.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE refno LIKE '" + textBox1.Text + "' AND status LIKE 'pending'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_products.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier WHERE supplier LIKE '" + comboBox1.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblid.Text = dr["id"].ToString();
                textBox3.Text = dr["contactperson"].ToString();
                textBox4.Text = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void linkGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getrefno();
        }

        private void grid_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_products.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if(MessageBox.Show("Remove this item?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbStockIn WHERE id='" + grid_products.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully removed", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStock = new ProductStockIn(this);
            productStock.ShowDialog();
        }

        //private void btn_entry_Click1(object sender, EventArgs e)
        //{
            

        //}
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value=DateTime.Now;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                grid_stkrecord.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM vwStockIn WHERE CAST(sdate as date) BETWEEN '" + dateTimePicker2.Value.ToShortDateString() + "' AND '" + dateTimePicker1.Value.ToShortDateString() + "'AND status LIKE 'Done'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    grid_stkrecord.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_entry_Click1_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid_products.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this record?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < grid_products.Rows.Count; i++)
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbProduct SET qty = qty + " + int.Parse(grid_products.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE '" + grid_products.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            cn.Open();
                            cm = new SqlCommand("UPDATE tbStockIn SET qty = qty + " + int.Parse(grid_products.Rows[i].Cells[5].Value.ToString()) + ", status='Done' WHERE id LIKE '" + grid_products.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        clear();
                        LoadStockIn();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

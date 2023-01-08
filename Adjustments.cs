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
    public partial class Adjustments : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        int _qty;
        public Adjustments()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            ReferenceNo();
            LoadStock();

        }
        public void ReferenceNo()
        {
            Random rnd = new Random();
            label4.Text = rnd.Next().ToString();
        }
        public void LoadStock()
        {
            int i = 0;
            grid_stkadj.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tbProduct AS p INNER JOIN  tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory1 AS c on c.id = p.cid WHERE CONCAT(p.pdesc,b.brand, c.category) LIKE '%" + txtSearch1.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_stkadj.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void Brand_mod_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void products_label1_Click(object sender, EventArgs e)
        {

        }

        private void grid_stkadj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_stkadj.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                label6.Text = grid_stkadj.Rows[e.RowIndex].Cells[1].Value.ToString();
                label5.Text = grid_stkadj.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + grid_stkadj.Rows[e.RowIndex].Cells[4].Value.ToString() + " " + grid_stkadj.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(grid_stkadj.Rows[e.RowIndex].Cells[7].Value.ToString());
                btn_save.Enabled = true;

            }
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please select an action that you need to perform", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Focus();
                    return;
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please fill the quantity field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Kindly Enter a reason for Stock Adjustment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
                if(comboBox1.Text=="Remove From Inventory")
                {
                    if (int.Parse(textBox1.Text) > _qty)
                    {
                        MessageBox.Show("Stock Available should be greater than the Adjustment you want to make", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tbProduct SET qty = (qty - " + int.Parse(textBox1.Text) + ") WHERE pcode LIKE '" + label6.Text + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Stock has been Successfully Updated", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStock();
                    }
                }
                else if(comboBox1.Text == "Add To Inventory")
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbProduct SET qty = (qty + " + int.Parse(textBox1.Text) + ") WHERE pcode LIKE '" + label6.Text + "'",cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Stock has been Successfully Updated", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStock();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cat_pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

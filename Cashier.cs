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
    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        //Qty qty;
        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            getTransNo();
        }

        public void slide(Button button)
        {
            panelslide.BackColor = Color.White;
            panelslide.Height = 44;
            panelslide.Top= button.Top;
        }
        public void loadCart()
        {
            int i = 0;
            double total = 0;
            double discount = 0;
            grid_cashier.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT c.id,c.pcode,p.pdesc,c.price,c.qty,c.disc,c.total FROM tbCart AS c INNER JOIN tbProduct AS p ON c.pcode=p.pcode WHERE c.transno LIKE @transno and c.status LIKE 'pending'", cn);
            cm.Parameters.AddWithValue("@transno", label4.Text);
            dr=cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                total += Convert.ToDouble(dr["total"].ToString());
                discount += Convert.ToDouble(dr["disc"].ToString());
                grid_cashier.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
            }
            dr.Close();
            cn.Close();
            label12.Text = total.ToString("#,##0.00");
            GetCartTotal();

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Products_pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            slide(button2);
            SearchProduct searchProduct = new SearchProduct(this);
            searchProduct.LoadProduct();
            searchProduct.ShowDialog();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    slide(button1);
        //    getTransNo();
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            slide(button5);
            if(grid_cashier.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout! Please cancel the Transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBox.Show("logOut Application?","Logout",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }    

        }

        public void GetCartTotal()
        {
            double sales = double.Parse(label12.Text);
            double vat = sales * 0.13;
            double vatable = sales - vat;
            label14.Text = vat.ToString("#,##0.00");
            label15.Text = vatable.ToString("#,##0.00");
            label2.Text = sales.ToString("#,##0.00");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        public void getTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCart where transno LIKE '" + sdate + "%' ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    label4.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    label4.Text = transno;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message,"POS");
            }
            label6.Text = DateTime.Now.ToString();

        }

        private void grid_cashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_cashier.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if(MessageBox.Show("Remove this item","Remove Item",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE from tbCart where id like'" + grid_cashier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    loadCart();
                }
            }
            else if (colName == "colAdd")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM(qty) as qty FROM tbProduct WHERE pcode LIKE'" + grid_cashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "' GROUP BY pcode", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
                if (int.Parse(grid_cashier.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbCart SET qty=qty + " + 1 + "WHERE transno LIKE '" + label4.Text + "' AND pcode LIKE '" + grid_cashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "'",cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    loadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + i + "!", "Out of Stock!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }   
            }
            else if(colName == "collReduce")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM(qty) as qty FROM tbProduct WHERE pcode LIKE'" + grid_cashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "' GROUP BY pcode", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
                if (i > 1)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbCart SET qty=qty - 1 WHERE transno LIKE '" + label4.Text + "' AND pcode LIKE '" + grid_cashier.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    loadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on hand is " + i + "!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            for(int i =0; i < grid_cashier.Rows.Count; i++)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbProduct SET qty = qty - " + int.Parse(grid_cashier.Rows[i].Cells[5].Value.ToString()) + "WHERE pcode= '" + grid_cashier.Rows[i].Cells[2].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                cn.Open();
                cm = new SqlCommand("UPDATE tbCart SET status = 'Sold' WHERE id= '" + grid_cashier.Rows[i].Cells[1].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            MessageBox.Show("Payment Successfully Saved!","Payment",MessageBoxButtons.OK, MessageBoxIcon.Information);
            getTransNo();
            loadCart();
        }
    }
}

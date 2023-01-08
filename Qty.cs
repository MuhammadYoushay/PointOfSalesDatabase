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
    public partial class Qty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        private string pcode;
        private double price;
        private int qty;
        private String transno;
        Cashier cashier;
        public Qty(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cashier = cash;
        }
        public void productDetails(string pcode, double price, string transno, int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void textQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar == 13) && (textQty.Text != string.Empty))
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbCart(transno,pcode,price,qty,sdate,cashier)VALUES(@transno,@pcode,@price,@qty,@sdate,@cashier)",cn);
                cm.Parameters.AddWithValue("@transno",transno);
                cm.Parameters.AddWithValue("@pcode", pcode);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@qty", int.Parse(textQty.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashier", cashier.label1.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                cashier.loadCart();
                this.Dispose();

            }
        }
    }
}

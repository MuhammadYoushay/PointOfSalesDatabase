using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Project
{
    public partial class DailySale : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        Category category;
        SqlDataReader dr;
        public DailySale()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void DailySale_Load(object sender, EventArgs e)
        {

        }

        private void Sales_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadSold()
        {
            int i = 0;
            grid_sales.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT c.id,c.transno,c.pcode, p.pdesc, c.price, c.qty, c.disc,c.total from tbCart as c inner join tbProduct as p on c.pcode = p.pcode where status like 'Sold' and sdate between '" + dateTimePicker2.Value + "' and '" + dateTimePicker1.Value + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_sales.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadSold(); 
        }
    }
}

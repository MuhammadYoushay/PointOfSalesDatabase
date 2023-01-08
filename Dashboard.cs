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
    public partial class Dashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        DBconnect dbcon = new DBconnect();
        public Dashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string sdate = DateTime.Now.ToShortDateString();
            label3.Text = dbcon.ExtractData("SELECT ISNULL (SUM(total),0) AS total FROM tbCart WHERE status LIKE 'Sold' AND sdate BETWEEN'"+sdate+"' AND '" + sdate + "'").ToString("#,##0.00");
            label7.Text = dbcon.ExtractData("SELECT COUNT(*) FROM tbProduct").ToString("#,##0");
            label4.Text = dbcon.ExtractData("SELECT ISNULL (SUM(qty),0) AS qty FROM tbProduct").ToString("#,##0");

        }
    }
}

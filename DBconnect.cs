using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Project
{
    class DBconnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;
        public string myConnection()
        {
            con = @"Data Source=YOUSHAY\MSSQLSERVERHABIB;Initial Catalog=POS_DB_SQL;Integrated Security=True";
            return con;
        }
        public DataTable GetTable(string qury)
        {
            cn.ConnectionString = myConnection();
            cm = new SqlCommand(qury,cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public double ExtractData(string sql)
        {
            cn = new SqlConnection();
            cn.ConnectionString=myConnection();
            cn.Open();
            cm = new SqlCommand(sql,cn);
            double data = double.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return data;

        }
    }
}

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
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public string _pass = "";
        public bool _isactive;
        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            metroTextBox1.Focus();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserAccount_save_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Exit Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _username = "", _name = "", _role = "";
            try
            {
                bool found;
                cn.Open();
                cm = new SqlCommand("SELECT * from tbUser where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", metroTextBox1.Text);
                cm.Parameters.AddWithValue("@password", metroTextBox2.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    _pass = dr["password"].ToString();
                    _isactive = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();
                if (found)
                {
                    if (!_isactive)
                    {
                        MessageBox.Show("Account is inactive. Unable to login","Inactive Account",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;

                    }
                    if (_role == "Cashier")
                    {
                        MessageBox.Show("Welcome "+_name + "|", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroTextBox1.Clear();
                        metroTextBox2.Clear();
                        this.Hide();
                        Cashier cashier = new Cashier();
                        cashier.label1.Text = _username;
                        cashier.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + "|", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroTextBox1.Clear();
                        metroTextBox2.Clear();
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.username.Text = _username;
                        form1._pass = _pass;
                        form1.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password","Access Denied",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cat_pictureBox1_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Exit Application?","Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

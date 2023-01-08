using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_Project
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        public string _pass;
        public Form1()
        {
            InitializeComponent();
            customize_design();
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
            openChildForm(new Dashboard());
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lbl_title.Text = childForm.Text;
            main.Controls.Add(childForm);
            main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void customize_design()
        {
            products_subpanel.Visible = false;
        }
        private void hide_submenus()
        {
            if (products_subpanel.Visible == true)
            {
                products_subpanel.Visible  = false;
            }
        }
        private void show_submenus(Panel submenus)
        {
            if (submenus.Visible == false)
            {
                hide_submenus();
                submenus.Visible = true;
            }
            else
            {
                submenus.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        //This button is referring to stock_entry button
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new StockEntry());
            //hide_submenus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void role_Click(object sender, EventArgs e)
        {

        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Products_btn_Click(object sender, EventArgs e)
        {
            show_submenus(products_subpanel);
        }

        private void product_lst_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Products());
            hide_submenus();
        }

        private void products_category_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
            hide_submenus();
        }

        private void products_brand_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
            hide_submenus();
        }

        private void instock_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Adjustments());
        }


        private void Supplier_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            hide_submenus();  
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new UserAccount(this));
        }


        private void logout_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Logout Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
             
            }
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
            hide_submenus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new DailySale());
            hide_submenus();
        }
    }
}

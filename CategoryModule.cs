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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_Project
{
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        Category category;
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            category = ct;
        }
        public void Clear()
        {
            cat_textBox1.Clear();
            cat_update_btn.Enabled = false;
            cat_save_btn.Enabled = true;
            cat_textBox1.Focus();
        }

        private void cat_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCategory1(category)VALUES(@category)", cn);
                    cm.Parameters.AddWithValue("@category", cat_textBox1.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved!", "POS");
                    Clear();
                }
                category.load_Category();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cat_cancel_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cat_update_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this brand?", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbCategory1 SET category = @category WHERE id LIKE '" + cat_id_label.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", cat_textBox1.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Category has been successfully updated.", "POS");
                Clear();
                this.Dispose();
            }
        }

        private void cat_pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

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
    public partial class Supplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnect dbcon = new DBconnect();
        SqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
        }
        public void LoadSupplier()
        {
            grid_suppliers.Rows.Clear();
            int i = 0;
            cn.Open();
            cm=new SqlCommand("SELECT * FROM tbSupplier",cn);
            dr=cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                grid_suppliers.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());

            }
            dr.Close();
            cn.Close();

        }

        private void suppliers_add_btn_Click(object sender, EventArgs e)
        {
            SupplierModule supplierModule = new SupplierModule(this);
            supplierModule.ShowDialog();
        }

        private void grid_suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = grid_suppliers.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                SupplierModule supplierModule = new SupplierModule(this);
                supplierModule.id_label.Text = grid_suppliers.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplierModule.Suppier_name_textBox1.Text = grid_suppliers.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplierModule.Supplier_Address_textBox1.Text = grid_suppliers.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplierModule.Supplier_ContactPersonTextBox.Text = grid_suppliers.Rows[e.RowIndex].Cells[4].Value.ToString();
                supplierModule.Supplier_Phone_Number_Textbox.Text = grid_suppliers.Rows[e.RowIndex].Cells[5].Value.ToString();
                supplierModule.Supplier_Emial_TextBox.Text = grid_suppliers.Rows[e.RowIndex].Cells[6].Value.ToString();

                supplierModule.Supplier_save_btn.Enabled = false;
                supplierModule.Supplier_update_btn.Enabled = true;
                supplierModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbSupplier WHERE id LIKE '" + grid_suppliers.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            LoadSupplier();
        }
    }
}

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

namespace SalesManagement
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            SqlConnection connString = new SqlConnection(@"Data Source=MINHTHU\SQLEXPRESS03;Initial Catalog=FoodCompany;Integrated Security=True");
            connString.Open();
            String sSQL = "SELECT * FROM Product";
            SqlCommand CMD = new SqlCommand(sSQL, connString);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            da.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                dataGridView2.DataSource = DT;
            }
            else
            {
                MessageBox.Show("No data");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtProductID.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtProductName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txtQuantity.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtPrice.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

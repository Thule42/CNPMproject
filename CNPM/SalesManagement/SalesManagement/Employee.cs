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
    public partial class Employee : Form
    {
        private List<Employee> Profression { get; set; }
        public Employee()
        {
            InitializeComponent();
        }


        private void Employee_Load(object sender, EventArgs e)
        {
            SqlConnection connString = new SqlConnection(@"Data Source=MINHTHU\SQLEXPRESS03;Initial Catalog=FoodCompany;Integrated Security=True");
            connString.Open();
            String sSQL = "SELECT * FROM Employee";
            SqlCommand CMD = new SqlCommand(sSQL, connString);
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            da.Fill(DT);
            if (DT.Rows.Count > 0)
            {
                dataGridView1.DataSource = DT;
            }
            else
            {
                MessageBox.Show("No data");
            }
        }
            private void txtEmployID_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtEmployID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtEmployName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtBirthDate.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtGender.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtEmployAddress.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtCMNN.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product addProduct = new Product();
            addProduct.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

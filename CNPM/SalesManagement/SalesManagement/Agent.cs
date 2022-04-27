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

namespace SalesManagement
{
    public partial class Agent : Form
    {
        SqlConnection connString = new SqlConnection(@"Data Source=MINHTHU\SQLEXPRESS03;Initial Catalog=FoodCompany;Integrated Security=True");
        
        public Agent()
        {
            InitializeComponent();
        }
        private void Agent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodCompanyDataSet3.Export' table. You can move, or remove it, as needed.
            this.exportTableAdapter.Fill(this.foodCompanyDataSet3.Export);
            // TODO: This line of code loads data into the 'foodCompanyDataSet3.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.foodCompanyDataSet3.Agent);
            SqlConnection connString = new SqlConnection(@"Data Source=MINHTHU\SQLEXPRESS03;Initial Catalog=FoodCompany;Integrated Security=True");
            connString.Open();
            String sSQL = "SELECT * FROM Agent";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

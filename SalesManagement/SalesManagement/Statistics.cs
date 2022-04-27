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
    public partial class Statistics : Form
    {
        SqlConnection connString = new SqlConnection(@"Data Source=MINHTHU\SQLEXPRESS03;Initial Catalog=FoodCompany;Integrated Security=True");
        public Statistics()
        {
            InitializeComponent();
        }

        private void btxImport_Click(object sender, EventArgs e)
        {
            connString.Open();
            String sSQL = "SELECT * FROM Import";
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
            connString.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            connString.Open();
            String sSQL = "SELECT * FROM Export";
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
            connString.Close();
        }

        private void btxRevenue_Click(object sender, EventArgs e)
        {
          
        }
    }
}

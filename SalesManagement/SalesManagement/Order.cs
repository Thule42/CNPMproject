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
    public partial class Order : Form
    {
        SqlConnection connString = new SqlConnection(@"Data Source = MINHTHU\SQLEXPRESS03; Initial Catalog = FoodCompany; Integrated Security = True");
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodCompanyDataSet5.Agent' table. You can move, or remove it, as needed.
            this.agentTableAdapter.Fill(this.foodCompanyDataSet5.Agent);
            // TODO: This line of code loads data into the 'foodCompanyDataSet5.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.foodCompanyDataSet5.Product);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvOrder.Rows.Add(txtOrderID.Text,txtExportID.Text,comboBox_ID.Text,txtProductName.Text,txtOrderQuantity.Text,txtPrice.Text,txtTotal.Text,comboBoxAgent.Text,txtAddress.Text);


            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                {
                    double quantity = Convert.ToDouble(dgvOrder.Rows[i].Cells[4].Value);
                    double price = Convert.ToDouble(dgvOrder.Rows[i].Cells[5].Value);
                    dgvOrder.Rows[i].Cells[6].Value = Convert.ToString(quantity * price);
                }
            }
            double sum = 0;
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                double totalPrice = Convert.ToDouble(dgvOrder.Rows[i].Cells[6].Value);
                sum += totalPrice;
                txtTotal.Text = sum.ToString();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                dgvOrder.Rows.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOrderID.ToString() == "")
            {
                MessageBox.Show("Enter ID Order", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //add datagridview to sql           


                for (int i = 0; i < dgvOrder.Rows.Count; i++)
                {
                   
                    connString.Open();
                    String sSQL2 = "insert into OrderSP(OrderID,ExportID,ProductID,ProductName,Quantity,Price,TotalPrice,AgentID,Address) values('" + txtOrderID.Text + "','" + txtExportID.Text + "','" + comboBox_ID.Text + "',N'" + txtProductName.Text + "','" + txtOrderQuantity.Text + "','" + txtPrice.Text + "','" + txtTotal.Text + "','" + comboBoxAgent.Text + "',N'" + txtAddress.Text + "')";
                    SqlCommand cmd = new SqlCommand(sSQL2, connString);
                    cmd.Parameters.AddWithValue("OrderID", txtOrderID.Text);
                    cmd.Parameters.AddWithValue("ExportID", txtExportID.Text);
                    cmd.Parameters.AddWithValue("ProductID", comboBox_ID.Text);
                    cmd.Parameters.AddWithValue("ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("Quantity", Convert.ToInt32(txtOrderQuantity.Text));
                    cmd.Parameters.AddWithValue("Price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("TotalPrice", Convert.ToDecimal(txtTotal.Text));
                    cmd.Parameters.AddWithValue("AgentID", comboBoxAgent.Text);
                    cmd.Parameters.AddWithValue("Address", txtAddress.Text);
                    cmd.ExecuteNonQuery();


                    connString.Close();


                    MessageBox.Show("Data has been saved", "Notification", MessageBoxButtons.OK);
                }
            }
        }
    }
}

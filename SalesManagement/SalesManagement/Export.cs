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
    public partial class Export : Form
    {
  
        SqlConnection connString = new SqlConnection(@"Data Source = MINHTHU\SQLEXPRESS03; Initial Catalog = FoodCompany; Integrated Security = True");
        public Export()
        {
            InitializeComponent();
        }

        private void Export_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodCompanyDataSet6.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.foodCompanyDataSet6.Product);
            // TODO: This line of code loads data into the 'foodCompanyDataSet6.OrderSP' table. You can move, or remove it, as needed.
            this.orderSPTableAdapter.Fill(this.foodCompanyDataSet6.OrderSP);
            // TODO: This line of code loads data into the 'foodCompanyDataSet5.Order' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'foodCompanyDataSet4.Agent' table. You can move, or remove it, as needed.
 
            // TODO: This line of code loads data into the 'foodCompanyDataSet4.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.foodCompanyDataSet4.Product);
            // TODO: This line of code loads data into the 'foodCompanyDataSet1.Export' table. You can move, or remove it, as needed.
            this.exportTableAdapter.Fill(this.foodCompanyDataSet1.Export);

        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvExport.Rows.Count; i++)
            {
                dgvExport.Rows.Clear();
            }
        }

        private void dgvExport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvExport.Rows.Add(comboBoxExportID.Text, txtProductID.Text, txtProductName.Text, txtAgentID.Text, dateTimePicker1.Text, txtExportQuantity.Text, txtPrice.Text,txtTotal.Text, comboBoxDelivery.Text, comboBoxPayement.Text);


            for (int i = 0; i < dgvExport.Rows.Count; i++)
            {
                {
                    double quantity = Convert.ToDouble(dgvExport.Rows[i].Cells[5].Value);
                    double price = Convert.ToDouble(dgvExport.Rows[i].Cells[6].Value);
                    dgvExport.Rows[i].Cells[7].Value = Convert.ToString(quantity * price);
                }
            }
            
            for (int i = 0; i < dgvExport.Rows.Count; i++)
            {
                double sum = 0;
                double totalPrice = Convert.ToDouble(dgvExport.Rows[i].Cells[7].Value);
                sum += totalPrice;
                txtTotal.Text = sum.ToString();
            }
        }

   
        

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxExportID.ToString() == "")
            {
                MessageBox.Show("Enter ID Export", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //add datagridview to sql           

                int sum = 0;
                for (int i = 0; i < dgvExport.Rows.Count; i++)
                {
                    connString.Open();
                    String sSQL2 = "insert into Export(ExportID,ProductID,ProductName,AgentID,ExportDate,Quantity,Price,TotalPrice,DeliveryStatus,PaymentStatus) values('" + comboBoxExportID.Text + "','" + txtProductID.Text + "',N'" + txtProductName.Text + "',N'" + txtAgentID.Text + "','"  + dateTimePicker1.Text + "','" + txtExportQuantity.Text + "','" + txtPrice.Text + "','"+txtTotal.Text+"',N'" + comboBoxDelivery.Text + "','" + comboBoxPayement.Text  + "')";
                    SqlCommand cmd = new SqlCommand(sSQL2, connString);
                    cmd.Parameters.AddWithValue("ExportID", comboBoxExportID.Text);
                    cmd.Parameters.AddWithValue("ProductID", txtProductID.Text);
                    cmd.Parameters.AddWithValue("ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("AgentID", txtAgentID.Text);
                    cmd.Parameters.AddWithValue("ExportDate", Convert.ToDateTime(dateTimePicker1.Text));
                    cmd.Parameters.AddWithValue("Quantity", Convert.ToInt32(txtExportQuantity.Text));
                    cmd.Parameters.AddWithValue("Price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("TotalPrice", Convert.ToDecimal(txtTotal.Text));
                    cmd.Parameters.AddWithValue("DeliveryStatus", comboBoxDelivery.Text);
                    cmd.Parameters.AddWithValue("PaymentStatus", comboBoxPayement.Text);
                    cmd.ExecuteNonQuery();
                    connString.Close();

                    MessageBox.Show("Data has been saved", "Notification", MessageBoxButtons.OK);
                }
                    for (int i = 0; i < dgvExport.Rows.Count; i++)
                {
                    if (Convert.ToInt32(txtQuantity.Text) > 0)
                    {
                        if (Convert.ToInt32(txtExportQuantity.Text) <= Convert.ToInt32(txtQuantity.Text))
                        {
                            
                            sum = Convert.ToInt32(txtQuantity.Text) - Convert.ToInt32(txtExportQuantity.Text);
                            connString.Open();
                            String sSQL2 = "UPDATE Product SET Quantity = " + sum + "Where ProductID = N'" + txtProductID.Text.Trim() + "'";
                            SqlCommand cmd = new SqlCommand(sSQL2, connString);
                            cmd.Parameters.AddWithValue("ProductID", txtProductID.Text);
                            cmd.Parameters.AddWithValue("Quantity", Convert.ToInt32(sum));

                            cmd.ExecuteNonQuery();
                            connString.Close();
                        }
                    }
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipt print = new Receipt();
            print.ShowDialog();
        }
    }
}

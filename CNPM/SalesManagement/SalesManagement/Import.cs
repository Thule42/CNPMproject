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
    public partial class Import : Form
    {
        
        SqlConnection connString = new SqlConnection(@"Data Source = MINHTHU\SQLEXPRESS03; Initial Catalog = FoodCompany; Integrated Security = True");
        public Import()
        {
            InitializeComponent();
        }
    
        
        

        
        private void Import_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodCompanyDataSet4.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.foodCompanyDataSet4.Product);
            // TODO: This line of code loads data into the 'foodCompanyDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.foodCompanyDataSet.Product);
            // TODO: This line of code loads data into the 'foodCompanyDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.foodCompanyDataSet.Product);
            


            /*try
            {
                dgvImport.DataSource = .Table("select *from Import");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }*/
        }

      

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteTextBox()
        {
            comboBox_ID.SelectedIndex = -1;
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private bool CheckTextBox()
        {
            if(comboBox_ID.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose Product ID");
                return false;
            }
            if(txtPrice.Text == "")
            {
                MessageBox.Show("Please enter the quantity of products");
                return false;
            }
            return true;
        }

     
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Không cho nhập chữ và cho phép xóa được 
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvImport.Rows.Add(comboBox_ID.Text, txtProductName.Text, txtImportQuantity.Text, txtPrice.Text);


            for (int i = 0; i < dgvImport.Rows.Count; i++)
            {
                {
                    double quantity = Convert.ToDouble(dgvImport.Rows[i].Cells[2].Value);
                    double price = Convert.ToDouble(dgvImport.Rows[i].Cells[3].Value);
                    dgvImport.Rows[i].Cells[4].Value = Convert.ToString(quantity * price);
                }
            }
            double sum = 0;
            for (int i = 0; i < dgvImport.Rows.Count; i++)
            {
                double totalPrice = Convert.ToDouble(dgvImport.Rows[i].Cells[4].Value);
                sum += totalPrice;
                txtTotal.Text = sum.ToString();
            }
        }

        private void btnCreateImportReceipt_Click(object sender, EventArgs e)
        {
            if(txtImportID.ToString() == "")
            {
                MessageBox.Show("Enter ID Import", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                //add datagridview to sql           
               
 
                for (int i = 0; i < dgvImport.Rows.Count; i++)
                {
                    int quantity = Convert.ToInt32(dgvImport.Rows[i].Cells[2].Value.ToString());
                    connString.Open();
                    String sSQL2 = "insert into Import(ImportID,ProductID,ProductName,ImportDate,Quantity,Price,TotalPrice) values('" + txtImportID.Text + "','" + comboBox_ID.Text + "',N'" + txtProductName.Text + "','" + dateTimePicker1.Text + "','" + txtImportQuantity.Text + "','" + txtPrice.Text + "','" + txtTotal.Text + "')";
                    SqlCommand cmd = new SqlCommand(sSQL2, connString);
                    cmd.Parameters.AddWithValue("ImportID", txtImportID.Text);
                    cmd.Parameters.AddWithValue("ProductID", comboBox_ID.Text);
                    cmd.Parameters.AddWithValue("ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("ImportDate", Convert.ToDateTime(dateTimePicker1.Text));
                    cmd.Parameters.AddWithValue("Quantity", Convert.ToInt32(txtImportQuantity.Text));
                    cmd.Parameters.AddWithValue("Price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("TotalPrice", Convert.ToDecimal(txtTotal.Text));
                    cmd.ExecuteNonQuery();
                                       
                    
                    connString.Close();                 
                 
                   
                    MessageBox.Show("Data has been saved", "Notification", MessageBoxButtons.OK);
                }
                int sum = 0;
                for (int i = 0; i < dgvImport.Rows.Count; i++)
                {
                            sum = Convert.ToInt32(txtQuantity.Text) + Convert.ToInt32(txtImportQuantity.Text);
                            connString.Open();
                            String sSQL2 = "UPDATE Product SET Quantity = " + sum + "Where ProductID = N'" + comboBox_ID.Text.Trim() + "'";
                            SqlCommand cmd = new SqlCommand(sSQL2, connString);
                            cmd.Parameters.AddWithValue("ProductID", comboBox_ID.Text);
                            cmd.Parameters.AddWithValue("Quantity", Convert.ToInt32(sum));

                            cmd.ExecuteNonQuery();
                            connString.Close();
                        
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e) 
        {
            for (int i = 0; i < dgvImport.Rows.Count; i++)
            {
                if(dgvImport.Rows[i].Cells[0].ToString() == txtImportID.ToString())
                {
                    dgvImport.Rows.Remove(dgvImport.Rows[i]);
                }
            }
            double sum = 0;
            for (int i = 0; i < dgvImport.Rows.Count; i++)
            {
                double totalPrice = Convert.ToDouble(dgvImport.Rows[i].Cells[4].Value);
                sum += totalPrice;
                txtTotal.Text = sum.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) // clear dategridview
        {
            for (int i = 0; i < dgvImport.Rows.Count; i++)
            {
                dgvImport.Rows.Clear();
            }
        }

        private void txtPrice_TextChanged_1(object sender, EventArgs e)
        {





        }

        private void dgvImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

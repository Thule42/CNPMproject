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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace SalesManagement
{
    public partial class Receipt : Form
    {
        SqlConnection connString = new SqlConnection(@"Data Source = MINHTHU\SQLEXPRESS03; Initial Catalog = FoodCompany; Integrated Security = True");
        
        public Receipt()
        {
            InitializeComponent();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
           
            
            
        }

        private void ExportExel(DataGridView dgv, string link, string nameExcel)
        {
            app pt = new app();
            pt.Application.Workbooks.Add(Type.Missing);
            pt.Columns.ColumnWidth = 20;
            for(int i =1;i<dgv.Columns.Count + 1; i++)
            {
                pt.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for(int i=0; i < dgv.Rows.Count; i++)
            {
                for(int j = 0; j < dgv.Columns.Count; j++)
                {
                    if(dgv.Rows[i].Cells[j].Value != null)
                    {
                        pt.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            pt.ActiveWorkbook.SaveAs(link + nameExcel + ".xlsx");
            pt.ActiveWorkbook.Saved = true;
        }
        private void Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodCompanyDataSet6.Export' table. You can move, or remove it, as needed.
            this.exportTableAdapter1.Fill(this.foodCompanyDataSet6.Export);
            // TODO: This line of code loads data into the 'foodCompanyDataSet5.Export' table. You can move, or remove it, as needed.
            this.exportTableAdapter.Fill(this.foodCompanyDataSet5.Export);
   

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportExel(dataGridView1, @"D:\", "PrintExcel");
        }
    }
}

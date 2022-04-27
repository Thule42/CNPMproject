using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void employeeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee addEmployee = new Employee();
            addEmployee.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product addProduct = new Product();
            addProduct.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import addImport = new Import();
            addImport.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export addExport = new Export();
            addExport.ShowDialog();
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics addStat = new Statistics();
            addStat.ShowDialog();
        }

        private void agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agent addAgent = new Agent();
            addAgent.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order addOrder = new Order();
            addOrder.ShowDialog();
        }
    }
}

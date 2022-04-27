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
using MaterialSkin.Controls;
using MaterialSkin;

namespace SalesManagement
{
    public partial class Login : MaterialForm
    {

        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connString = new SqlConnection(@"Data Source=MINHTHU\SQLEXPRESS03;Initial Catalog=FoodCompany;Integrated Security=True");
            try
            {
                connString.Open();
                string usn = txtUsername.Text;
                string pw = txtPassword.Text;
                string sql = "select *from UserLogin where Username='" + usn + "' and UserPassword='" + pw + "'";
                SqlCommand cmd = new SqlCommand(sql, connString);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read() == true)
                {
                    MessageBox.Show("Login Sucessfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Menu add = new Menu();
                    add.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Errors");
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            else
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}

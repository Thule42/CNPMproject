using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SalesManagement
{
    class Mod
    {
        public Mod()
        {

        }
        SqlDataAdapter da;
        SqlCommand cmd;
        public DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                da = new SqlDataAdapter(query, sqlConnection);
                da.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close(); 
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    class Connection
    {
        private static string ConnectionString = @"Data Source=MINHTHU\SQLEXPRESS03;Initial Catalog=FoodCompany;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
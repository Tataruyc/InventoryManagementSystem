using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    class DB
    {
        static string connectionStr = "Server=ASUS;Database=ManagmentSystem;Trusted_Connection=True;";
        SqlConnection connection = new SqlConnection(connectionStr);
        public void openConnectionDB()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnectionDB()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection genConnectionDB()
        {
            return connection;
        }
    }
}

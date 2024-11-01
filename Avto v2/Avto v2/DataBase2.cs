using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Avto_v2
{
    internal class DataBase1
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-N0J15TD;Initial Catalog=Register;Integrated Security=True;Encrypt=False");

        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}

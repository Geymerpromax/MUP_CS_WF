using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MUP_CS_WF
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection
            ("server=localhost;port=3306;username=root;password=root;database=db"); 
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection() 
        {
            return connection;
        }

    }
}

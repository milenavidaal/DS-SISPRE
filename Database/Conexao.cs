using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DS_SISPRE.Database
{
    class Conexao
    {
        private static string host = "localhost";

        private static string port = "3306";

        private static string user = "root";

        private static string password = "root";

        private static string dbname = "sispre";

        private static MySqlConnection connection;

        private static MySqlCommand command;

        public Conexao()
        {
            try 
            {
                connection = new MySqlConnection($"server={host}; database={dbname}; port={port}; user={user};password={password}");
            } catch (Exception)
            {
                throw;
            }
        }

        public void Close()
        {
            connection.Close();
        }



    }
}

using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca.Database
{
    public static class DatabaseConnection
    {
        private static readonly string ConnectionString =
            "Server=localhost;Port=3306;Database=db_biblioteca_v1;User ID=first;Password=1234;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}

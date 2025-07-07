using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gymkuuu
{
    internal class Koneksi
    {
        private static string connStr = "server=localhost;user=root;password=;database=gymkuuu;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}

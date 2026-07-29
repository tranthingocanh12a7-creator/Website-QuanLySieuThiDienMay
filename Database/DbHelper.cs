using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chamcong
{
    class DbHelper
    {
        private static string connString = "server=localhost;user=root;database=sieuthidienmay;password=;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}

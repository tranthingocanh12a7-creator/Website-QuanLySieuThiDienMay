
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DoAn1.model
{
    internal class DBContext
    {
        private string connectionString = "server=localhost;database=sieuthidienmay;uid=root;pwd=;";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

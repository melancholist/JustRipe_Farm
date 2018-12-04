using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class DbConnector
    {
        MySqlConnection conn;

        public string connect()
        {
            string connectionString = "server=localhost;user=root;database=justripe_farm;port=3306";
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
            }

            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "Done";
        }

        public MySqlConnection getConn()
        { return conn; }
    }
}

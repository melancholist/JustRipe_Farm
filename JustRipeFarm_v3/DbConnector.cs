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
            // To access the database
            // Go to this website http://www.phpmyadmin.co/
            //Server: sql12.freemysqlhosting.net
            //Username: sql12268366
            //Password: 1VpFDLJHBC

            string connectionString = "server=sql12.freemysqlhosting.net;user=sql12268366;database=sql12268366;password=1VpFDLJHBC;port=3306";
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

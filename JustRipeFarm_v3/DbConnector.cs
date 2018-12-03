using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace JustRipeFarm_v3
{
    public class DbConnector
    {
        SqlConnection conn;

        public string connect()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|JustRipeFarm.mdf;Integrated Security=False";
            conn = new SqlConnection(connectionString);
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

        public SqlConnection getConn()
        { return conn; }
    }
}

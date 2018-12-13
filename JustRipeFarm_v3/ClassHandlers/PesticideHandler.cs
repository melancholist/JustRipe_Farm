using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class PesticideHandler
    {
        public int addNewPesticide(MySqlConnection conn, Pesticides pesticides)
        {
            string addPesticideQuery = "INSERT INTO pesticide (pesticideType, pesticideQuantity, company)"
                + "VALUES ('" + pesticides.PesticideType + "', '" + pesticides.PesticideQuantity + "', '" + pesticides.Company + "')";

            MySqlCommand sqlComm = new MySqlCommand(addPesticideQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int updateQuantity(MySqlConnection conn, Pesticides pesticides)
        {
            string query = "UPDATE pesticide SET  pesticideQuantity = '" + pesticides.PesticideQuantity + "' " +
                "WHERE pesticideType = '" + pesticides.PesticideType + "'";

            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}

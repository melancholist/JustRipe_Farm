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
            string addPesticideQuery = "INSERT INTO pesticide (pesticidesType, pesticideQauntity, company)"
                + "VALUES ('" + pesticides.PesticidesType + "', '" + pesticides.PesticideQauntity + "', '" + pesticides.Company + "',)";

            MySqlCommand sqlComm = new MySqlCommand(addPesticideQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int updateQuantity(MySqlConnection conn, Pesticides pesticides)
        {
            string query = "UPDATE pesticide SET  pesticideQauntity = '" + pesticides.PesticideQauntity + "' " +
                "WHERE pesticideType = '" + pesticides.PesticidesType + "'";

            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}

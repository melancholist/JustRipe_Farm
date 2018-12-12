using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class FertiliserHandler
    {
        public int addNewFertiliser(MySqlConnection conn, Fertiliser fertiliser)
        {
            string addFertiliserQuery = "INSERT INTO fertiliser (fertiliserType, fertiliserQuantity, fertiliserCompany)"
                + "VALUES ('" + fertiliser.FertiliserType + "', '" + fertiliser.FertiliserQuantity + "', '" + fertiliser.FertiliserCompany + "')";

            MySqlCommand sqlComm = new MySqlCommand(addFertiliserQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int updateQuantity(MySqlConnection conn, Fertiliser fertiliser)
        {
            string query = "UPDATE fertiliser SET fertiliserQuantity = '" + fertiliser.FertiliserQuantity + "' " +
                "WHERE fertiliserType = '" + fertiliser.FertiliserType + "'";

            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}

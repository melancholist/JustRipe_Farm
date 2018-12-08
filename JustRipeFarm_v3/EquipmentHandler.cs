using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class EquipmentHandler
    {
        public int addNewEquipment(MySqlConnection conn, Equipment equipment)
        {
            string insertQuery = "INSERT INTO equipment (type, brand, model, serialNumber, purchaseDate, price, description)"
                + "VALUES ('" + equipment.Type + "', '" + equipment.Brand + "'  , " + equipment.Model + ", '" +
                equipment.SerialNumber + "', '" + equipment.PurchaseDate + "', '" + equipment.Price + "', '" + equipment.Description + "' )";

            MySqlCommand sqlComm = new MySqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

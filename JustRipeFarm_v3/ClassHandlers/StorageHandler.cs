using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class StorageHandler
    {
        public int addStorage(MySqlConnection conn, Storage storage)
        {
            string addStorageQuery = "INSERT INTO storage (unitType, unitName, cubicCapacity, minimumTemperature, maximumTemperature, humidity)"
                + "VALUES ('" + storage.UnitType + "', '" + storage.UnitName + "', '" + storage.CubicCapacity + "'," +
                " '" + storage.MinimumTemperature + "', '" + storage.MaximumTemperature + "', '" + storage.Humidity + "',)";

            MySqlCommand sqlComm = new MySqlCommand(addStorageQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

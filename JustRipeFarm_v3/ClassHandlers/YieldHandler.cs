﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class YieldHandler
    {
        public int addYield(MySqlConnection conn, Yield yield)
        {
            string addYield = "INSERT INTO yield (yieldType, quantity, storageUnitName, storageCapacity)"
                + "VALUES ('" + yield.YieldType + "', '" + yield.Quantity + "', '" + yield.StorageUnitName + "', '" +
                yield.StorageCapacity + "')";

            MySqlCommand sqlComm = new MySqlCommand(addYield, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

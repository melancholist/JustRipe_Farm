﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class VehicleHandler
    {
        public int addNewVehicle(MySqlConnection conn, Vehicle vehicle)
        {
            string addVehicleQuery = "INSERT INTO vehicle (vehicleType, modelName, productionYear, engineNumber, weightLimit, vehicleStatus, price)"
                + "VALUES ('" + vehicle.VehicleType + "', '" + vehicle.ModelName + "', '" +
                vehicle.ProductionYear.ToString("yyyy") + "', '" + vehicle.EngineNumber + "', '" + vehicle.WeightLimit + "', '" +
                vehicle.VehicleStatus + "',  '" + vehicle.Price + "')";

            MySqlCommand sqlComm = new MySqlCommand(addVehicleQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }

        /*public int updateStatus(MySqlConnection conn, Vehicle vehicle)
        {
            string statusQuery = "UPDATE vehicle SET vehicleStatus = '" + vehicle.VehicleStatus + "' WHERE modelName = '" + vehicle.ModelName + "'";

            MySqlCommand sqlCmd = new MySqlCommand(statusQuery, conn);
            return sqlCmd.ExecuteNonQuery();
        }*/
    }
}

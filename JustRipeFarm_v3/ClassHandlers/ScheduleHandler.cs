using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class ScheduleHandler
    {
        public int addSowingSchedule(MySqlConnection cn, Sowing sowing)
        {
            string sowingQuery = "INSERT INTO sowingTask (labourerName, farmSector, date, method, seed, quantity, startTime, endTime)"
                + "VALUES ('" + sowing.LabourerName + "', " + sowing.FarmSector + ", '" + sowing.Date.ToString("yyyy-MM-dd") + "', '" +
                sowing.Method + "', '" + sowing.Seed + "', '" + sowing.Quantity + "', '" + sowing.StartTime.ToString("hh:mm:ss") + "', '" +
                sowing.EndTime.ToString("hh:mm") + "' )";

            MySqlCommand sqlCmd = new MySqlCommand(sowingQuery, cn);

            return sqlCmd.ExecuteNonQuery();
        }

        public int addHarvestSchedule(MySqlConnection cn, Harvest harvest)
        {
            string harvestQuery = "INSERT INTO harvestTask (labourerName, farmSector, date, method, storageUnit, machine, startTime, endTime)"
                + "VALUES ('" + harvest.LabourerName + "', " + harvest.FarmSector + ", '" + harvest.Date.ToString("yyyy-MM-dd") + "', '" +
                harvest.Method + "', '" + harvest.StorageUnit + "', '" + harvest.Machine + "', '" + harvest.StartTime.ToString("hh:mm:ss") + "', '" +
                harvest.EndTime.ToString("hh:mm") + "' )";

            MySqlCommand sqlCmd = new MySqlCommand(harvestQuery, cn);

            return sqlCmd.ExecuteNonQuery();
        }

        public int addTreatingSchedule(MySqlConnection cn, Treating treating)
        {
            string treatmentQuery = "INSERT INTO treatmentTask (labourerName, farmSector, date, fertiliserUsed, quantity, startTime, endTime)"
                + "VALUES ('" + treating.LabourerName + "', " + treating.FarmSector + ", '" + treating.Date.ToString("yyyy-MM-dd") + "', '" +
                treating.FertiliserUsed + "', '" + treating.Quantity + "', '" + treating.StartTime.ToString("hh:mm:ss") + "', '" +
                treating.EndTime.ToString("hh:mm") + "' )";

            MySqlCommand sqlCmd = new MySqlCommand(treatmentQuery, cn);

            return sqlCmd.ExecuteNonQuery();
        }

        public int addDrivingSchedule(MySqlConnection cn, Driving driving)
        {
            string drivingQuery = "INSERT INTO drivingTask (labourerName, farmSector, date, vehicleUsed)"
                + "VALUES ('" + driving.LabourerName + "', " + driving.FarmSector + ", '" + driving.Date.ToString("yyyy-MM-dd") + "', '" +
                driving.VehicleUsed + "')";

            MySqlCommand sqlCmd = new MySqlCommand(drivingQuery, cn);

            return sqlCmd.ExecuteNonQuery();
        }
    }
}

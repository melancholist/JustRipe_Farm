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
        //Sowing Task
        public int addSowingSchedule(MySqlConnection cn, Sowing sowing)
        {
            string sowingQuery = "INSERT INTO sowingTask (labourerName, farmSector, taskStatus, startDate, endDate, method, seed, quantity, startTime, endTime)"
                + "VALUES ('" + sowing.LabourerName + "', " + sowing.FarmSector + ", '" + sowing.TaskStatus + "', '" + sowing.StartDate.ToString("yyyy-MM-dd") + "', '" + sowing.EndDate.ToString("yyyy-MM-dd") + "', '" +
                sowing.Method + "', '" + sowing.Seed + "', '" + sowing.Quantity + "', '" + sowing.StartTime.ToString("HH:mm:ss") + "', '" +
                sowing.EndTime.ToString("HH:mm:ss") + "' )";

            MySqlCommand sqlCmd = new MySqlCommand(sowingQuery, cn);

            return sqlCmd.ExecuteNonQuery();
        }
        public int updateSowTask(MySqlConnection conn, Sowing sowing)
        {
            string taskSowQuery = "UPDATE sowingTask SET taskStatus = '" + sowing.TaskStatus + "' WHERE labourerName = '" + sowing.LabourerName + "'";

            MySqlCommand sqlCmd = new MySqlCommand(taskSowQuery, conn);
            return sqlCmd.ExecuteNonQuery();
        }

        //Harvest Task
        public int addHarvestSchedule(MySqlConnection cn, Harvest harvest)
        {
            string harvestQuery = "INSERT INTO harvestTask (labourerName, farmSector, taskStatus, startDate, endDate, method, storageUnit, machine, startTime, endTime)"
                + "VALUES ('" + harvest.LabourerName + "', " + harvest.FarmSector + ", '" + harvest.TaskStatus + "', '" + harvest.StartDate.ToString("yyyy-MM-dd") + "', '" + harvest.EndDate.ToString("yyyy-MM-dd") + "', '" +
                harvest.Method + "', '" + harvest.StorageUnit + "', '" + harvest.Machine + "', '" + harvest.StartTime.ToString("HH:mm:ss") + "', '" +
                harvest.EndTime.ToString("HH:mm:ss") + "' )";

            MySqlCommand sqlCmd = new MySqlCommand(harvestQuery, cn);

            return sqlCmd.ExecuteNonQuery();
        }
        public int updateHarvTask(MySqlConnection conn, Harvest harvest)
        {
            string taskHarvQuery = "UPDATE harvestTask SET taskStatus = '" + harvest.TaskStatus + "' WHERE labourerName = '" + harvest.LabourerName + "'";

            MySqlCommand sqlCmd = new MySqlCommand(taskHarvQuery, conn);
            return sqlCmd.ExecuteNonQuery();
        }

        //Treatment Task
        public int addTreatingSchedule(MySqlConnection cn, Treating treating)
        {
            string treatmentQuery = "INSERT INTO treatmentTask (labourerName, farmSector, taskStatus, startDate, endDate, fertiliserUsed, quantity, startTime, endTime)"
                + "VALUES ('" + treating.LabourerName + "', " + treating.FarmSector + ", '" + treating.TaskStatus + "', '" + treating.StartDate.ToString("yyyy-MM-dd") + "', '" + treating.EndDate.ToString("yyyy-MM-dd") + "', '" +
                treating.FertiliserUsed + "', '" + treating.Quantity + "', '" + treating.StartTime.ToString("HH:mm:ss") + "', '" +
                treating.EndTime.ToString("HH:mm:ss") + "' )";

            MySqlCommand sqlCmd = new MySqlCommand(treatmentQuery, cn);

            return sqlCmd.ExecuteNonQuery();
        }
        public int updateTrtTask(MySqlConnection conn, Treating treating)
        {
            string taskTrtQuery = "UPDATE treatmentTask SET taskStatus = '" + treating.TaskStatus + "' WHERE labourerName = '" + treating.LabourerName + "'";

            MySqlCommand sqlCmd = new MySqlCommand(taskTrtQuery, conn);
            return sqlCmd.ExecuteNonQuery();
        }

        //Driving Task
        public int addDrivingSchedule(MySqlConnection cn, Driving driving)
        {
            string drivingQuery = "INSERT INTO drivingTask (labourerName, farmSector, taskStatus, startDate, endDate, vehicleUsed)"
                + "VALUES ('" + driving.LabourerName + "', " + driving.FarmSector + ", '" + driving.TaskStatus + "', '" + driving.StartDate.ToString("yyyy-MM-dd") + "', '" + driving.EndDate.ToString("yyyy-MM-dd") + "', '" +
                driving.VehicleUsed + "')";

            MySqlCommand sqlCmd = new MySqlCommand(drivingQuery, cn);

            return sqlCmd.ExecuteNonQuery();
        }
        public int updateDrvTask(MySqlConnection conn, Driving driving)
        {
            string taskDrvQuery = "UPDATE treatmentTask SET taskStatus = '" + driving.TaskStatus + "' WHERE labourerName = '" + driving.LabourerName + "'";

            MySqlCommand sqlCmd = new MySqlCommand(taskDrvQuery, conn);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}

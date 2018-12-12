using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class MachineHandler
    {
        public int addNewMachine(MySqlConnection conn, Machine machine)
        {
            string addMachineQuery = "INSERT INTO machine (machineType, modelName, machineStatus, price)"
                + "VALUES ('" + machine.MachineType + "', '" + machine.ModelName + "', '" + machine.MachineStatus + "', '" + machine.Price + "' )";

            MySqlCommand sqlComm = new MySqlCommand(addMachineQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int updateMachine(MySqlConnection conn, Machine machine)
        {
            string resetQuery = "UPDATE machine SET machineStatus = '" + machine.MachineStatus + "' WHERE machine.ModelName = '" + machine.ModelName + "'";

            MySqlCommand sqlCmd = new MySqlCommand(resetQuery, conn);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}

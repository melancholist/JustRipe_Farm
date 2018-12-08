using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class ServiceRecordHandler
    {
        public int addNewServiceRecord(MySqlConnection conn, ServiceRecord serviceRecord)
        {
            string insertQuery = "INSERT INTO serviceRecord (eqSerialNo, serviceType, serviceDate, serviceDescription)"
                + "VALUES ('" + serviceRecord.EqSerialNo + "', '" + serviceRecord.ServiceType + "'  , " + serviceRecord.ServiceDate + ", '" +
                serviceRecord.ServiceDescription + "' )";

            MySqlCommand sqlComm = new MySqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

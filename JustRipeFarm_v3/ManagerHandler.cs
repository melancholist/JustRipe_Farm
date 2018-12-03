using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JustRipeFarm_v3
{
    class ManagerHandler
    {
        public int addNewManager(SqlConnection conn, Manager manager)
        {
            string insertQuery = "INSERT INTO Manager (FirstName, LastName, Age, Sex, Address, ContactNumber, Username, Password)"
                + "VALUES ('" + manager.FirstName1 + "', '" + manager.LastName1 + "'  , " + manager.Age1 + ", '" +
                manager.Sex1 + "', '" + manager.Address1 + "', '" + manager.ContactNumber1 + "', '" +
                manager.Username1 + "', '" + manager.Password1 + "' )";

            SqlCommand sqlComm = new SqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JustRipeFarm_v3
{
    public class LabourerHandler
    {
        public int addNewLabourer(SqlConnection conn, Staff labourer)
        {
            string insertQuery = "INSERT INTO LabourerData (FirstName, LastName, Age, Sex, MaritalStatus, Address, ZipCode, NRIC, DateOfBirth, HandphoneNumber, HouseNumber, Status, DateOfHire, HourlyWage, Username, Password)"
                + "VALUES ('" + labourer.FirstName1 + "', '" + labourer.LastName1 + "'  , " + labourer.Age1 + ", '" +
                labourer.Sex1 + "', '" + labourer.MaritalStatus1 + "', '" + labourer.Address1 + "', '" + labourer.ZipCode1 
                + "', '" + labourer.NRIC1 + "', '" + labourer.DateOfBirth1.ToString("yyyy-MM-dd") + "', '" + 
                labourer.HandphoneNumber1 + "', '" + labourer.HouseNumber1 + "', '" + labourer.Status1 + "', '" +
                labourer.DateOfBirth1.ToString("yyyy-MM-dd") + "', '" + labourer.HourlyWage1 + "', '" +
                labourer.Username1 + "', '" + labourer.Password1 + "' )";

            SqlCommand sqlComm = new SqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

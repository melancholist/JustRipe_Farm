using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JustRipeFarm_v3
{
    public class StaffHandler
    {
        public int addNewLabourer(SqlConnection conn, Staff staff)
        {
            string insertQuery = "INSERT INTO StaffData (firstName, lastName, age, sex, address, zipCode, contactNumber, staffRole, loginStatus, dateOfHire, hourlyWage, username, password)"
                + "VALUES ('" + staff.FirstName + "', '" + staff.LastName + "'  , " + staff.Age + ", '" +
                staff.Sex + "', '" + staff.Address + "', '" + staff.ZipCode 
                + "', '" + staff.ContactNumber + "', '" + staff.StaffRole + "', '" + staff.LoginStatus + "', '" +
                staff.DateOfHire.ToString("yyyy-MM-dd") + "', '" + staff.HourlyWage + "', '" +
                staff.Username + "', '" + staff.Password + "' )";

            SqlCommand sqlComm = new SqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewManager(SqlConnection conn, Staff staff)
        {
            string insertQuery = "INSERT INTO StaffData (firstName, lastName, age, sex, address, zipCode, contactNumber, staffRole, loginStatus, username, password)"
                + "VALUES ('" + staff.FirstName + "', '" + staff.LastName + "'  , " + staff.Age + ", '" +
                staff.Sex + "', '" + staff.Address + "', '" + staff.ZipCode
                + "', '" + staff.ContactNumber + "', '" + staff.StaffRole + "', '" + staff.LoginStatus + "', '" +
                staff.Username + "', '" + staff.Password + "' )";

            SqlCommand sqlComm = new SqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int addNewSalesStaff(SqlConnection conn, Staff staff)
        {
            string insertQuery = "INSERT INTO StaffData (firstName, lastName, age, sex, address, zipCode, contactNumber, staffRole, loginStatus, username, password)"
                + "VALUES ('" + staff.FirstName + "', '" + staff.LastName + "'  , " + staff.Age + ", '" +
                staff.Sex + "', '" + staff.Address + "', '" + staff.ZipCode
                + "', '" + staff.ContactNumber + "', '" + staff.StaffRole + "', '" + staff.LoginStatus + "', '" +
                staff.Username + "', '" + staff.Password + "' )";

            SqlCommand sqlComm = new SqlCommand(insertQuery, conn);
            return sqlComm.ExecuteNonQuery();
        }

        public int resetPassword(SqlConnection conn, Staff staff)
        {
            string resetQuery = "UPDATE [StaffData] SET Password = '" + staff.Username + "' WHERE Username = '" + staff.Password + "'";

            SqlCommand sqlCmd = new SqlCommand(resetQuery, conn);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}

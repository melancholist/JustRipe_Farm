using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class StaffHandler
    {
        public int addNewStaff(MySqlConnection conn, Staff staff)
        {
            string insertQuery = "INSERT INTO staffdata (firstName, lastName, age, sex, address, zipCode, contactNumber, staffRole, loginStatus, dateOfHire, hourlyWage, username, password)"
                + "VALUES ('" + staff.FirstName + "', '" + staff.LastName + "'  , " + staff.Age + ", '" +
                staff.Sex + "', '" + staff.Address + "', '" + staff.ZipCode 
                + "', '" + staff.ContactNumber + "', '" + staff.StaffRole + "', '" + staff.LoginStatus + "', '" +
                staff.DateOfHire.ToString("yyyy-MM-dd") + "', '" + staff.HourlyWage + "', '" +
                staff.Username + "', '" + staff.Password + "' )";

            MySqlCommand sqlComm = new MySqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int resetPassword(MySqlConnection conn, Staff staff)
        {
            string resetQuery = "UPDATE staffdata SET Password = '" + staff.Password + "' WHERE Username = '" + staff.Username + "'";

            MySqlCommand sqlCmd = new MySqlCommand(resetQuery, conn);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}

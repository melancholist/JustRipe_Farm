using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Staff
    {
        private int id;
        private String firstName;
        private String lastName;
        private Decimal age;
        private string sex;
        private string address;
        private string zipCode;
        private string contactNumber;
        private string staffRole;
        private string loginStatus;
        private DateTime dateOfHire;
        private Decimal hourlyWage;
        private string username;
        private string password;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public decimal Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string StaffRole { get => staffRole; set => staffRole = value; }
        public string LoginStatus { get => loginStatus; set => loginStatus = value; }
        public DateTime DateOfHire { get => dateOfHire; set => dateOfHire = value; }
        public decimal HourlyWage { get => hourlyWage; set => hourlyWage = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}

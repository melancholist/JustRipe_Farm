using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JustRipeFarm_v3
{
    public class Manager
    {
        private int id;
        private string FirstName;
        private string LastName;
        private Decimal Age;
        private string Sex;
        private string Address;
        private string ContactNumber;
        private string Username;
        private string Password;

        public int Id { get => id; set => id = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public decimal Age1 { get => Age; set => Age = value; }
        public string Sex1 { get => Sex; set => Sex = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string ContactNumber1 { get => ContactNumber; set => ContactNumber = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}

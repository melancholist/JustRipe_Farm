using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class IncomeHandler
    {
        public int addNewIncome(MySqlConnection conn, Income income)
        {
            string insertQuery = "INSERT INTO income (customer, amount, date, category, description)"
                + "VALUES ('" + income.Customer + "', '" + income.Amount + "'  , '" + income.Date.ToString("yyyy-MM-dd") + "', '" +
                income.Category + "', '" + income.Description + "' )";

            MySqlCommand sqlComm = new MySqlCommand(insertQuery, conn);
             
            return sqlComm.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    class ExpenseHandler
    {
        public int addNewExpense(MySqlConnection conn, Expense expense)
        {
            string insertQuery = "INSERT INTO expense (payee, amount, date, category, description)"
                + "VALUES ('" + expense.Payee + "', '" + expense.Amount + "'  , '" + expense.Date.ToString("yyyy-MM-dd") + "', '" +
               expense.Category + "', '" + expense.Description + "' )";

            MySqlCommand sqlComm = new MySqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

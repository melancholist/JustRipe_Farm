using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    public class ProductHandler
    {
        public int addNewProduct(MySqlConnection conn, Product product)
        {
            string insertQuery = "INSERT INTO product(productName, price, quantityAvailable, category, status, description)"
                + "VALUES ('" + product.ProductName + "', '" + product.Price + "'  , " + product.QuantityAvailable + ", '" +
                product.Category + "', '" + product.Status + "', '" + product.Description + "' )";

            MySqlCommand sqlComm = new MySqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

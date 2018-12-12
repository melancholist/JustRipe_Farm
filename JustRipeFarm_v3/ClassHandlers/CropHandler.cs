using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRipeFarm_v3
{
    class CropHandler
    {
        public int addNewCrop(MySqlConnection conn, Crop crop)
        {
            string insertQuery = "INSERT INTO crop (type, variety, seedCompany, seedLotNumber, seedOrigin, organic, gmo, plantSpacing, plantingDepth, seedPerHole, plantingMethod, additionalInformation)"
                + "VALUES ('" + crop.Type + "', '" + crop.Variety + "', '" + crop.SeedCompany + "'  , " + crop.SeedLotNumber + ", '" +
                crop.SeedOrigin + "', '" + crop.Organic + "', '" + crop.Gmo + "', '" + 
                crop.PlantSpacing + "', '" + crop.PlantingDepth + "', '" + crop.SeedPerHole + "', '" + 
                crop.PlantingMethod + "', '" + crop.AdditionalInformation + "' )";

            MySqlCommand sqlComm = new MySqlCommand(insertQuery, conn);

            return sqlComm.ExecuteNonQuery();
        }
    }
}

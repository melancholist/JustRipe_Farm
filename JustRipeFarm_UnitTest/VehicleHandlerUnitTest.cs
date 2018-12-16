using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using JustRipeFarm_v3;

namespace JustRipeFarm_UnitTest
{
    [TestClass]
    public class VehicleHandlerUnitTest
    {
        [TestMethod]
        public void AddNewVehicleTest()
        {
            DbConnector con = new DbConnector();
            string resp = con.connect();
            Assert.AreEqual("Done", resp);

            Vehicle vehicle = new Vehicle();
            vehicle.VehicleType = "Truck";
            vehicle.ModelName = "starz45";
            vehicle.ProductionYear = new DateTime(2015);
            vehicle.EngineNumber = "56562651";
            vehicle.WeightLimit = 500.20M;
            vehicle.VehicleStatus = "Available";
            vehicle.Price = 1522.00M;

            VehicleHandler vehicHandlr = new VehicleHandler();
            int resp2 = vehicHandlr.addNewVehicle(con.getConn(), vehicle);
            Assert.AreEqual(1, resp2);
        }
    }
}

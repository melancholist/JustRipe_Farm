using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using JustRipeFarm_v3;

namespace JustRipeFarm_UnitTest
{
    [TestClass]
    public class FertiliserHandlerUnitTest
    {
        [TestMethod]
        public void AddNewFertiliser()
        {
            DbConnector dbconn = new DbConnector();
            string resp = dbconn.connect();
            Assert.AreEqual("Done", resp);

            Fertiliser fert = new Fertiliser();
            fert.FertiliserType = "Urea";
            fert.FertiliserQuantity = 30.00M;
            fert.FertiliserCompany = "Just Good Turds";

            FertiliserHandler fertHandlr = new FertiliserHandler();
            int resp2 = fertHandlr.addNewFertiliser(dbconn.getConn(), fert);
            Assert.AreEqual(1, resp2);
        }
    }
}

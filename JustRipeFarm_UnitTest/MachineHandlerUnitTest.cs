using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using JustRipeFarm_v3;

namespace JustRipeFarm_UnitTest
{
    [TestClass]
    public class MachineHandlerUnitTest
    {
        [TestMethod]
        public void AddNewMachine()
        {
            DbConnector conn = new DbConnector();
            string resp = conn.connect();
            Assert.AreEqual("Done", resp);

            Machine machine = new Machine();
            machine.MachineType = "Harvester";
            machine.ModelName = "turbulance400";
            machine.MachineStatus = "Available";
            machine.Price = 1522.00M;

            MachineHandler mechHandlr = new MachineHandler();
            int resp2 = mechHandlr.addNewMachine(conn.getConn(), machine);
            Assert.AreEqual(1, resp2);
        }
    }
}

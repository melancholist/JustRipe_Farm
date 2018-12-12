using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Machine
    {
        private int id;
        private string machineType;
        private string modelName;
        private string machineStatus;
        private decimal price;

        public int Id { get => id; set => id = value; }
        public string MachineType { get => machineType; set => machineType = value; }
        public string ModelName { get => modelName; set => modelName = value; }
        public string MachineStatus { get => machineStatus; set => machineStatus = value; }
        public decimal Price { get => price; set => price = value; }
    }
}

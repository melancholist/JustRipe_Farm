using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Vehicle
    {
        private int id;
        private string vehicleType;
        private string modelName;
        private DateTime productionYear;
        private decimal engineNumber;
        private decimal weightLimit;
        private string vehicleStatus;
        private decimal price;
        private DateTime date;

        public int Id { get => id; set => id = value; }
        public string VehicleType { get => vehicleType; set => vehicleType = value; }
        public string ModelName { get => modelName; set => modelName = value; }
        public DateTime ProductionYear { get => productionYear; set => productionYear = value; }
        public decimal EngineNumber { get => engineNumber; set => engineNumber = value; }
        public decimal WeightLimit { get => weightLimit; set => weightLimit = value; }
        public string VehicleStatus { get => vehicleStatus; set => vehicleStatus = value; }
        public decimal Price { get => price; set => price = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}

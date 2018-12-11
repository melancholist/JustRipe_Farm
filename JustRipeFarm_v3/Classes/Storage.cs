using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Storage
    {
        private int id;
        private string unitType;
        private string unitName;
        private decimal cubicCapacity;
        private decimal minimumTemperature;
        private decimal maximumTemperature;
        private decimal humidity;

        public int Id { get => id; set => id = value; }
        public string UnitType { get => unitType; set => unitType = value; }
        public string UnitName { get => unitName; set => unitName = value; }
        public decimal CubicCapacity { get => cubicCapacity; set => cubicCapacity = value; }
        public decimal MinimumTemperature { get => minimumTemperature; set => minimumTemperature = value; }
        public decimal MaximumTemperature { get => maximumTemperature; set => maximumTemperature = value; }
        public decimal Humidity { get => humidity; set => humidity = value; }
    }
}

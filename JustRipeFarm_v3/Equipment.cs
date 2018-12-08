using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Equipment
    {
        private int id;
        private string type;
        private string brand;
        private string model;
        private string serialNumber;
        private DateTime purchaseDate;
        private decimal price;
        private string description;

        public int Id { get => id; set => id = value; }
        public decimal Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Description { get => description; set => description = value; }
    }
}

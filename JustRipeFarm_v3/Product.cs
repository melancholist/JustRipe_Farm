using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Product
    {
        private int id;
        private string productName;
        private decimal price;
        private int quantityAvailable;
        private string status;
        private string category;
        private string description;

        public int Id { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public int QuantityAvailable { get => quantityAvailable; set => quantityAvailable = value; }
        public string Status { get => status; set => status = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
    }
}

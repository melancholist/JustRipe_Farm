using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Fertiliser
    {
        private int id;
        private string fertiliserType;
        private decimal fertiliserQuantity;
        private string fertiliserCompany;

        public int Id { get => id; set => id = value; }
        public string FertiliserType { get => fertiliserType; set => fertiliserType = value; }
        public decimal FertiliserQuantity { get => fertiliserQuantity; set => fertiliserQuantity = value; }
        public string FertiliserCompany { get => fertiliserCompany; set => fertiliserCompany = value; }
    }
}

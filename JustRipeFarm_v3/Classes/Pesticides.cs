using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Pesticides
    {
        private int id;
        private string pesticideType;
        private decimal pesticideQuantity;
        private string company;

        public int Id { get => id; set => id = value; }
        public string PesticideType { get => pesticideType; set => pesticideType = value; }
        public decimal PesticideQuantity { get => pesticideQuantity; set => pesticideQuantity = value; }
        public string Company { get => company; set => company = value; }
    }
}

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
        private string pesticidesType;
        private decimal pesticideQauntity;
        private string company;

        public int Id { get => id; set => id = value; }
        public string PesticidesType { get => pesticidesType; set => pesticidesType = value; }
        public decimal PesticideQauntity { get => pesticideQauntity; set => pesticideQauntity = value; }
        public string Company { get => company; set => company = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    class Crop
    {
        private int id;
        private string type;
        private string variety;
        private string seedCompany;
        private string seedLotNumber;
        private string seedOrigin;
        private int plantSpacing;
        private int plantingDepth;
        private string plantingMethod;
        private int seedPerHole;
        private string additionalInformation;
        private bool organic;
        private bool gmo;

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Variety { get => variety; set => variety = value; }
        public string SeedCompany{ get => seedCompany; set => seedCompany = value; }
        public string SeedLotNumber { get => seedLotNumber; set => seedLotNumber = value; }
        public string SeedOrigin { get => seedOrigin; set => seedOrigin = value; }
        public int PlantSpacing { get => plantSpacing; set => plantSpacing = value; }
        public int PlantingDepth { get => plantingDepth; set => plantingDepth = value; }
        public string PlantingMethod { get => plantingMethod; set => plantingMethod = value; }
        public string AdditionalInformation { get => additionalInformation; set => additionalInformation = value; }
        public bool Organic { get => organic; set => organic = value; }
        public bool Gmo { get => gmo; set => gmo = value; }
        public int SeedPerHole { get => seedPerHole; set => seedPerHole = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class ServiceRecord
    {
        private int id;
        private string eqSerialNo;
        private string serviceType;
        private DateTime serviceDate;
        private string serviceDescription;

        public int Id { get => id; set => id = value; }
        public string EqSerialNo { get => eqSerialNo; set => eqSerialNo = value; }
        public DateTime ServiceDate { get => serviceDate; set => serviceDate = value; }
        public string ServiceType { get => serviceType; set => serviceType = value; }
        public string ServiceDescription { get => serviceDescription; set => serviceDescription = value; }
    }
}

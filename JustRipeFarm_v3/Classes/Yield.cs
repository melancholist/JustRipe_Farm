using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm_v3
{
    public class Yield
    {
        private int id;
        private string yieldType;
        private decimal quantity;
        private string storageUnitName;

        public int Id { get => id; set => id = value; }
        public string YieldType { get => yieldType; set => yieldType = value; }
        public decimal Quantity { get => quantity; set => quantity = value; }
        public string StorageUnitName { get => storageUnitName; set => storageUnitName = value; }
    }
}

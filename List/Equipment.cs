using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Equipment
    {
        public string Owner { get; set; }
        public string EquipmentName{ get; set; }

        public override string ToString()
        {
            return Owner.ToUpper() + " has a " + EquipmentName.ToUpper() + " in his/her bag!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troostwik.Domain
{
    public class Sale : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public string AdditionalInformation { get; set; }
        public double Sum { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}

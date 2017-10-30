using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Troostwik.Domain
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public int? SaleId { get; set; }
        public virtual Sale Sale { get; set; }
    }
}

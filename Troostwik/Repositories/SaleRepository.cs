using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Troostwik.Domain;

namespace Troostwik.Repositories
{
    public class SaleRepository : Repository<Sale>
    {
        public override List<Sale> GetAll()
        {
            return context.Sales.Include(x => x.Items).ToList();
        }
        public override Sale Read(int id)
        {
            return context.Sales.Include(x => x.Items).FirstOrDefault(x => x.Id == id);
        }
    }

}

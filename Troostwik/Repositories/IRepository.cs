using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Troostwik.Domain;

namespace Troostwik.Repositories
{
    interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        T Read(int id);
        void Update(T entity);
        void Delete(int id);

        List<T> GetAll();
        
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Troostwik.Context;
using Troostwik.Domain;

namespace Troostwik.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        internal ApplicationContext context;
        internal DbSet<T> dbSet;

        public Repository()
        {
            context = new ApplicationContext();
            dbSet = context.Set<T>();
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            var entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
        }

        public virtual List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual T Read(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}

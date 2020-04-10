using CEITeam.ECommerce.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Managers
{
    public class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        private readonly TContext context;
        private readonly DbSet<TEntity> set;
        public Repository(TContext context)
        {
            this.context = context;
            set = this.context.Set<TEntity>();
        }
        public virtual TEntity Add(TEntity entity)
        {
            set.Add(entity);
            return context.SaveChanges() > 0 ? entity : null;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return set;
        }

        public virtual List<TEntity> GetAllToList()
        {
            return set.ToList();
        }

        public virtual TEntity GetById(params object[] id)
        {
            return set.Find(id);
        }

        public virtual bool Remove(TEntity entity)
        {
            set.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public virtual bool Update(TEntity entity)
        {
            set.Update(entity);
            return context.SaveChanges() > 0;
        }
    }
}

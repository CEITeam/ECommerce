using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEITeam.ECommerce.Interfaces
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        List<TEntity> GetAllToList();
        TEntity GetById(params object[] id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
    }
}

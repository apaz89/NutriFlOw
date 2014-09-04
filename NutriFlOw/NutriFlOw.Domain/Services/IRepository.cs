using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NutriFlOw.Domain.Prueba;

namespace NutriFlOw.Domain.Services
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity Add(TEntity model, bool persist = false);
        TEntity Get(long id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();

        TEntity Update(TEntity model, bool persist = false);

        void Remove(long id, bool persist = false);
        void Remove(TEntity model, bool persist = false);

        void Save();
    }
}

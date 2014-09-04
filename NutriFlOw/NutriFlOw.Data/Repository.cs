using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using NutriFlOw.Domain.Prueba;
using NutriFlOw.Domain.Services;

namespace NutriFlOw.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private DbContext Context;
        private DbSet<TEntity> DBSet;

        public Repository(IDBContext context)
        {
            Context = context as DbContext;
            DBSet = Context.Set<TEntity>();
        }

        public TEntity Get(long id)
        {
            TEntity model = DBSet.Find(id);
            return model;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return DBSet.Where(predicate).AsEnumerable();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DBSet.AsEnumerable<TEntity>();
        }

        public TEntity Add(TEntity model, bool persist = false)
        {
            //model.Id = Guid.NewGuid();
            DBSet.Add(model);
            Save(persist);

            return model;
        }

        public TEntity Update(TEntity model, bool persist = false)
        {
            Context.Entry(model).State = EntityState.Modified;
            Save(persist);

            return model;
        }

        public void Remove(long id, bool persist = false)
        {
            TEntity model = DBSet.Find(id);
            Remove(model, persist);
        }

        public void Remove(TEntity model, bool persist = false)
        {
            if (model != null)
            {
                Context.Entry<TEntity>(model).State = EntityState.Deleted;
                Save(persist);
            }
        }

        public void Save()
        {
            Save(true);
        }

        private void Save(bool persist)
        {
            if (persist)
            {
                Context.SaveChanges();
            }
        }
    }

}

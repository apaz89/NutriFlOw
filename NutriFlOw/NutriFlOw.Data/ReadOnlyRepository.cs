using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NutriFlOw.Domain.Prueba;
using NutriFlOw.Domain.Services;

namespace NutriFlOw.Data
{
    public class ReadOnlyRepository<TType, TContext> : IReadOnlyRepository<TType>
        where TContext : ObjectContext, new()
        where TType : EntityObject
        {
            private readonly TContext _entity = new TContext();

            protected TContext Context
            {
                get { return this._entity; }
            }

            public TType Get(Expression<Func<TType, bool>> filter)
            {
                return this._entity.CreateObjectSet<TType>().SingleOrDefault(filter);
            }

            public ICollection<TType> GetAll()
            {
                return this._entity.CreateObjectSet<TType>().ToList();
            }
        }
}

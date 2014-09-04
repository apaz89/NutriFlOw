using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NutriFlOw.Domain.Prueba;
using NutriFlOw.Domain.Services;

namespace NutriFlOw.Data
{
    public class ReadOnlyRepository:IReadOnlyRepository
        {
            public T First<T>(Expression<Func<T, bool>> query) where T : class, IEntity
            {
                throw new NotImplementedException();
            }

            public T GetById<T>(long id) where T : class, IEntity
            {
                throw new NotImplementedException();
            }

            public IQueryable<T> Query<T>(Expression<Func<T, bool>> expression) where T : class, IEntity
            {
                throw new NotImplementedException();
            }
        }
}

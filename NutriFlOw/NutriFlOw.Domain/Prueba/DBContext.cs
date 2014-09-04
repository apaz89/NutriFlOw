using System.Data.Entity;
using NutriFlOw.Domain.Prueba;

namespace NutriFlOw.Domain
{
    public class DBContext:DbContext,IDBContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

            public DBContext()
            {
                
            }
    }
}

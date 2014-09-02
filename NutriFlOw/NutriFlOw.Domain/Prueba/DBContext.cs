using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutriFlOw.Domain.Prueba;

namespace NutriFlOw.Domain
{
    public class DBContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        
        public DBContext()
        {
                
        }
    }
}

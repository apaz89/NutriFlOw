using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutriFlOw.Domain.Migrations;
using NutriFlOw.Domain.Prueba;

namespace NutriFlOw.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario
            {
                FirstName = "Nadege",
                LastName = "Deroussen",
                Password = "CUIIIII",
                EMail = "lalalala",
                Id=1
            };

            using (var context = new DBContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }

            Console.Write("User saved !");
            Console.ReadLine();
        }
    }
}

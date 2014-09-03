using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using NutriFlOw.Domain;
using NutriFlOw.Domain.Prueba;
using NutriFlOw.Models;
using NutriFlOw.Models.Account;

namespace NutriFlOw.Infrastructure
{
    public class AutoMapperConfiguration
    {

        public static void Configure()
        {
            Mapper.CreateMap<UsuarioModel, Usuario>();
            Mapper.CreateMap<Usuario, UsuarioModel>();

            Mapper.CreateMap<LoginModel, Usuario>();
            Mapper.CreateMap<Usuario, LoginModel>();

        }

    }
}
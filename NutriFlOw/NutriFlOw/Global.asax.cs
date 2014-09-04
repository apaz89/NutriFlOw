using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Antlr.Runtime;
using AutoMapper;
using BootstrapMvcSample;
using BootstrapSupport;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using NutriFlOw.Data;
using NutriFlOw.Domain;
using NutriFlOw.Domain.Prueba;
using NutriFlOw.Domain.Services;
using NutriFlOw.Infrastructure;

namespace NutriFlOw
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : NinjectHttpApplication
    {
        //protected void Application_Start()
        //{
        //    AreaRegistration.RegisterAllAreas();

        //    WebApiConfig.Register(GlobalConfiguration.Configuration);
        //    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //    BootstrapSupport.BootstrapBundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);
        //    BootstrapMvcSample.ExampleLayoutsRouteConfig.RegisterRoutes(RouteTable.Routes);
        //    AutoMapperConfiguration.Configure();
        //}
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BootstrapBundleConfig.RegisterBundles(BundleTable.Bundles);
            ExampleLayoutsRouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfiguration.Configure();
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            //kernel.Load<NinjectModule>();
            //IDBContext dbContext = new DBContext();
            //kernel.Bind(typeof(IDBContext)).ToConstant(dbContext);
            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));

            kernel.Bind<DbContext>().To<DBContext>().InRequestScope();
            
            kernel.Bind<IMappingEngine>().ToConstant(Mapper.Engine);


            return kernel;
        }
    }
}
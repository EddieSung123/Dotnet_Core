using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCore_CRUD.Models.BLL;
using NetCore_CRUD.Models.DAL;
using NetCore_CRUD.Models.DTO;
using NetCore_CRUD.Repository.BLO;
using NetCore_CRUD.Repository.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NetCore_CRUD.Factory
{
    public class DIFactory : Autofac.Module
    {
        public static IConfiguration Configuration { get; set; }
        public DIFactory()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(x => Configuration.Get<AppConfig>())
          .As<IAppConfig>()
          .InstancePerLifetimeScope();

            builder.RegisterType<netcoreContext>().As<DbContext>().InstancePerLifetimeScope();

            builder.RegisterType<ProductDAO>().As<IProductDAO>();
            builder.RegisterType<ProductBLL>().As<IProductBLL>();
        }
    }
}

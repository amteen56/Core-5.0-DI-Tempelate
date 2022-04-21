using Core.Interface.DBContext;
using Core.Interface.Repo;
using Core.Interface.Service;
using Infra.DBContext;
using Infra.Repo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DI
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services, string constr)
        {
            //try
            //{
            //    if (string.IsNullOrWhiteSpace(OracleConfiguration.TnsAdmin))
            //    {
            //        OracleConfiguration.TnsAdmin = tnsPath;
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
            services.AddDbContext<AppDbContext>();
            services.AddScoped<IAppDbContext, AppDbContext>();
            services.AddScoped<IEFRepo>(x => new EFRepo(x.GetService<IAppDbContext>(), x.GetService<IAppLogger>()));
            services.AddScoped<IADORepo>(x => new ADORepo(constr));

        }
    }
}

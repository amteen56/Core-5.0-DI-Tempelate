using API.Filter;
using Core.Interface.Service;
using Infra.Logger;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DI
{
    public static class API_DI
    {
        public static void AddDIforAPI(this IServiceCollection services)
        {
            services.AddScoped<ValidationFilterAttribute>();
            services.AddScoped<IAppLogger>((options =>
           new AppLogger(
              new LoggerConfiguration()
                   .WriteTo.File("logs/app-Logs.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger()
              )));


        }
    }
}

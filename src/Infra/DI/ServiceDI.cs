using Core.Interface.Service;
using Infra.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DI
{
    public static class ServiceDI
    {
        public static void AddServices(this IServiceCollection services, string path)
        {
            services.AddScoped<IAuthService>(
               x => new AuthService(
                   x.GetService<IAppLogger>()
              ));
        }
    }
}

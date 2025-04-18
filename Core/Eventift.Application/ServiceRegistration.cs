using Eventift.Application.Abstractions.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventift.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ExportService>();
        }
    }
}

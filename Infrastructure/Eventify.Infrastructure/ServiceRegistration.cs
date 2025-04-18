using Eventift.Application.Abstractions.Services;
using Eventift.Application.Abstractions.Services.Concrete;
using Eventify.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService,FileService>();
            services.AddScoped<ITextService,TextService>();
        }
    }
}

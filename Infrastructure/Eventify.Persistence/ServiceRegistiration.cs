using Eventift.Application.Abstractions.Services;
using Eventify.Persistence.DbContexts;
using Eventify.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<EventifyDbContext>();
        }
    }
}

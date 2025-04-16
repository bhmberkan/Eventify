using Eventify.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Persistence.DbContexts
{
    public class EventifyDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        // ms sql postegro sql gibi bir sql kullanmak yerine efcore un sunduğu ınmemory özelliğini kullandık.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EventifyDb");
        }
    }
}

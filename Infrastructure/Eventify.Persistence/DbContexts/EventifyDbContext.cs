using Eventify.Domain.Common;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().OwnsOne(x => x.locaiton); // her event entitisinin bir tane locationu var 
            base.OnModelCreating(modelBuilder);
        }

        // ms sql postegro sql gibi bir sql kullanmak yerine efcore un sunduğu ınmemory özelliğini kullandık.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EventifyDb");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // interseption
            var data = ChangeTracker.Entries<EntityBase>();
            
            foreach (var entry in data)
            {
                if (entry.State == EntityState.Added)
                    entry.Entity.CreateDate = DateTime.UtcNow;
                
                else if (entry.State == EntityState.Modified)
                    entry.Entity.UpdateDate = DateTime.UtcNow;
                
              
            }


            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

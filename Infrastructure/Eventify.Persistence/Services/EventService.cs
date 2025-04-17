using Eventift.Application.Abstractions.Services;
using Eventift.Application.Dtos;
using Eventift.Application.RequestParameters;
using Eventify.Domain.Entities;
using Eventify.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Persistence.Services
{
    public class EventService : IEventService
    {
        private readonly EventifyDbContext _context;

        public EventService(EventifyDbContext context)
        {
            _context = context;
        }

        public async Task CreateEventAsync(CreateEventDTO createEventDTO)
        {
            if (createEventDTO is not null)
            {
                var newEvent = new Event()
                {
                    Title = createEventDTO.Title,
                    Date = createEventDTO.Date,
                    locaiton = createEventDTO.locaiton
                   
                };
                await _context.Events.AddAsync(newEvent);
                await _context.SaveChangesAsync();
            }
            else
                throw new NullReferenceException();
          

        }

        public async Task<IEnumerable<EventDTO>> GetAllEventAsync(Pagination pagination)
        {
           
            // return await _context.Events.ToListAsync(); // hepsine erişmek istiyoruz ondan patlıyor
            return await _context.Events
                .AsNoTracking()
                .Select(x => new EventDTO()
            {
                Title = x.Title,
                Date = x.Date,
                locaiton = x.locaiton
               // locaiton = x.locaiton  // valueobject kullanıyoruz ef nın kurallarına aykırı bir kullanım 
               // aşağıda çözüm yöntemi var ya da asnotracking kullanacağız. 
              /* locaiton = new Domain.ValueObjects.Locaiton()
               {
                   City = x.locaiton.City,
                   District = x.locaiton.District,
                   PostalCode = x.locaiton.PostalCode,
                   Street = x.locaiton.Street
               } */
            })
                .Skip(pagination.PageCount * pagination.ItemCount) // skip(5) yazarsak 6. dan sonrayı gösterir
                .Take(pagination.ItemCount)
                .ToListAsync();
            // pageCount: 0 , 1 ,2 diye ilerleyecek. 
        }
    }
}

using Eventift.Application.Dtos;
using Eventift.Application.RequestParameters;
using Eventify.Domain.Entities;
using Eventify.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventift.Application.Abstractions.Services
{
    public interface IEventService
    {
        Task CreateEventAsync(CreateEventDTO createEventDTO);

        Task<IEnumerable<EventDTO>> GetAllEventAsync(Pagination pagination);
    }
}

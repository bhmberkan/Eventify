using Eventift.Application.Abstractions.Services;
using Eventift.Application.Abstractions.Services.Concrete;
using Eventift.Application.Dtos;
using Eventift.Application.RequestParameters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly ExportService _exportService;

        public EventsController(IEventService eventService, ExportService exportService)
        {
            _eventService = eventService;
            _exportService = exportService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEvents([FromQuery] Pagination pagination)
        { // pagination complex olduğu için default olarak bodyden alacak o yüzden yukarıda query şeklinde aldık
            var events = await _eventService.GetAllEventAsync(pagination);
            return Ok(events);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateEventDTO createEventDTO)
        {
            await _eventService.CreateEventAsync(createEventDTO);

            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ExportEvents([FromQuery]Pagination pagination, string path)
        {
            var events = await _eventService.GetAllEventAsync(pagination);

            await _exportService.ExportEventsAsyns(events, path);

            return Ok();
        }
    }
}

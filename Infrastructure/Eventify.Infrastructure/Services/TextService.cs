using Eventift.Application.Abstractions.Services;
using Eventift.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Infrastructure.Services
{
    public class TextService : ITextService
    {
        public string FormatTextForEvent(IEnumerable<EventDTO> eventItems)
        {
            if (eventItems is null)
                throw new ArgumentNullException(nameof(eventItems));
               
            
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var eventItem in eventItems)
                {
                    if(eventItem is not null)
                    stringBuilder.AppendLine($"Event: {eventItem.Title} - Locaiton : {eventItem.locaiton} - Date: {eventItem.Date.ToString("HH:mm - dd/MM/yyyyy")} ");


                }
                return stringBuilder.ToString().TrimEnd();
            
        }
    }
}

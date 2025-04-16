using Eventify.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventift.Application.Dtos
{
    public class CreateEventDTO
    {
        public  string  Title { get; set; }
        public  DateTimeOffset Date { get; set; }
        public  Locaiton locaiton { get; set; }
    }
}

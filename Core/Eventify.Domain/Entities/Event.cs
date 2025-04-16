using Eventify.Domain.Common;
using Eventify.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Domain.Entities
{
    public class Event : EntityBase
    {
       
        public string Title { get; set; }
        public DateTimeOffset Date {  get; set; }


        public Locaiton locaiton { get; set; }
        // locaiton 
    }
}

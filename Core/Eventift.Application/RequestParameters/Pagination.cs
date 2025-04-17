using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventift.Application.RequestParameters
{
    public class Pagination
    {
        public int ItemCount { get; set; } = 5;
        public int PageCount { get; set; } = 0; 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Domain.Common
{
    public class EntityBase // <TKey> kullanarak guid cenerik yapilabilir 
    {
        
      //  public TKey Id { get; set; }
        public Guid Id { get; set; }

        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset? UpdateDate { get; set; } // boş geçilebilir
    }
}

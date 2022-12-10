using Library.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Domain.Entities
{
  public  class OrderDetail: AuditableBaseEntity
    {        
        public decimal Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}

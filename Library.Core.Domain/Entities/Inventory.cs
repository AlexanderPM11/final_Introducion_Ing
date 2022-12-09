using Library.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Domain.Entities
{
    public class Inventory: AuditableBaseEntity
    {
        public int Title { get; set; }
        public int BookId { get; set; }
        public string StckAvailability { get; set; }
        public string StckInitialAvailability { get; set; }

        ///
        public Book Book { get; set; }
    }
}

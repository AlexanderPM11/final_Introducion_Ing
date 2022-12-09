using Library.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Domain.Entities
{
   public class Author: AuditableBaseEntity
    {    
        public string Fisrtname { get; set; }
        public string Lastname { get; set; }
        public int BookId { get; set; }        
        public ICollection<Book> Books { get; set; }
    }
}

﻿using Library.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Domain.Entities
{
    public class Gender: AuditableBaseEntity
    {
        public string Description { get; set; }

        /// Fluent API
        public ICollection<Book> Books  { get; set; }

    }
}

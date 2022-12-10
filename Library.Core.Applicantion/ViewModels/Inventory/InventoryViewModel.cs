using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Applicantion.ViewModels.Inventory
{
    public class InventoryViewModel
    {
        public int BookId { get; set; }
        public int StckAvailability { get; set; }
        public int StckInitialAvailability { get; set; }
        public int Id { get; set; }

    }
}

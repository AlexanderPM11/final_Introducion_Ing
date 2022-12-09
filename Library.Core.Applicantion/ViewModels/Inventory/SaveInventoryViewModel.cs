using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Applicantion.ViewModels.Inventory
{
    public class SaveInventoryViewModel
    {
        public int Title { get; set; }
        public int BookId { get; set; }
        public string StckAvailability { get; set; }
        public string StckInitialAvailability { get; set; }
        public int Id { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Applicantion.ViewModels.OrderDatail
{
    public class OrderDetailViewModel
    {
        public string Quantity { get; set; }
        public string Subtotal { get; set; }
        public int BookId { get; set; }
        public int Id { get; set; }
    }
}

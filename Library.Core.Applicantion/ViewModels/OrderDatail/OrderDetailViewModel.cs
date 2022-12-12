using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Applicantion.ViewModels.OrderDatail
{
    public class OrderDetailViewModel
    {
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public int Id { get; set; }
        public int BookId { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
    }
}

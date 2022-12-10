using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Applicantion.ViewModels.OrderDatail
{
    public class SaveOrderDetailViewModel
    {
        [Required(ErrorMessage = "Introduzca una cantidad")]
        [Range(1 ,200,ErrorMessage ="La cantidad de libro debe estar en un rango de 1-200")]
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public int Id { get; set; }
        public int BookId { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}

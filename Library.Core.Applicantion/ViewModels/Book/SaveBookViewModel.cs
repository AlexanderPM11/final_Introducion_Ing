using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Applicantion.ViewModels.Book
{
   public class SaveBookViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string ISBNCode { get; set; }
        public int GenderId { get; set; }
        public int AuthorId { get; set; }
        public int PageNumber { get; set; }
        public bool IsOnlineAvailable { get; set; }
        public int PublicationYear { get; set; }
        public string ProductCondition { get; set; }
        public double Price { get; set; }

    }

}

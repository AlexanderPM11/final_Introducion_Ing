
using Library.Core.Applicantion.ViewModels.Author;
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Interfaces.Services
{
    public  interface IAuthrervices : IGenericService<SaveAuthorViewModel, AuthorViewModel, Author>
    {

    }
}

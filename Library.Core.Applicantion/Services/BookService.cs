using AutoMapper;
using Example.Core.Application.Interfaces.Repositories;
using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Services
{
   public class BookService: GenericServices<SaveBookViewModel, BookViewModel,Book>, IBookServices
   {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper) : base(bookRepository, mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }       
    }
}

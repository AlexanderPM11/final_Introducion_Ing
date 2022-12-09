using AutoMapper;
using Example.Core.Application.Interfaces.Repositories;
using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Author;
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Services
{
   public class AuthorService : GenericServices<SaveAuthorViewModel, AuthorViewModel,Author>, IAuthrervices
   {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorService(IAuthorRepository authorRepository, IMapper mapper) : base(authorRepository, mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }       
    }
}

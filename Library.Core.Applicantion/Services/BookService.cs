using AutoMapper;
using Example.Core.Application.Interfaces.Repositories;
using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Applicantion.ViewModels.Inventory;
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
        readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IInventoryRepository inventoryRepository, IMapper mapper) : base(bookRepository, mapper)
        {
            _bookRepository = bookRepository;
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }


        public async override Task<SaveBookViewModel> Add(SaveBookViewModel vm)
        {

            var result = await base.Add(vm);
            ///Aqui se puede utilizar autoMapper
            Inventory inventory = new Inventory()
            {
                BookId = result.Id,
                StckAvailability = 1000

            };
            await _inventoryRepository.AddAsync(inventory);

            return result;
        }
    }
}

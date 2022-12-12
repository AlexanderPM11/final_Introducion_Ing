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
   public class InventoryService : GenericServices<SaveInventoryViewModel, InventoryViewModel,Inventory>, IInventoryServices
   {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;
        public InventoryService(IInventoryRepository inventoryRepository, IMapper mapper) : base(inventoryRepository, mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }
    }
}

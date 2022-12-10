using AutoMapper;
using Example.Core.Application.Interfaces.Repositories;
using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Applicantion.ViewModels.OrderDatail;
using Library.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Services
{
   public class OrderDetailService: GenericServices<SaveOrderDetailViewModel, OrderDetailViewModel,OrderDetail>, IDetailOrderServices
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IInventoryRepository _inventory;
        private readonly IBookRepository  _bookRepository;
        private readonly IMapper _mapper;
        public OrderDetailService(IOrderDetailRepository orderDetailRepository, IBookRepository bookRepository,IMapper mapper, IInventoryRepository inventory) : base(orderDetailRepository, mapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _inventory = inventory;
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async override Task<SaveOrderDetailViewModel> Add(SaveOrderDetailViewModel vm)
        {
            
            Inventory inventory = await _inventory.GetByIdAsync(vm.BookId);
            if (inventory != null)
            {
                int countBookInInventory = inventory.StckAvailability;
                if (vm.Quantity > countBookInInventory)
                {
                    vm.Status = false;
                    vm.Message = "La cantidad de libro disponible es inferior a la solicitada";
                    return (vm);
                }
                if (vm.Quantity < 0)
                {
                    vm.Status = false;
                    vm.Message = "La cantidad de libro debe ser mayor a 0";
                    return (vm);
                }
                if (vm.Quantity > 200)
                {
                    vm.Status = false;
                    vm.Message = "La cantidad de libro no puede ser mayor a 200";
                    return (vm);
                }
            }
            // Restar la cantidad de libro disponible en inventario
            inventory.StckAvailability -= vm.Quantity;
            // calcular subTotal
            var book = await _bookRepository.GetByIdAsync(vm.BookId);
            if (vm.Quantity > 0)
            {
                vm.Subtotal = vm.Quantity * book.Price;
            }
            else
            {
                vm.Subtotal = book.Price;
            }
            await _inventory.UpdateAsync(inventory.Id, inventory);
            
            await base.Add(vm);
            vm.Status = true;
            vm.Message = "Libro vendido con exito";

            return vm;
        }


    }
}

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
        private readonly IMapper _mapper;
        public OrderDetailService(IOrderDetailRepository orderDetailRepository, IMapper mapper) : base(orderDetailRepository, mapper)
        {
            _orderDetailRepository = orderDetailRepository;
            _mapper = mapper;
        }       
    }
}

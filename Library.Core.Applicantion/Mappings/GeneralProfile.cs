using AutoMapper;
using Library.Core.Applicantion.ViewModels.Author;
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Applicantion.ViewModels.Gender;
using Library.Core.Applicantion.ViewModels.Inventory;
using Library.Core.Applicantion.ViewModels.OrderDatail;
using Library.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Applicantion.Mappings
{
    class GeneralProfile:Profile
    {
        public GeneralProfile()
        {
            

            CreateMap<Book, BookViewModel>().ReverseMap();
            CreateMap<Book, SaveBookViewModel>().ReverseMap();

            CreateMap<Inventory, SaveInventoryViewModel>().ReverseMap();
            CreateMap<Inventory, InventoryViewModel>().ReverseMap();

            CreateMap<Gender, SaveGenderViewModel>().ReverseMap();
            CreateMap<Gender, GenderViewModel>().ReverseMap();

            CreateMap<Author, SaveAuthorViewModel>().ReverseMap();
            CreateMap<Author, AuthorViewModel>().ReverseMap();

            CreateMap<OrderDetail, SaveOrderDetailViewModel>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailViewModel>().ReverseMap();


           



        }

    }
}

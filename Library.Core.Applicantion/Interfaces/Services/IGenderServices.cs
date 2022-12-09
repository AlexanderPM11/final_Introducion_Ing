
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Applicantion.ViewModels.Gender;
using Library.Core.Applicantion.ViewModels.OrderDatail;
using Library.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Interfaces.Services
{
    public  interface IGenderServices : IGenericService<SaveGenderViewModel, GenderViewModel, Gender>
    {

    }
}

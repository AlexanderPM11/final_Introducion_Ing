using AutoMapper;
using Example.Core.Application.Interfaces.Repositories;
using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Book;
using Library.Core.Applicantion.ViewModels.Gender;
using Library.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Services
{
   public class GenderService: GenericServices<SaveGenderViewModel, GenderViewModel,Gender>, IGenderServices
   {
        private readonly IGenderRepository _genderRepository;
        private readonly IMapper _mapper;
        public GenderService(IGenderRepository genderRepository, IMapper mapper) : base(genderRepository, mapper)
        {
            _genderRepository = genderRepository;
            _mapper = mapper;
        }       
    }
}

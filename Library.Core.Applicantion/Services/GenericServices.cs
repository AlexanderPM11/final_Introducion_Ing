using AutoMapper;
using Example.Core.Application.Interfaces.Repositories;
using Example.Core.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Services
{
   public class GenericServices<SaveViewModel, ViewModel,Model> : IGenericService<SaveViewModel, ViewModel, Model>
        where SaveViewModel : class
        where ViewModel : class
        where Model : class
   {
        private readonly IGenericRepository<Model> _repository;
        private readonly IMapper _mapper;
        public GenericServices(IGenericRepository<Model> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<SaveViewModel> Add(SaveViewModel vm)
        {
            Model entity = _mapper.Map<Model>(vm);

            entity = await _repository.AddAsync(entity);
            SaveViewModel student = _mapper.Map<SaveViewModel>(entity);
            return student;
        }
        public virtual async Task UpdateAsync(int id,SaveViewModel vm)
        {
            Model entity = _mapper.Map<Model>(vm);
            await _repository.UpdateAsync(id, entity);
        }
        public virtual async Task<SaveViewModel> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            SaveViewModel vm = _mapper.Map<SaveViewModel>(entity);
            return vm;
        }
        public virtual async Task DeleteAsync(int id)
        {            
            await _repository.DeleteAsync(id);
        }
        public virtual async Task<List<ViewModel>> GetAllAsync()
        {
            var entityList = await _repository.GetAllAsync();
            var vm = _mapper.Map<List<ViewModel>>(entityList);
            return vm;
        }


    }
}

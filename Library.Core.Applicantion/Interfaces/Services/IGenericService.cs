using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Interfaces.Services
{
   public interface IGenericService<SaveViewModel, ViewModel, Model>
        where SaveViewModel : class 
        where ViewModel : class 
        where Model:class 
   {
        Task<SaveViewModel> Add(SaveViewModel vm);
        Task UpdateAsync(int id, SaveViewModel vm);
        Task<List<ViewModel>> GetAllAsync();
        Task<SaveViewModel> GetByIdAsync(int id);
        Task DeleteAsync(int id);
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Task<Entity> AddAsync(Entity entity);
        Task UpdateAsync(int id, Entity entity);
        Task<List<Entity>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<Entity> GetByIdAsync(int id);
    }
}

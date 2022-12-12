using Example.Core.Application.Interfaces.Repositories;
using Library.Core.Applicantion.ViewModels.Inventory;
using Library.Core.Domain.Entities;
using Library.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistence.Repositories
{
    public class InventoryRepository : GenericRepository<Inventory>, IInventoryRepository
    {
        private readonly ApplicationContext _dbContext;

        public InventoryRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual async Task<Inventory> GetByBookIdAsync(int bookId)
        {
            var entity = await _dbContext.Set<Inventory>().FirstOrDefaultAsync(x => x.BookId == bookId);
            return entity;
        }
    }
}

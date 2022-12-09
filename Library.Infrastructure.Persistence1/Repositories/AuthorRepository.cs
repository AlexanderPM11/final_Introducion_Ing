using Example.Core.Application.Interfaces.Repositories;
using Library.Core.Domain.Entities;
using Library.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistence.Repositories
{
    public class AuthorRepository: GenericRepository<Author>, IAuthorRepository
    {
        private readonly ApplicationContext _dbContext;

        public AuthorRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}

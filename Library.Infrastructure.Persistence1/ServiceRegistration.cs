using Example.Core.Application.Interfaces.Repositories;
using Library.Infrastructure.Persistence.Context;
using Library.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistence
{
   public static class ServiceRegistration
   {
        public static void AddPersistenceInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ApplicationContext>(options=>options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"), m => m.MigrationsAssembly
                (typeof(ApplicationContext).Assembly.FullName)));

            #region repositories
            service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddTransient<IBookRepository, BookRepository>();
            service.AddTransient<IOrderDetailRepository, DetailOrderRepository>();
            service.AddTransient<IInventoryRepository, InventoryRepository>();
            service.AddTransient<IAuthorRepository, AuthorRepository>();
            service.AddTransient<IGenderRepository, GenderRepository>();
            #endregion

        }



    }
}

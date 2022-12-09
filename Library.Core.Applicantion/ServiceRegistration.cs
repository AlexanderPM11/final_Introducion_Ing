using Example.Core.Application.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Application.Services
{
    public static class ServiceRegistration
    {

        public static void AddApplicationLayer(this IServiceCollection service,IConfiguration configuration)
        {
            #region automapper
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            #endregion

            #region services
            service.AddTransient(typeof(IGenericService<,,>), typeof(GenericServices<,,>));
            service.AddTransient<IBookServices, BookService>();
            service.AddTransient<IInventoryServices, InventoryService>();
            service.AddTransient<IDetailOrderServices, OrderDetailService>();
            service.AddTransient<IAuthrervices, AuthorService>();
            service.AddTransient<IGenderServices, GenderService>();
            #endregion
        }
    }
}

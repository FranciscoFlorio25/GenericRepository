using GenericRepository.Application.Interface;
using GenericRepository.Application.Interface.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Application
{
    public static class DependencyInyection
    {
        public static IServiceCollection AppGenericRepositoryApplication(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}

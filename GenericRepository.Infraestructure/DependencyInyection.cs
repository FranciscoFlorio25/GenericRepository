using GenericRepository.Application.Data;
using GenericRepository.Application.Repository;
using GenericRepository.Domain.Entities;
using GenericRepository.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Infraestructure
{
    public static class DependencyInyection
    {
        public static IServiceCollection AppGenericRepositoryInfraestructure (this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<IGenericRepositoryContext, GenericRepositoryContext>(o =>
                o.UseSqlServer(configuration.GetConnectionString(name: "Default")));

            service.AddScoped<IRepositoryConnection<Customer>, RepositoryConnection<Customer>>();

            service.AddScoped <ICustomerRepository<Customer>,CustomerRepository>();

            return service;
        }
    }
}

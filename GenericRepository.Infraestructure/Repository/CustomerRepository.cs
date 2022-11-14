using GenericRepository.Application.Repository;
using GenericRepository.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Infraestructure.Repository
{
    internal class CustomerRepository : ICustomerRepository<Customer>, IRepositoryConnection<Customer>
    {
        public readonly GenericRepositoryContext _context;

        public CustomerRepository(GenericRepositoryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task InsertAsync(Customer type)
        {
            _context.Add(type);
            await _context.SaveChangesAsync();
        }
    }
}

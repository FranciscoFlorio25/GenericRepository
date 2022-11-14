using GenericRepository.Application.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Infraestructure.Repository
{
    internal class RepositoryConnection<T>:IRepositoryConnection<T> where T : class
    {
        public readonly GenericRepositoryContext _context;
        public RepositoryConnection(GenericRepositoryContext context)
        { 
            _context = context;
        }

        public async Task InsertAsync(T type)
        {
            _context.Add(type);
            await _context.SaveChangesAsync();
        }

    }
}

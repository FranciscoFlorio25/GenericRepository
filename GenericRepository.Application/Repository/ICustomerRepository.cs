using GenericRepository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Application.Repository
{
    public interface ICustomerRepository<T>: IRepositoryConnection<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
    }
}

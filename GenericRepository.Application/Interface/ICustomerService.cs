using GenericRepository.Application.DTO;
using GenericRepository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Application.Interface
{
    public interface ICustomerService
    {
        public Task CreateNewCustomerAync(CustomerDTO customer);
        public Task<IEnumerable<CustomerDTO>> GetAllCustomerAync();
    }
}

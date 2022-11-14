using GenericRepository.Application.DTO;
using GenericRepository.Application.Repository;
using GenericRepository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Application.Interface.Internal
{
    internal class CustomerService : ICustomerService
    {
        public readonly ICustomerRepository<Customer> _repository;
        public CustomerService(ICustomerRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task CreateNewCustomerAync(CustomerDTO customer)
        {
            Customer newCustomer = new
                (
                customer.firstName,
                customer.secondName,
                customer.lastName,
                customer.creationTime,
                customer.email,
                customer.phoneNumber,
                customer.adress
                );
            await _repository.InsertAsync(newCustomer);
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllCustomerAync()
        {
            IEnumerable<Customer> customer = await _repository.GetAllAsync();

            IEnumerable<CustomerDTO> result = customer.Select(x =>
            new CustomerDTO(
                x.FirstName,
                x.SecondName,
                x.LastName,
                x.CreationTime,
                x.Email,
                x.PhoneNumber,
                x.Adress
                ));

            return result;
        }
    }
}

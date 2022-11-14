using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Domain.Entities
{
    public class Customer
    {
        public Customer(string firstName, string? secondName, string lastName, DateTime creationTime,
            string email,string phoneNumber, string? adress)
        {
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            CreationTime = creationTime;
            Email = email;
            PhoneNumber = phoneNumber;
            Adress = adress;
        }

        public int id { get; set; }
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationTime { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? Adress { get; set; }

    }
}

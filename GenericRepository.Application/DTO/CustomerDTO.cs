using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Application.DTO
{
    public record CustomerDTO(string firstName,
        string? secondName,
        string lastName,
        DateTime creationTime,
        string email,
        string phoneNumber,
        string? adress);
}

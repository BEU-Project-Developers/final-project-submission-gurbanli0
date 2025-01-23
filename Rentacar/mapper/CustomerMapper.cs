using System.Security.Cryptography;
using System.Text;
using Rentacar.domain.entity;
using Rentacar.model.dto;
using Rentacar.model.dto.request;

namespace Rentacar.mapper
{
    public class CustomerMapper
    {
        public CustomerDto ToDto(Customer entity)
        {
            return new CustomerDto
            {
                Id = entity.Id,
                Username = entity.Username,
                Name = entity.Name,
            };
        }

        public Customer ToEntity(CustomerCreateRequest request)
        {
            return new Customer
            {
                Username = request.Username,
                Name = request.Name,
                Password = HashPassword(request.Password)
            };
        }

        public string HashPassword(string password)
        {
            var inputBytes = Encoding.UTF8.GetBytes(password);
            var inputHash = SHA256.HashData(inputBytes);
            return Convert.ToHexString(inputHash);
        }
    }
}

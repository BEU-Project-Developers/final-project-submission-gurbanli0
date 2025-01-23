using System.ComponentModel.DataAnnotations;
using Rentacar.domain;
using Rentacar.exception;
using Rentacar.mapper;
using Rentacar.model.dto;
using Rentacar.model.dto.request;

namespace Rentacar.service
{
    public class CustomerService
    {
        private readonly AppDbContext _context = new();

        private readonly CustomerMapper _mapper = new();

        public CustomerDto Create(CustomerCreateRequest request)
        {
            Validator.ValidateObject(request, new ValidationContext(request), true);

            if (ExistsByUsername(request.Username))
                throw new AlreadyExistsException($"Username already exists with username: {request.Username}");

            if (request.Password != request.ConfirmPassword)
                throw new ValidationException("Passwords do not match");

            var customer = _mapper.ToEntity(request);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return _mapper.ToDto(customer);
        }

        private bool ExistsByUsername(string username)
        {
            return _context.Customers.Any(p => p.Username == username);
        }

        public CustomerDto Login(CustomerLoginRequest request)
        {
            var customer = _context.Customers.FirstOrDefault(p => p.Username == request.Username);
            if (customer == null)
                throw new ValidationException("Invalid username or password");

            if (customer.Password != _mapper.HashPassword(request.Password))
            {
                throw new ValidationException("Invalid username or password");
            }

            return _mapper.ToDto(customer);
        }
    }
}

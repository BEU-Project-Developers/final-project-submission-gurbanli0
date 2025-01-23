
using Microsoft.EntityFrameworkCore;
using Rentacar.domain;
using Rentacar.domain.entity;
using Rentacar.exception;
using Rentacar.mapper;
using Rentacar.model.dto;

namespace Rentacar.service
{
    public class BookingService
    {
        private readonly AppDbContext _context = new();
        private readonly BookingMapper _mapper = new();

        public BookingDto CreateCarBooking(int carId)
        {
            var car = _context.Cars.Find(carId);

            if (car == null)
                throw new NotFoundException($"Car not found with id {carId}");
            if (car.AvailableCars == 0)
                throw new BadRequestException("There are no available cars for rent");

            car.AvailableCars--;
            _context.Cars.Update(car);

            var bookingEntity = new BookingEntity
            {
                Customer = FormsHelper.CURRENT_CUSTOMER.Username,
                Id = car.Id,
                IsActive = true
            };
            _context.Bookings.Add(bookingEntity);

            _context.SaveChanges();

            return _mapper.ToDto(bookingEntity);
        }

        public List<BookingDto> ShowMyCarBookings()
        {
            return _context.Bookings
                .Where(b => b.Customer == FormsHelper.CURRENT_CUSTOMER.Username)
                .Select(b => _mapper.ToDto(b))
                .ToList();
        }

        public List<BookingDto> ShowActiveCarBookings()
        {
            return _context.Bookings
                .Where(b => b.Customer == FormsHelper.CURRENT_CUSTOMER.Username && b.IsActive)
                .Select(b => _mapper.ToDto(b))
                .ToList();
        }

        public void UpdateCarBookingsStatus()
        {
            _context.Bookings
            .Join(_context.Cars,
                b => b.CarId,
                c => c.Id,
                (b, c) => new { Booking = b, Car = c })
            .Where(bc => bc.Booking.IsActive && bc.Car.AvailableCars < 1)
            .Select(bc => bc.Booking)
            .ExecuteUpdate(b => b.SetProperty(entity => entity.IsActive, false));
        }
        public void CancelCarBooking(int carBookingId)
        {
            var carBooking = _context.Bookings.Find(carBookingId);

            if (carBooking == null || carBooking.Customer != FormsHelper.CURRENT_CUSTOMER.Username)
                throw new NotFoundException($"Car booking not found with id {carBookingId}");

            if (!carBooking.IsActive)
                throw new BadRequestException("This car booking is not active");

            carBooking.IsActive = false;
            _context.Bookings.Update(carBooking);
            _context.SaveChanges();
        }
    }
}

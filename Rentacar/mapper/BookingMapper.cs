using Rentacar.domain;
using Rentacar.domain.entity;
using Rentacar.model.dto;

namespace Rentacar.mapper
{
    public class BookingMapper
    {
        public BookingDto ToDto(BookingEntity bookingEntity)
        {
            AppDbContext context = new();
            var car = context.Cars.Find(bookingEntity.CarId);

            return new BookingDto
            {
                BookingId = bookingEntity.Id,
                CarId = bookingEntity.CarId,
                From = car.From,
                To = car.To,
                BookingStatus = bookingEntity.IsActive ? "Active" : "Inactive"
            };
        }
    }
}

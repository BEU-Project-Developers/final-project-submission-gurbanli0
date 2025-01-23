using Rentacar.domain;
using Rentacar.exception;
using Rentacar.mapper;
using Rentacar.model.dto.request;
using Rentacar.model.dto;

namespace Rentacar.service
{
    public class CarService
    {
        private readonly AppDbContext _context = new();
        private readonly CarMapper _mapper = new();

        public List<CarDto> ShowAvailableCarsIn24Hours()
        {
            var currentTime = DateTime.UtcNow;
            var futureTime = currentTime.AddHours(24);

            return _context.Cars
                .Where(c => c.DateTime >= currentTime && c.DateTime <= futureTime)
                .Select(c => _mapper.ToDto(c))
                .ToList();
        }

        public CarDto GetCarById(int id)
        {
            var car = _context.Cars.Find(id);
            if (car == null)
                throw new NotFoundException($"Car not found with id: {id}");

            return _mapper.ToDto(car);
        }

        public List<CarDto> SearchCars(CarSearchRequest request, bool dateChecked)
        {
            var startOfDay = request.Date.ToDateTime(new TimeOnly(0, 0), DateTimeKind.Utc);
            var endOfDay = request.Date.ToDateTime(new TimeOnly(23, 59, 59), DateTimeKind.Utc);

            return _context.Cars
                .Where(f => f.From == request.From &&
                            f.To == request.To &&
                            (!dateChecked || f.DateTime >= startOfDay && f.DateTime <= endOfDay) &&
                            f.AvailableSeats >= request.NumOfPassengers)
                .Select(f => _mapper.ToDto(f))
                .ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rentacar.domain.entity;
using Rentacar.model.dto;

namespace Rentacar.mapper
{
    public class CarMapper
    {
        public CarDto ToDto(CarEntity carEntity)
        {
            return new CarDto
            {
                Id = carEntity.Id,
                Make = carEntity.Make,
                Model = carEntity.Model,
                Year = carEntity.Year
            };
        }
    }
}

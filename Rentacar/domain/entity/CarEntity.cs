using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.domain.entity
{
    public class CarEntity
    {

        [Key]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double RentalPricePerDay { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DateTime { get; set; }
        public int AvailableCars { get; set; }
        public int AvailableSeats { get; set; }
        public bool IsAvailable { get; internal set; }
    }
}

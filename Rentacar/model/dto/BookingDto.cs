using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.model.dto
{
    public class BookingDto
    {

        public int BookingId { get; set; }
        public int CarId { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string BookingStatus { get; set; }
    }
}

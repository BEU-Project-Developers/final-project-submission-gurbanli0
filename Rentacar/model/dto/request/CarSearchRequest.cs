using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.model.dto.request
{
    public class CarSearchRequest(string make, string model, DateOnly date, int? year)
    {
        public string From { get; } = make?.ToUpper(); 
        public string To { get; } = model?.ToUpper();
        public int? Year { get; } = year;
        public string Make { get; } = make?.ToUpper();
        public string Model { get; } = model?.ToUpper();
        public DateOnly Date { get; } = date;
        public int NumOfPassengers { get; set; }
    }
}

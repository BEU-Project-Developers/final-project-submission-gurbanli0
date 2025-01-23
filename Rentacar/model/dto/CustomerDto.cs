using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.model.dto
{
    public record CustomerDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
    }
}

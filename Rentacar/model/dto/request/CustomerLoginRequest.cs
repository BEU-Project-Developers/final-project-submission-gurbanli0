using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.model.dto.request
{
    public class CustomerLoginRequest
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}

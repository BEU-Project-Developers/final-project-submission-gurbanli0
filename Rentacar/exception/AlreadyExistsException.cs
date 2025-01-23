using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.exception
{
    public class AlreadyExistsException : Exception
    {
        public AlreadyExistsException() { }

        public AlreadyExistsException(string message) : base(message) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    public class ZeroNotAllowedException: Exception
    {
        public ZeroNotAllowedException(string message) : base(message) { }

        public override string ToString()
        {
            return $"Custom Exception {Message}";
        }
    }
}

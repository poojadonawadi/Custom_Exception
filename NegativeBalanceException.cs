using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    internal class NegativeBalanceException:Exception
    {
        public NegativeBalanceException(string message):base(message) { }

        public override string ToString()
        {
            return $"{Message}";
        }
    }
}

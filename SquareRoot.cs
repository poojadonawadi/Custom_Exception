using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    internal class SquareRoot
    {
        public static void GetSqareRoot(int num)
        {
            try
            {
                if(num <= 0)
                {
                    throw new ZeroNotAllowedException("Zero or less than zero is not allowed");
                }
                double result = Math.Sqrt(num);
                Console.WriteLine($"The square root of {num} is {result}");
            }
            catch(ZeroNotAllowedException ex)
            {
                Console.WriteLine(ex.ToString());
            }               
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    internal class ValidateAge
    {
        public static void CheckEligibility(int age)
        {
            try
            {
                if(age < 18)
                {
                    throw new InvalidAgeException("Not eligible to vote until age become 18");
                }
                else
                {
                    Console.WriteLine("Eligible to vote");
                }
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

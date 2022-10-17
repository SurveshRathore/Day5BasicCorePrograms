using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP6QR
    {
        public void ComputeQuotientRemainder()
        {
            int number = 123;
            int divisor = 2;

            int quotient = 123 / 2;
            int remainder = 123 % 2;

            Console.WriteLine("The Quotient of the number {0} by divisor {1} is: {2}", number, divisor, quotient);
            Console.WriteLine("The Remainder of the number {0} by divisor {1} is: {2}", number, divisor, remainder);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP10LargestNumber
    {
        public void findLargestnum (int num1, int num2, int num3)
        {
            if( (num1 > num2) && (num1 > num3) )
            {
                Console.WriteLine(num1 + " is the largest number.");
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine(num2 + " is the largest number.");
            }
            else
            {
                Console.WriteLine(num3 + " is the largest number.");
            }

        }
    }
}

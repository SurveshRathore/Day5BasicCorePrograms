using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP8EvenOdd
    {
        public void findEvenOdd(int num)
        {
            if(num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " is the even number.");
                }
                else
                {
                    Console.WriteLine(num + " is the odd number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP7Swap
    {
        public void SwapNum ()
        {
            Console.Write("Enter the First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping, The First Number is {0} and the second number is {1}", num1, num2);
        }
    }
}

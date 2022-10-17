using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP2LeapYear
    {
        public void determineLeapYear (int year)
        {
            int digit = year.ToString().Length;
            if(digit != 4)
            {
                Console.WriteLine("Not a 4 digit number");
            }
            if(year % 100 == 0)
            {
                if(year % 400 == 0)
                {
                    Console.WriteLine(year + " is a leap year");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year");
                }
            }
            else if( year % 4 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
        }
    }
}

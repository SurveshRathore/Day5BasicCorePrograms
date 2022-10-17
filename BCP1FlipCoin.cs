using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP1FlipCoin
    {
        public void flipCoin(int flipTimes)
        {
            
            int headCount = 0;
            int tailCount = 0;
            double headPercentage = 0.0;
            double tailPercentage = 0.0;
            Random random = new Random();
            for (int i = 0; i < flipTimes; i++)
            {
                double flip = random.NextDouble();
                Console.WriteLine("flip value: "+flip);
                if (flip >= 0.5)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }
            headPercentage = (double) headCount / flipTimes * 100;
            tailPercentage = (double) tailCount / flipTimes * 100;
            Console.WriteLine("Percentage of Head {0}%", headPercentage);
            Console.WriteLine("Percentage of Tails {0}%", tailPercentage);
        }
    }
}

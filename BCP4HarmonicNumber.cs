using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP4HarmonicNumber
    {
        public void computeHarmonicNum(int N)
        {
            double harmonicValue = 0.0;
            if(N == 0)
            {
                Console.WriteLine("Unable to compute the Harmonic number.");
            }
            else
            {
                for (int i = 1; i < N; i++)
                {
                    harmonicValue += (1.0 / i);
                }
                Console.WriteLine("The {0}th Harmonic value is: {1}",N,harmonicValue);
            }
        }
    }
}

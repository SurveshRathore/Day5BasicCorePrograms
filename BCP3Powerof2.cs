using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP3Powerof2
    {
        public void generatePowerOf2 (int N)
        {
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("2 * {0} = {1}", i, Math.Pow(2,i));
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP9VowelConsonant
    {
        public void checkAlpVoCons(char alpha)
        {
            //convert the character to uppercase
            alpha = char.ToUpper(alpha);

            if (alpha == 'A' || alpha == 'E' || alpha == 'I' || alpha == 'O' || alpha == 'U')
            {
                Console.WriteLine("Alphabet {0} is a vowel.", alpha);
            }
            else
            {
                Console.WriteLine("Alphabet {0} is a Consonant.", alpha);
            }
        }
    }
}

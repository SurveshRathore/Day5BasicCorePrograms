using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCoreProgram
{
    internal class BCP5Factor
    {
        public void printPrimeFactor(int N)
        {
            //variable to check the prime status of a number
            bool prime = false;
            
            Console.WriteLine("The prime factor of {0} are: ", N);
            if(N % 2 == 0)
            {
                //display the prime factor 2
                Console.Write(2 + " ");
            }
            //find the factor of N
            for (int j =2; j<N;j++)
            {
                //find whether the j is a prime number or not
                for (int i = 2; i*i <= j; i++)
                {
                    //when j is divisible 
                    if (j % i == 0)
                    {
                        prime = false;
                        //stop the loop
                        break;

                    }
                    else
                    {
                        prime = true;
                    }
                }
                //when N is divisible by a prime number
                if ( prime == true && N%j == 0)
                {
                    //display the prime factor of N
                    Console.Write(j + " ");
                }
            }   

        }
    }
}

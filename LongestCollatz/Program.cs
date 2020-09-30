using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            //            The following iterative sequence is defined for
            //the set of positive integers:

            //n → n / 2(n is even)
            //n → 3n + 1(n is odd)

            //Using the rule above and starting with 13, we
            //generate the following sequence:
            //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

            //It can be seen that this sequence(starting at 13
            //and finishing at 1) contains 10 terms.Although it
            //has not been proved yet(Collatz Problem), it is
            //thought that all starting numbers finish at 1.

            //Which starting number, under one thousand, produces
            //the longest chain ?

            //NOTE : Once the chain starts the terms are allowed
            //to go above one thousand.
            int numberOfDigits = 0;
            int iteration = 0;
            int iterationTracker = 0;
            for (int i = 2; i < 1000; i++)
            {
                int innerLoopTracker = 1;
                iteration = i;

                while (iteration != 1)
                {
                    if (iteration % 2 == 0)
                    {
                        iteration /= 2;
                    }
                    else
                    {
                        iteration = iteration * 3 + 1;
                    }
                    innerLoopTracker++;//counter for number of digits
                }//end while
                if (innerLoopTracker > numberOfDigits)//compares old value to new value
                {
                    numberOfDigits = innerLoopTracker;//holds new value 
                    iterationTracker = i;//holds the iteration the for loop was on.
                }

            }//end for loop

            Console.WriteLine(iterationTracker);

        }
    }
}

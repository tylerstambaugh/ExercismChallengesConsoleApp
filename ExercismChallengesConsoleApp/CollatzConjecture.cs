using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismChallengesConsoleApp
{

    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException("number");
            int x = number;
            int steps = 0;
            if (x > 0)
            {
                while (x != 1)
                {
                    steps++;
                    if (x % 2 == 0)
                        x = x / 2;
                    else
                    {
                        x = (x * 3) + 1;
                    }
                }
            }
            return steps;
            // if n is even, divide by 2

            //if n is odd, multiple by 3 and add 1

            //repeat until 1
        }


    }
}


//The Collatz Conjecture or 3x+1 problem can be summarized as follows:

//Take any positive integer n. If n is even, divide n by 2 to get n / 2. If n is odd, multiply n by 3 and add 1 to get 3n + 1. Repeat the process indefinitely. The conjecture states that no matter which number you start with, you will always reach 1 eventually.

//Given a number n, return the number of steps required to reach 1.

//Examples
//Starting with n = 12, the steps would be as follows:

//12
//6
//3
//10
//5
//16
//8
//4
//2
//1
//Resulting in 9 steps. So for input n = 12, the return value would be 9.
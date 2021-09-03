using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Problems
{
    //Instructions
    /*
     * Your method takes in two arguments:
     * 1. father's current age (years)
     * 2. Son's current age (years).
     * 
     * Calculate how many years ago the father was twice as old as his son, 
     * or in how many years he will be twice as old.
 */
    class TwiceAsOld
    {
        public static int TwiceAsOldProblem (int dadYears, int sonYears)
        {
            return Math.Abs (dadYears - (sonYears * 2));
        }
    }
}

//Walkthrough.

/*
 This one should be relatively self-explanitory.

To calculate how many years ago the father was twice as old as his son,
I need to double the son's age and weigh that against the father's age.

In many cases, this will give me the solution I need.

But what if the father is 40 and his son is 3?

I would double the son's age, making it 6, then subtract 40, yielding -34. 
The simple fix is to use Math.Abs to produce the absolute value of the equation,
which will return the correct answer, 34.
 */

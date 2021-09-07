using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Problems
{
    class FizzBuzzSpinoff
    {
        //Return the sum of all the multiples of 3 or 5 below the value passed
        //into the solution.


        public static int Solution(int value)
        {
            List<int> values = new List<int>();
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0)
                {
                    values.Add(i);
                }
                else if (i % 5 == 0)
                {
                    values.Add(i);
                }
            }
            return values.Sum();
        }
    }

    //Walkthrough
    /*
     This problem is a variation on the classic FizzBuzz problem, wherein if a value is divisible by 3, return "Fizz"
    and if a value is divisible by 5, return "Buzz".

    I've solved that problem before, and it was as simple as looping through a set of values, and returning "Fizz" or "Buzz"
     on multiples of 3 or 5 ("FizzBuzz" if the number is divisible by both 3 and 5).

    We're already halfway there.

    The challenge in this problem is getting the sum of all of those numbers.

    I solved that problem by checking if the value is divisible by 3 or 5, and if they are, adding them to a List of Type int.
    Then, I return the sum of all the values in the list.
     */
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Problems
{
    // Instructions:
    /*
     * Write a method which converts the input string to Uppercase.
     */
    class ToUpper
    {
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}

// Walkthrough
/*
 * This problem simply checks the coder's knowledge of the built-in methods in C# and
 * their understanding of the difference between arguments and parameters.
 * 
 * The MakeUpperCase method takes in a string as a parameter. All I have to do is convert it
 * to uppercase using dot notation to return the value of str using the ToUpper() method.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Problems
{
    //Instructions
    /*
     * You are given a string of space-separated numbers and 
     * have to return the highest and lowest number.
     */
    class HighAndLow
    {
        public static string HighAndLowNumbers(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }

    }

    //Walkthrough
    /*
     * The first thing that caught my attention when I saw this problem
     * was that the HighAndLowNumbers method takes in a string of numbers, which means
     * I need to do two important things before grabbing the high and low values: 
     * 
     * first, distinguish each element of the string from 
     * each other so I can work with them separately. 
     * Second, because I'm working with
     * numerical values, I need to convert these string values to integers so I can 
     * work with their values appropriately.
     * 
     * Only after I accomplish these two things can I return the highest and lowest values.
     * 
     * This is what I accomplish with the intermediate "parsed" variable -- I use the .Split()
     * method to break one delimited string into substrings:
     * https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-5.0
     * I use the .Select method to project each substring into a new form.
     * https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select?view=net-5.0
     * Then I convert each element into an integer by parsing them
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
     * 
     * Now I have workable data that I can isolate and return using .Max() and .Min(), concatenating them with a space in-between.
     */
}

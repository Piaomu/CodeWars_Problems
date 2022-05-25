using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Problems
{
    public class DigitalCypher
    {
        //Task 

        /*Write a function that accepts str string and key number 
         and returns an array of integers representing encoded str.*/


        public static int[] Encode(string str, int n)
        {
            string input = str.ToLower();

            if( n < 1)
            {
                throw new ArgumentException("Input must be a postitive integer");
            }

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>()
        {
            {"a", 1},
            {"b", 2},
            {"c", 3},
            {"d", 4},
            {"e", 5},
            {"f", 6},
            {"g", 7},
            {"h", 8},
            {"i", 9},
            {"j", 10},
            {"k", 11},
            {"l", 12},
            {"m", 13},
            {"n", 14},
            {"o", 15},
            {"p", 16},
            {"q", 17},
            {"r", 18},
            {"s", 19},
            {"t", 20},
            {"u", 21},
            {"v", 22},
            {"w", 23},
            {"x", 24},
            {"y", 25},
            {"z", 26}
        };

            List<int> cipher = new();

            foreach (char c in input)
            {
               cipher.Add(keyValuePairs.ElementAt(c).Value);
            }

            int[] cipherArray = cipher.ToArray();
            int[] digitArray = GetDigitArray(n);
            int[] result = new int[cipher.Count];

            for (int i = 0; i < cipherArray.Length; i++)
            {
                int cipherValue = cipherArray[i];
                int digitToAdd = digitArray[i % digitArray.Length];
                result[i] = cipherValue + digitToAdd;
            }

            return result;
        }

        //Separates each character in an integer into an array of integers
        private static int[] GetDigitArray(int n)
        {
            //Lists are easier to work with in a loop
            List<int> digits = new();

            while(n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            digits.Reverse();

            return digits.ToArray();
        }
    }
}

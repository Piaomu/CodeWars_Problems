using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Problems
{
    class ReverseAString
    {
        // Write a function that takes in a string of one or more words, and return
        // the same string, but with all words reversed.

        public static string SpinWords(string sentence)
        {
            var start = sentence.Length - 1;

            string reverseWord = "";

            for (int i = start; i >= 0; i--)
            {
                reverseWord = reverseWord + sentence[i];
            }

            return reverseWord;
        }
    }
}


/*
 */
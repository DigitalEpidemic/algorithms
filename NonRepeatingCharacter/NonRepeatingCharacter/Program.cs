using System;
using System.Collections.Generic;

namespace NonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NonRepeating("abcab")); // should return 'c'
            Console.WriteLine(NonRepeating("abab")); // should return null/empty
            Console.WriteLine(NonRepeating("aabbbc")); // should return 'c'
            Console.WriteLine(NonRepeating("aabbdbc")); // should return 'd'
        }

        static char? NonRepeating(string givenString)
        {
            var charCount = new Dictionary<char, int>();
            foreach (char c in givenString)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c] += 1;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (char c in givenString)
            {
                if (charCount[c] == 1)
                {
                    return c;
                }
            }

            return null;
        }
    }
}

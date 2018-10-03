using System;
using System.Collections.Generic;

namespace NonRepeatingCharacter {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine(NonRepeating("abcab")); // Should return 'c'
            Console.WriteLine(NonRepeating("abab")); // Should return null/empty
            Console.WriteLine(NonRepeating("aabbbc")); // Should return 'c'
            Console.WriteLine(NonRepeating("aabbdbc")); // Should return 'd'
        }

        static char? NonRepeating(string givenString) {
            var charCount = new Dictionary<char, int>();
            foreach (char c in givenString) {
                if (charCount.ContainsKey(c)) {
                    charCount[c] += 1;
                } else {
                    charCount[c] = 1;
                }
            }

            foreach (char c in givenString) {
                if (charCount[c] == 1) {
                    return c;
                }
            }

            return null;
        }

    }

}

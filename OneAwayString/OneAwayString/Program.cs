using System;

namespace OneAwayString
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: The following input values will be used for testing your solution.
            Console.WriteLine(IsOneAway("abcde", "abcd"));  // should return true
            Console.WriteLine(IsOneAway("abde", "abcde"));  // should return true
            Console.WriteLine(IsOneAway("a", "a"));  // should return true
            Console.WriteLine(IsOneAway("abcdef", "abqdef"));  // should return true
            Console.WriteLine(IsOneAway("abcdef", "abccef"));  // should return true
            Console.WriteLine(IsOneAway("abcdef", "abcde"));  // should return true
            Console.WriteLine(IsOneAway("aaa", "abc"));  // should return false
            Console.WriteLine(IsOneAway("abcde", "abc"));  // should return false
            Console.WriteLine(IsOneAway("abc", "abcde"));  // should return false
            Console.WriteLine(IsOneAway("abc", "bcc"));  // should return false
        }

        static bool IsOneAway(string s1, string s2)
        {
            if (s1.Length - s2.Length >= 2 || s2.Length - s1.Length >= 2)
            {
                return false;
            }
            else if (s1.Length == s2.Length)
            {
                return IsOneAwaySameLength(s1, s2);
            }
            else if (s1.Length > s2.Length)
            {
                return IsOneAwayDifferentLengths(s1, s2);
            }
            else
            {
                return IsOneAwayDifferentLengths(s2, s1);
            }
        }

        static bool IsOneAwaySameLength(string s1, string s2)
        {
            int countDifference = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    countDifference += 1;
                    if (countDifference > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool IsOneAwayDifferentLengths(string s1, string s2)
        {
            int i = 0;
            int countDifference = 0;
            while (i < s2.Length)
            {
                if (s1[i + countDifference] == s2[i])
                {
                    i += 1;
                }
                else
                {
                    countDifference += 1;
                }

                if (countDifference > 1)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

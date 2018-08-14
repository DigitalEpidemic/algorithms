using System;
using System.Collections.Generic;

namespace MostFrequent
{
    class Program
    {
        static void Main(string[] args)
        {
            // MostFrequent(array1) should return 1.
            int[] array1 = { 1, 3, 1, 3, 2, 1 };
            // MostFrequent(array2) should return 3.
            int[] array2 = { 3, 3, 1, 3, 2, 1 };
            // MostFrequent(array3) should return null/blank value
            int[] array3 = {};
            // MostFrequent(array4) should return 0.
            int[] array4 = { 0 };
            // MostFrequent(array5) should return -1.
            int[] array5 = { 0, -1, 10, 10, -1, 10, -1, -1, -1, 1 };

            Console.WriteLine(MostFrequent(array1));
            Console.WriteLine(MostFrequent(array2));
            Console.WriteLine(MostFrequent(array3));
            Console.WriteLine(MostFrequent(array4));
            Console.WriteLine(MostFrequent(array5));
        }

        public static int? MostFrequent(int[] givenArray) // nullable int
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int maxCount = -1;
            //int maxItem = int.MinValue;
            int? maxItem = null;

            foreach (int i in givenArray)
            {
                if (dict.TryGetValue(i, out int count))
                {
                    count++;
                    dict[i] = count;
                }
                else
                {
                    count = 1;
                    dict.Add(i, count);
                }

                if (count >= maxCount)
                {
                    maxItem = i;
                    maxCount = count;
                }
            }
            
            return maxItem;
        }
    }
}

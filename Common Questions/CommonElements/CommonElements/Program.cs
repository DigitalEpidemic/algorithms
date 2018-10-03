using System;
using System.Collections.Generic;

namespace CommonElements {

    class Program {

        static void Main(string[] args) {
            // NOTE: The following input values are used for testing your solution.

            int[] array1A = { 1, 3, 4, 6, 7, 9 };
            int[] array2A = { 1, 2, 4, 5, 9, 10 };
            // CommonElements(array1A, array2A) should return [1, 4, 9] (array).

            int[] array1B = { 1, 2, 9, 10, 11, 12 };
            int[] array2B = { 0, 1, 2, 3, 4, 5, 8, 9, 10, 12, 14, 15 };
            // CommonElements(array1B, array2B) should return [1, 2, 9, 10, 12] (array).

            int[] array1C = { 0, 1, 2, 3, 4, 5 };
            int[] array2C = { 6, 7, 8, 9, 10, 11 };
            // CommonElements(array1C, array2C) should return [] (empty array).

            Console.WriteLine(string.Join(", ", CommonElements(array1A, array2A)));
            Console.WriteLine(string.Join(", ", CommonElements(array1B, array2B)));
            Console.WriteLine(string.Join(", ", CommonElements(array1C, array2C)));
        }

        static int[] CommonElements(int[] array1, int[] array2) {
            // Pointers
            int p1 = 0;
            int p2 = 0;

            var result = new List<int>();

            while (p1 < array1.Length && p2 < array2.Length) {
                if (array1[p1] == array2[p2]) {
                    result.Add(array1[p1]);
                    p1 += 1;
                    p2 += 1;
                } else if (array1[p1] > array2[p2]) {
                    p2 += 1;
                } else {
                    p1 += 1;
                }
            }

            return result.ToArray();
        }

    }

}

using System;

namespace Rotation {

    class Program {

        static void Main(string[] args) {
            int[] list1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] list2A = { 4, 5, 6, 7, 8, 1, 2, 3 };
            // IsRotation(list1, list2A) should return false.

            int[] list2B = { 4, 5, 6, 7, 1, 2, 3 };
            // IsRotation(list1, list2B) should return true.

            int[] list2C = { 4, 5, 6, 9, 1, 2, 3 };
            // IsRotation(list1, list2C) should return false.

            int[] list2D = { 4, 6, 5, 7, 1, 2, 3 };
            // IsRotation(list1, list2D) should return false.

            int[] list2E = { 4, 5, 6, 7, 0, 2, 3 };
            // IsRotation(list1, list2E) should return false.

            int[] list2F = { 1, 2, 3, 4, 5, 6, 7 };
            // IsRotation(list1, list2F) should return true.

            Console.WriteLine(IsRotation(list1, list2A));
            Console.WriteLine(IsRotation(list1, list2B));
            Console.WriteLine(IsRotation(list1, list2C));
            Console.WriteLine(IsRotation(list1, list2D));
            Console.WriteLine(IsRotation(list1, list2E));
            Console.WriteLine(IsRotation(list1, list2F));

        }

        static bool IsRotation(int[] list1, int[] list2) {
            if (list1.Length != list2.Length) {
                return false;
            }

            int key = list1[0];
            int key_i = -1;

            for (int i = 0; i <= list2.Length - 1; i++) {
                if (list2[i] == key) {
                    key_i = i;
                    break;
                }
            }

            if (key_i == -1) {
                return false;
            }

            for (int i = 0; i <= list1.Length - 1; i++) {
                int j = (key_i + i) % list1.Length;
                if (list1[i] != list2[j]) {
                    return false;
                }
            }

            return true;
        }

    }

}

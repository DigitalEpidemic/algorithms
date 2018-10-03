using System;

namespace InsertionSort {
    class Program {

        static void Main(string[] args) {
            // Array of unsorted integers
            int[] arr = { 7, 8, 4, 6, 2, 1 };

            // Output the unsorted array to the console
            Console.Write("Before: ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine(); // Line break

            // Insertion value
            int newValue;

            // The outer loop iterates over the complete array that is used for sorting
            for (int i = 1; i < arr.Length; i++) {
                // Set newValue equal to the second element in the array
                // Skip the first value because it has no preceding value
                // Cannot move it any further forward in the array
                newValue = arr[i];

                // Set the start of the inner loop to the same value as i
                int j = i;

                // This loop will check the value of j to ensure the end of the iteration has not been reached (j=0)
                // Also checks to see if the value preceding the current value is larger
                // If larger, swap the value before the current one, decrement j and test against the next value
                // Continues until there are no more numbers in the array (j=0)
                // Or there are no more values larger than the current number (newValue) to it's left (preceding it)
                while (j>0 && arr[j-1] > newValue) {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = newValue;
            }

            // Output the sorted array to the console
            Console.Write("After: ");
            foreach(int val in arr) { // Shorter alternative to for loop used in BubbleSort
                Console.Write(val + " ");
            }
            Console.WriteLine(); // Line break
        }

    } // Program (class)
} // InsertionSort (namespace)

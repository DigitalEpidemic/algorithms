using System;

// Pseudocode
//
// bubbleSort(nums : list of sortable items)
// n = length(nums)
//
// loop //Until swapped is false or end of list size)
//     swapped = false
//     for i=1 to n-1 //Setup number of iterations equal to length of list - 1
//         //Is swap needed?
//         if nums[i-1] > nums[i] then //Swap them and note it by setting swapped to true
//             swap(nums[i-1], nums[i])
//             swapped = true

namespace BubbleSort {
    class Program {

        static void Main(string[] args) {
            // Array of unsorted integers
            int[] nums = { 5, 10, 3, 2, 4 };

            // Output the unsorted array to the console
            Console.Write("Before: ");
            for (int i = 0; i < nums.Length; i++) {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine(); // Line break

            // Used to know when to stop the sorting routine
            bool swapped;

            // Using a do loop, but could have used for or while loops as well
            do {
                // Set swapped to false to ensure at least one pass on the array
                swapped = false;

                // Iterate over the array from beginning to end
                for (int i = 0; i < nums.Length - 1; i++) {
                    // Using i for the position of the array
                    // i is the first value to compare and i+1 compares the adjacent value
                    // Once i is incremented at the end of the loop, compare the next two sets of values
                    if (nums[i] > nums[i + 1]) {
                        // Swap routine (Could be a separate method as well, but is used inline for simplicity)
                        // temp is used to hold the right value in the comparison (That value will be replaced in next step)
                        int temp = nums[i + 1];

                        // Replace the right value with the larger value that was on the left
                        nums[i + 1] = nums[i];

                        // Assign the value in temp (Smaller value) to the location that was just vacated by the larger number
                        nums[i] = temp;

                        // Indicate that a swap was performed (Which meawns contine to check the remaining values)
                        swapped = true;
                    }
                }
            } while (swapped == true);

            // Output the sorted array to the console
            Console.Write("After: ");
            for (int i = 0; i < nums.Length; i++) {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine(); // Line break
        }

    } // Program (class)
} // BubbleSort (namespace)

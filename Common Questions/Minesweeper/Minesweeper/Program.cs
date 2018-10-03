using System;

namespace Minesweeper {

    class Program {

        public static void Main(String[] args) {
            Console.WriteLine("X = Bomb\n");
            // NOTE: The following input values will be used for testing your solution.
            int[][] bombs1 = {
                new int[]{ 0, 2 },
                new int[]{ 2, 0 }
            };
            PrintArray(MineSweeper(bombs1, 3, 3));
            // MineSweeper(bombs1, 3, 3) should return:
            //  [0, 1, -1],
            //  [1, 2, 1],
            //  [-1, 1, 0]

            int[][] bombs2 = {
                new int[]{ 0, 0 },
                new int[]{ 0, 1 },
                new int[]{ 1, 2 }
            };
            PrintArray(MineSweeper(bombs2, 3, 4));
            // MineSweeper(bombs2, 3, 4) should return:
            //  [-1, -1, 2, 1],
            //  [2, 3, -1, 1],
            //  [0, 1, 1, 1]

            int[][] bombs3 = {
                new int[]{ 1, 1 },
                new int[]{ 1, 2 },
                new int[]{ 2, 2 },
                new int[]{ 4, 3 }
            };
            PrintArray(MineSweeper(bombs3, 5, 5));
            // MineSweeper(bombs3, 5, 5) should return:
            //  [1, 2, 2, 1, 0],
            //  [1, -1, -1, 2, 0],
            //  [1, 3, -1, 2, 0],
            //  [0, 1, 2, 2, 1],
            //  [0, 0, 1, -1, 1]

        }

        // Implement your solution below.
        public static int[][] MineSweeper(int[][] bombs, int numRows, int numCols) {
            int[][] field = new int[numRows][];
            for (int x = 0; x < field.Length; x++) {
                field[x] = new int[numCols];
            }

            // Loop based on length
            for (int k = 0; k < bombs.Length; k++) {
                int row = bombs[k][0];
                int col = bombs[k][1];

                field[row][col] = -1;

                for (int i = row - 1; i < row + 2; i++) {
                    for (int j = col - 1; j < col + 2; j++) {
                        if (i >= 0 && i < numRows &&
                            j >= 0 && j < numCols &&
                                field[i][j] != -1) {
                            field[i][j] += 1;
                        }
                    }
                }
            }
            return field;
        }

        static void PrintArray(int[][] arrayToPrint) {
            int x = arrayToPrint.Length;
            int y = arrayToPrint[0].Length;

            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    // Fix formatting
                    if (arrayToPrint[i][j] == -1) {
                        // Bomb
                        Console.Write("X ");
                    } else {
                        Console.Write(arrayToPrint[i][j] + " ");
                    }
                }

                Console.Write("\n");
            }

            Console.Write("\n");
        }

    }

}

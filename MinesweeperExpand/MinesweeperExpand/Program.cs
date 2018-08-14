using System;
using System.Collections;
using System.Collections.Generic;

namespace MinesweeperExpand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X = Bomb\nE = Expanded tile\n");
            // NOTE: The following input values will be used for testing your solution.
            int[][] field1 = {
                new int[]{0, 0, 0, 0, 0},
                new int[]{0, 1, 1, 1, 0},
                new int[]{0, 1, -1, 1, 0}
            };
            // Click(field1, 3, 5, 2, 2) should return:
            //  [0, 0, 0, 0, 0],
            //  [0, 1, 1, 1, 0],
            //  [0, 1, -1, 1, 0]
            PrintArray(Click(field1, 3, 5, 2, 2));
            //
            // Click(field1, 3, 5, 1, 4) should return:
            //  [-2, -2, -2, -2, -2],
            //  [-2, 1, 1, 1, -2],
            //  [-2, 1, -1, 1, -2]
            PrintArray(Click(field1, 3, 5, 1, 4));

            int[][] field2 = {
                new int[]{-1, 1, 0, 0},
                new int[]{1, 1, 0, 0},
                new int[]{0, 0, 1, 1},
                new int[] {0, 0, 1, -1}
            };
            // Click(field2, 4, 4, 0, 1) should return:
            //  [-1, 1, 0, 0],
            //  [1, 1, 0, 0],
            //  [0, 0, 1, 1],
            //  [0, 0, 1, -1]
            PrintArray(Click(field2, 4, 4, 0, 1));
            //
            // Click(field2, 4, 4, 1, 3) should return:
            //  [-1, 1, -2, -2],
            //  [1, 1, -2, -2],
            //  [-2, -2, 1, 1],
            //  [-2, -2, 1, -1]
            PrintArray(Click(field2, 4, 4, 1, 3));
        }

        static int[][] Click(int[][] field, int numRows, int numCols, int givenI, int givenJ)
        {
            Console.WriteLine("Clicked (" + givenI + "," + givenJ + ")");
            Queue<int[]> toCheck = new Queue<int[]>();
            if (field[givenI][givenJ] == 0)
            {
                field[givenI][givenJ] = -2;
                int[] coordinates = { givenI, givenJ };
                toCheck.Enqueue(coordinates);
            }
            else
            {
                return field;
            }

            while (toCheck.Count != 0)
            {
                int[] currentCoordinates = toCheck.Dequeue();
                int currentI = currentCoordinates[0];
                int currentJ = currentCoordinates[1];

                for (int i = currentI - 1; i < currentI + 2; i++)
                {
                    for (int j = currentJ - 1; j < currentJ + 2; j++)
                    {
                        if (0 <= i && i < numRows && 0 <= j && j < numCols && field[i][j] == 0)
                        {
                            field[i][j] = -2;
                            int[] coordinates = { i, j };
                            toCheck.Enqueue(coordinates);
                        }
                    }
                }
            }
            return field;
        }

        static void PrintArray(int[][] arrayToPrint)
        {
            int x = arrayToPrint.Length;
            int y = arrayToPrint[0].Length;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    // Fix bomb formatting
                    if (arrayToPrint[i][j] == -1)
                    {
                        Console.Write("X ");
                    } else if (arrayToPrint[i][j] == -2)
                    {
                        Console.Write("E ");
                    }
                    else
                    {
                        Console.Write(arrayToPrint[i][j] + " ");
                    }
                }

                Console.Write("\n");
            }

            Console.Write("\n");
        }
    }
}

//13.* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console
//the numbers 1 ... N numbers arranged as a spiral. 
//Example for N = 4
//            1  2  3  4
//            12 13 14 5
//            11 16 15 6
//            10  9  8 7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSpiralMatrix
{
    class OutputSpiralMatrix
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            string direction = "right";
            int maxRotations = n * n;

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            // Display Matrix

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,4}", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}

// Var.2:

//namespace OutputSpiralMatrix
//{
//    class OutputSpiralMatrix
//    {
//        static void Main()
//        {
//            Console.Write("Enter a number: ");
//            byte n = byte.Parse(Console.ReadLine());

//            int[,] matrix = new int[n, n];
//            sbyte row = 0, col = -1;
//            string direction = "right";

//            Console.WriteLine();
//            for (int i = 1; i <= n * n; i++)
//            {
//                if (direction == "right")
//                {
//                    if (matrix[row, ++col] == 0) matrix[row, col] = i;
//                    if (col + 1 >= n || matrix[row, col + 1] != 0) direction = "down";
//                }
//                else if (direction == "down")
//                {
//                    if (matrix[++row, col] == 0) matrix[row, col] = i;
//                    if (row + 1 >= n || matrix[row + 1, col] != 0) direction = "left";
//                }
//                else if (direction == "left")
//                {
//                    if (matrix[row, --col] == 0) matrix[row, col] = i;
//                    if (col - 1 < 0 || matrix[row, col - 1] != 0) direction = "up";
//                }
//                else if (direction == "up")
//                {
//                    if (matrix[--row, col] == 0) matrix[row, col] = i;
//                    if (row - 1 < 0 || matrix[row - 1, col] != 0) direction = "right";
//                }
//            }

//            PrintMatrix(matrix);
//        }

//        private static void PrintMatrix(int[,] matrix)
//        {
//            for (int row = 0; row < matrix.GetLongLength(0); row++)
//            {
//                for (int col = 0; col < matrix.GetLongLength(1); col++)
//                {
//                    Console.Write("{0,4}", matrix[row, col]);
//                }

//                Console.WriteLine();
//                Console.WriteLine();
//            }

//            Console.WriteLine();
//        }
//    }
//}
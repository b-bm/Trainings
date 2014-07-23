//11. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix 
//like the following:  
// N = 3         N = 4
// 1 2 3         1 2 3 4 
// 2 3 4         2 3 4 5 
// 3 4 5         3 4 5 6
//               4 5 6 7  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPutAMatrixVariantOne
{
    class OutPutAMatrixVariantOne
    {
        static void Main()
        {
            Console.Write("Enter a Number [N < 20 and N > 0]: ");
            byte n = byte.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= row + n - 1; col++)
                {
                    Console.Write("{0,3}", col); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
//Трябва да използвате два вложени цикъла, по подобие на задачата за отпечатване на триъгълник с числа. 
//Външният цикъл трябва да върти от 1 до N, а вътрешният – от стойността на външния до стойността на външния + N – 1.
// => задачата за отпечатване на триъгълник с числа:
//int n = int.Parse(Console.ReadLine());
//for (int row = 1; row <= n; row++)
//{
//  for (int col = 1; col <= row; col++)
//  {
//  Console.Write(col + " ");
//  }
//Console.WriteLine();
//}
	//Fire

    using System;
     
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
     
     
            for (int i = 1; i <= n / 2; i++)
            {
                string dotsOne = new String('.', ((n / 2) - i));
                Console.Write(dotsOne);
                Console.Write("#");
                string dotsTwo = new String('.', i - 1);
                Console.Write(dotsTwo);
                string dotsThree = new String('.', i - 1);
                Console.Write(dotsThree);
                Console.Write("#");
                string dotsLast = new String('.', ((n / 2) - i));
                Console.Write(dotsLast);
                Console.WriteLine();
            }
            for (int i = 0; i < n/4; i++)
            {
                string dotsOne = new String('.', i);
                Console.Write(dotsOne);
                Console.Write("#");
                string dotsTwo = new String('.', (n / 2) - i - 1);
                Console.Write(dotsTwo);
                string dotsThree = new String('.', (n / 2) - i - 1);
                Console.Write(dotsThree);
                Console.Write("#");
                string dotsLast = new String('.', i);
                Console.Write(dotsLast);
                Console.WriteLine();
            }
            string separator = new String('-', n);                      // Separator
            Console.WriteLine(separator);
     
            for (int i = 0; i < n/2; i++)
            {
                string dotsOne = new String('.', i);
                Console.Write(dotsOne);
                string leftSlash = new String('\\', n / 2 - i);
                Console.Write(leftSlash);
                string rightSlash = new String('/', n / 2 - i);
                Console.Write(rightSlash);
                string dotsLast = new String('.', i);
                Console.Write(dotsLast);
                Console.WriteLine();
     
            }
     
     
        }
    }


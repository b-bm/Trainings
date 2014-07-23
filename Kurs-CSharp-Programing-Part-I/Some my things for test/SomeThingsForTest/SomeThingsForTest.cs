//1. печати числата от 1 до 100:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeThingsForTest
{
    class SomeThingsForTest
    {
        static void Main()
        {
            for (int number = 1; number <= 100; number++) // ако се сложи да е number+=2 тогава печати през 2 числата и т.н.т.
            {
                Console.Write(number + " ");
            }
        }
    }
}

////2. :
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SomeThingsForTest
//{
//    class SomeThingsForTest
//    {
//        static void Main()
//        {
//            for (int i = 1, sum = 1; i <= 128; i = i * 2, sum += i) ;
//            {
//                Console.Write("i = {0}, sum = {1}", i, sum);
//            }
//        }
//    }
//}

////3. печати колко секунди са нужни за изпълнението на дадената операция при различните типове данни 
////(ling, double, float or decimal).При decimal времето е най-голямо, защото това е тип, който е майкрософтски 
////и не е имплементиран по дефолт в микропроцесора.:

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SomeThingsForTest
//{
//    class SomeThingsForTest
//    {
//        static void Main()
//        {
//            Console.WriteLine(DateTime.Now);
//            DateTime startTime = DateTime.Now;

//            long sum = 0;
//            for (int i = 0; i < 600000000; i++)
//            {
//                sum += i;
//            }
//            Console.WriteLine(sum); // операции в секунда

//            Console.WriteLine(DateTime.Now);
//            DateTime finishTime = DateTime.Now;

//            Console.WriteLine(finishTime - startTime);
//        }
//    }
//}

////4. Print Triangle - Var.1:

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SomeThingsForTest
//{
//    class SomeThingsForTest
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter some number between 3 and 25: ");
//            int n = int.Parse(Console.ReadLine());

//            for (int row = 1; row <= n; row++)
//            {

//                for (int col = 1; col <= row; col++)
//                {

//                    Console.Write(col + " ");

//                }

//                Console.WriteLine();

//            }
//        }
//    }
//}

////4. Print Triangle - Var.2:

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SomeThingsForTest
//{
//    class SomeThingsForTest
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = Encoding.Unicode;   // Strange output with UTF-8

//            char n = (char)'\u00A9';   // for other character change this unicode.Characters -> http://unicode-table.com/en
            
//            Console.Write("Enter some number between 3 and 20: ");
//            int rowN = int.Parse(Console.ReadLine());
            
//            for (int row = 1; row <= rowN; row++)
//            {

//                for (int col = 1; col <= row; col++)
//                {
//                    Console.Write("{0}", n);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

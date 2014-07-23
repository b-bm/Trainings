//6. Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it
//(prints its real roots).
//Напишете програма, която чете коефициентите a, b и c от конзолата и решава уравнението: ax2+bx+c=0. 
//Програмата трябва да принтира реалните решения на уравнението на конзолата. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QadraticEquation
{
    class QadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter First coefficient: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter Second coefficient: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter Third coefficient: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)                                                                           //step.1
            {
                Console.WriteLine("Tt is a linear equation, NOT a quadratic!");
            }
            else
            {
                double discriminant = (b * b) - (4 * a * c);                                      //step.3     
                
                if (discriminant == 0)                                                            //step.3.1 
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("The equation has only one root: {0}", x);
                }

                else if (discriminant > 0)                                                        //step.3.2
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("The equation roots are:\nX1: {0}\nX2: {1}", x1, x2);
                }

                else if (discriminant < 0)                                                        //step.3.3
                {
                    Console.WriteLine("This equations doesn't have roots!");
                } 
            }
        }
    }
}
// Чрез знака ^ изразяваме степенуване, а sqrt - е функция за корен квадратен.

//Ax^2 + Bx + C = 0
//Нека разгледаме последователно възможните решения:
//1) при A=0, квадратното уравнение се редуцира до линейно и има едно единствено решение (при B<>0) x = -C/B
//2) при C = 0 квадратното уравнение придобива вида: A*x^2 + Bx = 0 и има корени x = -B/A, както и x = 0
//3) изчисляваме дискриминантата D=B*B - 4*A*C.
//3.1 Ако D = 0 квадратното уравнение има само един корен X1=-B/2A. 
//В блок схемата този случай се представя като двоен корен на уравнението.
//3.2 Ако D > 0 това квадратно уравнение има следните реални корени (с sqrt означаваме функцията корен квадратен):
//X1= (-B - sqrt (D)) / (2*A)
//X2= (-B + sqrt (D)) / (2*A)
//3.3 Ако D < 0 това квадратно уравнение има следните комплексни корени:
//X1= (-B - i*(sqrt (D)) / (2*A)
//X2= (-B + i*(sqrt (D)) / (2*A)
//Където i е имагинерната единица имаща стойност sqrt (-1)
//В този случай корените на това квадратно уравнение са комплексно спрегнати - имат една и съща реална част 
//и различни по знак, но с еднаква абсолютна стойност имагинерна част.
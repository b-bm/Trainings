	//Coffee Machine

    using System;
     
    class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
     
            double moneyOfDeveloper = double.Parse(Console.ReadLine());
            double priceOfItem = double.Parse(Console.ReadLine());
     
            double moneyInTrays = (n1 * 0.05) + (n2 * 0.10) + (n3 * 0.20) + (n4 * 0.50) + (n5 * 1.00);
     
            if (moneyOfDeveloper >= priceOfItem && moneyInTrays > (moneyOfDeveloper - priceOfItem))
            {
                Console.WriteLine("Yes {0:F2}", (moneyInTrays - (moneyOfDeveloper - priceOfItem)));
            }
            else if (priceOfItem > moneyOfDeveloper)
            {
                Console.WriteLine("More {0:F2}", (priceOfItem - moneyOfDeveloper));
            }
            else if (moneyOfDeveloper > priceOfItem)
            {
                Console.WriteLine("No {0:F2}", ((moneyOfDeveloper - moneyInTrays) - priceOfItem));
            }
        }
    }


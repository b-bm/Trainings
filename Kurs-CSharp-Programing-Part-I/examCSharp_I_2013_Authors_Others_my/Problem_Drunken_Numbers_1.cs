	//Drunken Numbers

    using System;
     
    class Program
    {
        static void Main()
        {
            int rounds = int.Parse(Console.ReadLine());
            int mitko = 0;
            int vladko = 0;
     
            while (rounds >= 1)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    n = n * (-1);
                }
                int b = n;
                int numberDigits = 0;
                while (n > 0)
                {
                    n /= 10;
                    numberDigits++;
                }
     
                if ((numberDigits % 2) == 0)
                {
                    for (int i = 1; i <= numberDigits; i++)
                    {
                        if (i <= numberDigits / 2)
                        {
                                int adding = b % 10;
                                b /= 10;
                                vladko += adding;
                        }
                        if (i > numberDigits / 2)
                        {
                            int adding = b % 10;
                            b /= 10;
                            mitko += adding;
                        }
                    }
                }
                else if ((numberDigits % 2) != 0)
                {
                    for (int i = 1; i <= numberDigits; i++)
                    {
                        if (i == numberDigits / 2 + 1)
                        {
                            int adding = b % 10;
                            b /= 10;
                            vladko += adding;
                            mitko += adding;
                        }
                        else if (i <= numberDigits / 2)
                        {
                            int adding = b % 10;
                            b /= 10;
                            vladko += adding;
                        }
                        else if (i > numberDigits / 2)
                        {
                            int adding = b % 10;
                            b /= 10;
                            mitko += adding;
                        }
                    }
                }
                rounds--;
            }
     
            if (mitko > vladko)
            {
                Console.WriteLine("M" + " " + (mitko-vladko));
            }
            else if (mitko < vladko)
            {
                Console.WriteLine("V" + " " + (vladko-mitko));
            }
            else if (mitko == vladko)
            {
                Console.WriteLine("No" + " " + (mitko+vladko));
            }
        }
    }


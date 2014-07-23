//Poker	
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
     
    namespace Poker
    {
        class Poker
        {
            static void Main(string[] args)
            {
                string a = Console.ReadLine().ToUpper();
                string b = Console.ReadLine().ToUpper();
                string c = Console.ReadLine().ToUpper();
                string d = Console.ReadLine().ToUpper();
                string e = Console.ReadLine().ToUpper();
     
                int FirstCard = new int();
                int FifthCard = new int();
                int SecondCard = new int();
                int ThirdCard = new int();
                int FourthCard = new int();
                switch (a)
                {
                    case "1": FirstCard = 1; break;
                    case "A": FirstCard = 1; break;
                    case "2": FirstCard = 2; break;
                    case "3": FirstCard = 3; break;
                    case "4": FirstCard = 4; break;
                    case "5": FirstCard = 5; break;
                    case "6": FirstCard = 6; break;
                    case "7": FirstCard = 7; break;
                    case "8": FirstCard = 8; break;
                    case "9": FirstCard = 9; break;
                    case "10": FirstCard = 10; break;
                    case "J": FirstCard = 11; break;
                    case "Q": FirstCard = 12; break;
                    case "K": FirstCard = 13; break;
                }
                    switch (b)
                {
                    case "1": SecondCard = 1; break;
                    case "A": SecondCard = 1; break;
                    case "2": SecondCard = 2; break;
                    case "3": SecondCard = 3; break;
                    case "4": SecondCard = 4; break;
                    case "5": SecondCard = 5; break;
                    case "6": SecondCard = 6; break;
                    case "7": SecondCard = 7; break;
                    case "8": SecondCard = 8; break;
                    case "9": SecondCard = 9; break;
                    case "10": SecondCard = 10; break;
                    case "J": SecondCard = 11; break;
                    case "Q": SecondCard = 12; break;
                    case "K": SecondCard = 13; break;
                }
                switch (c)
                {
                    case "1": ThirdCard = 1; break;
                    case "A": ThirdCard = 1; break;
                    case "2": ThirdCard = 2; break;
                    case "3": ThirdCard = 3; break;
                    case "4": ThirdCard = 4; break;
                    case "5": ThirdCard = 5; break;
                    case "6": ThirdCard = 6; break;
                    case "7": ThirdCard = 7; break;
                    case "8": ThirdCard = 8; break;
                    case "9": ThirdCard = 9; break;
                    case "10": ThirdCard = 10; break;
                    case "J": ThirdCard = 11; break;
                    case "Q": ThirdCard = 12; break;
                    case "K": ThirdCard = 13; break;
                }
                switch (d)
                {
                    case "1": FourthCard = 1; break;
                    case "A": FourthCard = 1; break;
                    case "2": FourthCard = 2; break;
                    case "3": FourthCard = 3; break;
                    case "4": FourthCard = 4; break;
                    case "5": FourthCard = 5; break;
                    case "6": FourthCard = 6; break;
                    case "7": FourthCard = 7; break;
                    case "8": FourthCard = 8; break;
                    case "9": FourthCard = 9; break;
                    case "10": FourthCard = 10; break;
                    case "J": FourthCard = 11; break;
                    case "Q": FourthCard = 12; break;
                    case "K": FourthCard = 13; break;
                }
                switch (e)
                {
                    case "1": FifthCard = 1; break;
                    case "A": FifthCard = 1; break;
                    case "2": FifthCard = 2; break;
                    case "3": FifthCard = 3; break;
                    case "4": FifthCard = 4; break;
                    case "5": FifthCard = 5; break;
                    case "6": FifthCard = 6; break;
                    case "7": FifthCard = 7; break;
                    case "8": FifthCard = 8; break;
                    case "9": FifthCard = 9; break;
                    case "10": FifthCard = 10; break;
                    case "J": FifthCard = 11; break;
                    case "Q": FifthCard = 12; break;
                    case "K": FifthCard = 13; break;
                }
                int[] Cards = new int[5];
                Cards[0] = FirstCard;
                Cards[1] = SecondCard;
                Cards[2] = ThirdCard;
                Cards[3] = FourthCard;
                Cards[4] = FifthCard;
                Array.Sort(Cards);
               
                if (FirstCard == SecondCard && FirstCard == ThirdCard && FirstCard == FourthCard && FirstCard == FifthCard)
                {
                    Console.WriteLine("Impossible");
                }
                else if (Cards[0] == Cards[1] && Cards[0] == Cards[2] && Cards[0] == Cards[3])
                {
                    Console.WriteLine("Four of a Kind");
                }
                else if (Cards[4] == Cards[1] && Cards[4] == Cards[2] && Cards[4] == Cards[3])
                {
                    Console.WriteLine("Four of a Kind");
                }
                else if (Cards[0] == Cards[1] && Cards[0] == Cards[2] && Cards[3] == Cards[4])
                {
                    Console.WriteLine("Full House");
                }
                else if (Cards[2] == Cards[3] && Cards[2] == Cards[4] && Cards[0] == Cards[1])
                {
                    Console.WriteLine("Full House");
                }
                else if (Cards[0] == (Cards[1] - 1) && Cards[0] == (Cards[2] - 2) && Cards[0] == (Cards[3] - 3) && Cards[0] == (Cards[4] - 4))
                {
                    Console.WriteLine("Straight");
                }
                else if ((Cards[0] + 8) == (Cards[1] - 1) && (Cards[0] + 8) == (Cards[2] - 2) && (Cards[0] + 8) == (Cards[3] - 3) && (Cards[0] + 8) == (Cards[4] - 4))
                {
                    Console.WriteLine("Straight");
                }
                else if (Cards[0] == Cards[1] && Cards[0] == Cards[2])
                {
                    Console.WriteLine("Three of a Kind");
                }
                else if (Cards[3] == Cards[1] && Cards[3] == Cards[2])
                {
                    Console.WriteLine("Three of a Kind");
                }
                else if (Cards[3] == Cards[4] && Cards[3] == Cards[2])
                {
                    Console.WriteLine("Three of a Kind");
                }
                else if (Cards[0] == Cards[1] && Cards[2] == Cards[3])
                {
                    Console.WriteLine("Two Pairs");
                }
                else if (Cards[1] == Cards[2] && Cards[3] == Cards[4])
                {
                    Console.WriteLine("Two Pairs");
                }
                else if (Cards[0] == Cards[1] && Cards[3] == Cards[4])
                {
                    Console.WriteLine("Two Pairs");
                }
                else if (Cards[0] == Cards[1])
                {
                    Console.WriteLine("One Pair");
                }
                else if (Cards[1] == Cards[2])
                {
                    Console.WriteLine("One Pair");
                }
                else if (Cards[2] == Cards[3])
                {
                    Console.WriteLine("One Pair");
                }
                else if (Cards[3] == Cards[4])
                {
                    Console.WriteLine("One Pair");
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
     
               
     
     
            }
        }
    }
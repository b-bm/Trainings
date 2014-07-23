// Sheets - without masivi	

    using System;
     
    class SheetsBezMasivi
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());    // Primer za 666        // primer za 1337
            int A10 = 1;            //1
            int A9 = A10 * 2;       //2
            int A8 = A9 * 2;        //4
            int A7 = A8 * 2;        //8
            int A6 = A7 * 2;        //16
            int A5 = A6 * 2;        //32
            int A4 = A5 * 2;        //64
            int A3 = A4 * 2;        //128
            int A2 = A3 * 2;        //256
            int A1 = A2 * 2;        //512
            int A0 = A1 * 2;        //1024
            if (sum - A0 >= 0 && sum != 0)          // sum == 666 - 1024 >=0 - False // sum == 1337 - 1024 >= True
            {
                sum = sum - A0;                                                      // 1337 = 1337-1024
            }                                                                        // sum == 313
            else
            {
                Console.WriteLine("A0");            //Console.WriteLine("A0");
            }
            if (sum - A1 >= 0 && sum != 0)          // sum == 666 - 512 >=0 True //sum == 313 - 512 >=0 False
            {
                sum = sum - A1;                     // sum = 666 - 512
            }                                       // sum == 154
            else
            {
                Console.WriteLine("A1");                                          //Console.WriteLine("A1");
            }
            if (sum - A2 >= 0 && sum != 0)          //sum == 154 - 256 >=0 False  //sum == 313 - 256 >=0 True
            {
                sum = sum - A2;                                                   //sum == 313 - 256
            }                                                                     //sum == 57
            else
            {
                Console.WriteLine("A2");            // Console.WriteLine("A2");
            }
            if (sum - A3 >= 0 && sum != 0)          // sum == 154 - 128 >=0 True  // sum == 57 - 128 >=0 False
            {
                sum = sum - A3;                     // sum = 154 - 128
            }                                       // sum == 26
            else
            {
                Console.WriteLine("A3");                                           // Console.WriteLine("A3");
            }
            if (sum - A4 >= 0 && sum != 0)          // sum == 26 - 64 >=0 False  // sum == 57 - 64 >=0 False
            {
                sum = sum - A4;
            }
            else
            {
                Console.WriteLine("A4");            //Console.WriteLine("A4");   // Console.WriteLine("A4");
            }
            if (sum - A5 >= 0 && sum != 0)          // sum = 26 - 32 >=0 False   // sum = 57 - 32 >=0 True
            {
                sum = sum - A5;                                                  //sum = 57 - 32
            }                                                                    //sum == 25
            else
            {
                Console.WriteLine("A5");            //Console.WriteLine("A5");
            }
            if (sum - A6 >= 0 && sum != 0)          // sum = 26 - 16 >=0 True  // sum = 25 - 16 >=0 True
            {
                sum = sum - A6;                     // sum = 26 - 16            // sum = 25 - 16                                      
                                                    // sum == 10                // sum = 9
            }
            else
            {
                Console.WriteLine("A6");
            }
            if (sum - A7 >= 0 && sum != 0)          // sum = 10 - 8 >=0 True    // sum = 9 - 8 >= 1 True
            {
                sum = sum - A7;                     // sum = 10 - 8             // sum = 9 - 8
            }                                       //sum ==2                   // sum == 1
            else
            {
                Console.WriteLine("A7");            
            }
            if (sum - A8 >= 0 && sum != 0)          // sum = 2 - 4 >= 0 False   // sum = 1 - 4 >= 0 False
            {
                sum = sum - A8;
            }
            else
            {
                Console.WriteLine("A8");            //Console.WriteLine("A8");   //Console.WriteLine("A8");
            }
            if (sum - A9 >= 0 && sum != 0)          // sum = 2 - 2 >= 0 True     // sum = 1 - 4 >= 0 False
            {
                sum = sum - A9;                     // sum = 2 - 2
            }                                       // sum = 0
            else
            {
                Console.WriteLine("A9");                                          // Console.WriteLine("A9");
            }
            if (sum - A10 >= 0 && sum != 0)         // sum != 0 False            // sum = 1 - 1 >=0 True
            {
                sum = sum - A10;                                                 // sum = 1 - 1
            }                                                                    // sum = 0
            else
            {
                Console.WriteLine("A10");           //Console.WriteLine("A10");
            }                                       //Input 666 - Output A0 , A2 , A4 , A5 , A8 , A10;
                                                    //Input 1337 - Output A1 , A3 , A4 , A8 , A9;                              
        }
    }
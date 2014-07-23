//Sheets - with masiv	

    using System;
     
    class SheetsSMasivi
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int[] MyArray = { 1024 , 512 , 256 , 128 , 64 , 32 , 16 , 8 , 4 , 2 , 1};
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (sum - MyArray[i] >= 0 && sum !=0)
                {
                    sum = sum - MyArray[i];
                }
                else
                {
                    Console.WriteLine("A" + i);
                }
            }
        }
    }


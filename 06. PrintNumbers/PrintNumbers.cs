using System;
    class PrintNumbers
    {
        static void Main()
        {
            for (int i = 1; i <= 9; i += 4)
            {
                Console.WriteLine(Convert.ToString(i, 2));
            }
        }
    }

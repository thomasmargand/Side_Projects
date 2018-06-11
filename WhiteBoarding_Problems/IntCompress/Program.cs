using System;

namespace IntCompress
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program takes an integer and sums the individual digits until there is 
             * only a single integer remaining. For example if the user enters 38 the 
             * program will generate 11 (8 + 3) then it will call itself again and return
             * 2 (1 + 1).*/

            Console.WriteLine("Please enter an integer: ");
            int a = int.Parse(Console.ReadLine());
            int b = loneInt(a);
            Console.WriteLine($"{b}");

            int loneInt(int n)
            {
                if (n < 10)
                {
                    return n;
                }

                int p = 0;
                /*for(int i = n; i > 0; i /= 10)
                {                    
                    if (i == 10)
                    {
                        p = 1;                        
                    }
                    p += (i % 10);                   
                }*/

                while(n > 0)
                {
                    if (n == 10)
                    {
                        p = 1;
                    }
                    p += (n % 10);
                    n /= 10;
                }

                if (p > 9)
                {
                    p = loneInt(p);
                }
                return p;
            }

        }
    }
}

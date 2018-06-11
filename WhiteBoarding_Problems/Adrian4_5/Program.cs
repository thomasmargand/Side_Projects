using System;

namespace Adrian4_5
{
    class Program
    {
        /*This program asks the user for a number and prints the sum 
         * of the numbers from 1 to n. It only accepts positive integers.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int p = n - 1;

            for(int i = p; i > 0; i-- )
            {
                n += i;
            }

            Console.WriteLine($"{n}");

            /*This program adds a modification to the previous program 
             * that stipulates only multiples of 3 or 5 are included in the sum*/

            Console.WriteLine("Please enter a number: ");
            int q = int.Parse(Console.ReadLine());
            int s = 0;

            for (int i = q; i > 0; i--)
            {                
                if (i % 3 == 0 || i % 5 == 0)
                {
                    s += i;
                }

            }

            Console.WriteLine($"{s}");

            /*This program modifies the first program to find either the product or sum
             * of values 1 to n based on the user's decision.  The program only accepts 
             * valid integer inputs*/

            Console.WriteLine("Please enter a number: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you like the sum or product of all values 1 to n?");
            Console.WriteLine("Press 1 for sum or 2 for product: ");
            int t = int.Parse(Console.ReadLine());
            int v = r - 1;

            switch (t)
            {
                case 1:
                    for (int i = v; i > 0; i--)
                    {
                        r += i;
                    }
                    Console.WriteLine($"{r}");
                    break;
                case 2:
                    for (int i = v; i > 0; i--)
                    {
                        r *= i;
                    }
                    Console.WriteLine($"{r}");
                    break;
            }
        }
    }
}

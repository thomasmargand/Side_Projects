using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Roulette");
            Console.WriteLine("Please spin the wheel to play");
            Console.WriteLine("Press enter to spin the wheel");
            Console.ReadLine();

            Random rnd = new Random();
            int bin = rnd.Next(36);

            Console.WriteLine("You rolled a: {0}", bin);
            Console.WriteLine("The winning bets for your roll are: ");
            Console.WriteLine("Number: {0}", bin);

            int[] right = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] middle = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] left = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

            int[] red = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            if ((bin % 2 == 0) || bin == 0)
            {
                Console.WriteLine("Even");
            }
            else if (bin % 2 == 1)
            {
                Console.WriteLine("Odds");
            }

            if (red.Contains(bin))
            {
                Console.WriteLine("Red");
            }
            else if (black.Contains(bin))
            {
                Console.WriteLine("Black");
            }

            if (bin <= 18)
            {
                Console.WriteLine("Lows");
            }
            else if (bin >= 19)
            {
                Console.WriteLine("Highs");
            }

            if (0 < bin && bin <= 12)
            {
                Console.WriteLine("Dozens: Lower Thirds");
            }
            else if (bin >= 13 && bin <= 24)
            {
                Console.WriteLine("Dozens: Middle Thirds");
            }
            else if (bin >= 25 && bin <= 36)
            {
                Console.WriteLine("Dozens: Upper Thirds");
            }

            if (left.Contains(bin))
            {
                Console.WriteLine("Columns: 1st");
                Console.WriteLine($"Street: {bin}, {bin + 1}, {bin + 2}");
                if (bin == 1)
                {
                    Console.WriteLine("Split: 1/2, 1/4");
                }
                else if (bin == 34)
                {
                    Console.WriteLine("Split: 34/35, 31/34");
                }
                else
                {
                    Console.WriteLine($"Split: {bin}/{bin + 1}, {bin}/{bin - 3}, {bin}/{bin + 3}");
                }

            }
            else if (middle.Contains(bin))
            {
                Console.WriteLine("Columns: 2nd");
                Console.WriteLine($"Street: {bin - 1}, {bin}, {bin + 1}");
                if (bin == 2)
                {
                    Console.WriteLine("Split: 1/2, 2/3, 2/5");
                }
                else if (bin == 35)
                {
                    Console.WriteLine("Split: 34/35, 35/36, 35/32");
                }
                else
                {
                    Console.WriteLine($"Split: {bin}/{bin - 1}, {bin}/{bin + 1}, {bin}/{bin + 3}, {bin}/{bin - 3}");
                }
            }
            else if (right.Contains(bin))
            {
                Console.WriteLine("Columns: 3rd");
                Console.WriteLine($"Street: {bin - 2}, {bin - 1}, {bin}");
                if (bin == 3)
                {
                    Console.WriteLine("Split: 2/3, 3/6");
                }
                else if (bin == 36)
                {
                    Console.WriteLine("Split: 35/36, 33/36");
                }
                else
                {
                    Console.WriteLine($"Split: {bin}/{bin - 1}, {bin}/{bin - 3}, {bin}/{bin + 3}");
                }
            }

            if (left.Contains(bin) && bin == 1)
            {
                Console.WriteLine("Corners: 1,2,5,4");
            }
            else if (left.Contains(bin) && bin == 34)
            {
                Console.WriteLine("Corners: 34,31,32,35");
            }
            else if (left.Contains(bin) && bin != 1 && bin != 34)
            {
                Console.WriteLine($"Corners: {bin},{bin - 3},{bin - 2},{bin + 1}");
                Console.WriteLine($"Corners: {bin},{bin + 1},{bin + 4}, {bin + 3}");
            }

            if (middle.Contains(bin) && bin == 2)
            {
                Console.WriteLine("Corners: 1,2,4,5");
                Console.WriteLine("Corners: 2,3,5,6");
            }
            else if (middle.Contains(bin) && bin == 35)
            {
                Console.WriteLine("Corners: 31,32,34,35");
                Console.WriteLine("Corners: 32,33,35,36");
            }
            else if (middle.Contains(bin) && bin != 2 && bin != 35)
            {
                Console.WriteLine($"Corners: {bin - 4},{bin - 3},{bin},{bin - 1}");
                Console.WriteLine($"Corners: {bin - 3},{bin - 2},{bin},{bin + 1}");
                Console.WriteLine($"Corners: {bin + 1},{bin + 4},{bin},{bin + 3}");
                Console.WriteLine($"Corners: {bin - 1},{bin},{bin + 3},{bin + 2}");
            }

            if (right.Contains(bin) && bin == 3)
            {
                Console.WriteLine("Corners: 2,3,5,6");
            }
            else if (right.Contains(bin) && bin == 36)
            {
                Console.WriteLine("Corners: 32,33,35,36");
            }
            else if (right.Contains(bin) && bin != 3 && bin != 36)
            {
                Console.WriteLine($"Corners: {bin - 4},{bin - 3},{bin - 1},{bin}");
                Console.WriteLine($"Corners: {bin - 1},{bin},{bin + 2},{bin + 3}");
            }

            if (left.Contains(bin) && bin == 1)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
            }
            else if (left.Contains(bin) && bin == 34)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
            }
            else if (left.Contains(bin) && bin != 1 && bin != 34)
            {
                Console.WriteLine($"6 Numbers: {bin - 3},{bin - 2},{bin - 1},{bin},{bin + 1},{bin + 2} " +
                    "\r\n" + $"{bin},{bin + 1},{bin + 2},{bin + 3},{bin + 4},{bin + 5}");
            }

            if (middle.Contains(bin) && bin == 2)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
            }
            else if (middle.Contains(bin) && bin == 35)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
            }
            else if (middle.Contains(bin) && bin != 2 && bin != 35)
            {
                Console.WriteLine($"6 Numbers: {bin - 4},{bin - 3},{bin - 2},{bin - 1},{bin},{bin + 1} " +
                    "\r\n" + $"{bin - 1},{bin},{bin + 1},{bin + 2},{bin + 3},{bin + 4}");
            }

            if (right.Contains(bin) && bin == 3)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
            }
            else if (right.Contains(bin) && bin == 36)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
            }
            else if (right.Contains(bin) && bin != 3 && bin != 36)
            {
                Console.WriteLine($"6 Numbers: {bin - 5},{bin - 4},{bin - 3},{bin - 2},{bin - 1},{bin} " + 
                    "\r\n" + $"{bin - 2},{bin - 1},{bin},{bin + 1},{bin + 2},{bin + 3}");
            }
            
        }
    }
}
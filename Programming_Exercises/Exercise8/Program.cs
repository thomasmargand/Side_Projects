using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] nextTest = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                              21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                              41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
                              61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                              81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100};
            int input;
            int otherInput;

            Console.WriteLine("Hello and welcome to the bisection program");
            Console.WriteLine("This program will guess a number you choose between 1-10");
            Console.WriteLine("Please enter an integer between 1-10 and press the enter key to begin");
            
            input = int.Parse(Console.ReadLine());
            BiSectList(test, input);

            Console.WriteLine("Great now lets try a harder one, this time pick a number between 1-100");
            otherInput = int.Parse(Console.ReadLine());
            BiSectList(nextTest, otherInput);
        }

            private static int BiSectList(int[] test, int find)
            {
                int left = 0;
                int right = test.Length + 1;
                int middle = (left + right) / 2;

                while (test[middle] != find)
                {
                    if (test[middle] < find)
                    {
                        left = middle + 1;
                    }
                    else if (test[middle] > find)
                    {
                        right = middle - 1;
                    }
                    middle = (left + right) / 2;
                }
                Console.WriteLine(middle + 1);
                return middle;
            }                      

    }
}

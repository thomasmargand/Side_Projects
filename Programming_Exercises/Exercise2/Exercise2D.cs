using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2D
{
    class Exercise2D
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello and welcome to the grading average program");
                Console.WriteLine("This program will grade and average test scores");
                Console.WriteLine("The test scores must be integers between 0-100");
                Console.WriteLine("Now please enter each test score followed by the enter key: ");
                Console.WriteLine("When you are done entering test scores please type '2018' to get the average");

                int count = 0;
                int num;
                string key;
                int total = 0;
                int average = 0;

                start();

                void start()
                {
                    key = Console.ReadLine();
                    num = int.Parse(key);

                    if (num == 2018)
                    {
                        sum();
                    }
                    else if (num < 0 || num > 100)
                    {
                        Console.WriteLine("Integer outside of range please enter another");
                        start();
                    }
                    else
                    {
                        count++;
                        sum();
                    }
                }

                void sum()
                {
                    if (num == 2018)
                    {
                        total = total + num;
                        average = (total - 2018) / count;
                        Console.Write("The average numerical grade is: {0} ", average);
                        Console.WriteLine();                        
                    }
                    else
                    {
                        total = total + num;
                    }
                }

                while (num != 2018)
                {
                    start();
                }

                if (average >= 90)
                {
                    Console.WriteLine("The average letter grade is an A");
                }
                else if (average < 90 && average >= 80)
                {
                    Console.WriteLine("The average letter grade is a B");
                }
                else if (average < 80 && average >= 70)
                {
                    Console.WriteLine("The average letter grade is a C");
                }
                else if (average < 70 && average >= 60)
                {
                    Console.WriteLine("The average letter grade is a D");
                }
                else if (average < 60)
                {
                    Console.WriteLine("The average letter grade is an F");
                }

            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }

        }
    }
}      

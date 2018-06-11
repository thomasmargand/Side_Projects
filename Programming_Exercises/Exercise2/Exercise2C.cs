using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2C
{
    class Exercise2C
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello and welcome to the grading average program");
                Console.WriteLine("This program will grade and average a user designated number of test scores");
                Console.WriteLine("The test scores must be integers between 0-100");
                Console.WriteLine("Please enter the number of tests you would like to average: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Great now please enter each test score followed by the enter key: ");

                int count = 0;
                int num;
                int total = 0;
                int average = 0;

                start();

                void start()
                {
                    num = int.Parse(Console.ReadLine());

                    if (num < 0 || num > 100)
                    {
                        Console.WriteLine("Integer outside of range please enter another");
                        start();
                    }
                    else
                    {
                        count++;
                    }
                }

                sum();

                void sum()
                {
                    if (count < n)
                    {
                        total = total + num;
                    }
                    else
                    {
                        total = total + num;
                        average = total / n;
                        Console.Write("The average numerical grade is: {0} ", average);
                        Console.WriteLine();
                    }
                }

                while (count < n)
                {
                    start();
                    sum();
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

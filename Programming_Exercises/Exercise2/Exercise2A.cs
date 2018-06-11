using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A
{
    class Exercise2A
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello and welcome to the sum program");
                Console.WriteLine("This program will sum 10 user entered integers between 0-100");
                Console.WriteLine("Please enter each integer followed by the enter key: ");

                int count = 0;
                int num;
                int total = 0;

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
                    if (count < 10)
                    {
                        total = total + num;
                    }
                    else
                    {
                        total = total + num;
                        Console.Write("The answer is: {0} ", total);
                    }
                }

                while (count < 10)
                {
                    start();
                    sum();
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
                       
        }
    }
}

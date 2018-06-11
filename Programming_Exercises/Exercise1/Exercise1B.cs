using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
                 
        {
            try
            {
                Console.WriteLine("Hello and welcome to the triangle program!");
                Console.Write("To begin please enter the length of one side of your triangle: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Great now enter the length of another side of your triangle: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Finally enter the length of the third side of your triangle: ");
                int c = int.Parse(Console.ReadLine());

                if (a < 0 || b < 0 || c < 0)
                {
                   throw new ArgumentOutOfRangeException("Side lengths can not be a negative number!");
                }

                double p = checked(((double)a + (double)b + (double)c) / 2);
                double area = checked(Math.Sqrt(p * (p - (double)a) * (p - (double)b) * (p - (double)c)));
                
                Console.WriteLine("The area of your triangle is {0}", area);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch (OverflowException oEx)
            {
                Console.WriteLine(oEx.Message);
            }
            catch (ArgumentOutOfRangeException aorEx)
            {
                Console.WriteLine(aorEx.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using the triangle program");
            }
        }
    }
}

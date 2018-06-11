using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    class Quadratic
    {
        static void Main(string[] args)
        {
           try
            { 
            Console.WriteLine("Hello and welcome to the quadratic equation program.");
            Console.WriteLine("We are going to solve a quadratic equation using the quadratic formula");
            Console.WriteLine("This is the quadratic equation: ax^2 + bx + c = 0");
            Console.WriteLine("We will solve for x using coeffecient values that you provide (non-negative integers only please)");
            Console.WriteLine("This is the quadratic formula: x = (-b +/- sqrt(b^2 - 4ac)) / 2a");
            Console.WriteLine("Please keep in mind that there will be two values for x indicating the two points at which" +
                " your parabola crosses the x-axis");
            int a;
            int b;
            int c;
            double x;
            double otherx;

            getValues();

            void getValues()
            {
                Console.Write("Please provide a value for a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Good, now provide a value for b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Finally please provide a value for c: ");
                c = int.Parse(Console.ReadLine());
                        
                if (a < 0)
                {
                    throw new ArgumentOutOfRangeException("This program can only accept non zero integers");
                }
                else if (b < 0)
                {
                    throw new ArgumentOutOfRangeException("This program can only accept non zero integers");
                }
                else if (c < 0)
                {
                    throw new ArgumentOutOfRangeException("This program can only accept non zero integers");
                }
            }
            x = quadMethod(a, b, c);
                     
            double quadMethod(int aa, int bb, int cc)
            {
                checked
                    {
                        double d = (bb * bb) - (4 * aa * cc);
                        if (d < 0)
                        {
                            throw new ArgumentOutOfRangeException("This program can not accept those coefficient values");
                        }
                        double e = Math.Sqrt(d);
                        double f = (-1 * bb) + e;
                        double g = f / (2 * aa);
                        return g;
                    }  
            }

            otherx = quadMethodTwo(a, b, c);

            double quadMethodTwo(int aa, int bb, int cc)
            {
                checked
                    {
                        double d = (bb * bb) - (4 * aa * cc);
                        if (d < 0)
                        {
                            throw new ArgumentOutOfRangeException("This program can not accept those coefficient values");
                        }
                        double e = Math.Sqrt(d);
                        double f = (-1 * bb) - e;
                        double g = f / (2 * aa);
                        return g;
                    } 
            }
            showResults();

            void showResults()
                {
                    Console.WriteLine("The first value of x = {0}", x);
                    Console.WriteLine("The second value of x = {0}", otherx);
                }
            
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
                Console.WriteLine("Thank you for using the quadratic equation program");
            }
        }
    }
}

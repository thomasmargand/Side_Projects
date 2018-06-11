using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine("Hello and welcome to the circle program!");
                Console.Write("Please enter a value for the radius to begin: ");
                double radius = double.Parse(Console.ReadLine());

                if (radius < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius can not be a negative number!");
                }

                double pie = 3.14159;
                double circumference = checked(2 * pie * radius);
                double area = checked(radius * radius * pie);
                double volume = checked(1.33333 * pie * (radius * radius * radius) / 2);      //This will ignore 4/3 unless I enter it as a decimal
                                                                                              //I'm sure this has something to do with the data type
                Console.WriteLine("The circumference of your circle is {0}", circumference);  //as a repeating decimal exceeds the double format, but I
                Console.WriteLine("The area of your circle is {0}", area);                    //dont know how to fix it.  
                Console.WriteLine("The volume of your hemisphere is {0}", volume);            
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
                Console.WriteLine("Thank you for using the circle program");
            }
        }
    }
}

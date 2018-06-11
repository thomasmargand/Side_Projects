using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the integer to convert: ");
            string n1 = Console.ReadLine();
            int number = int.Parse(n1);
            Console.Write("Please enter the base to convert from: ");
            string n2 = Console.ReadLine();
            int from = int.Parse(n2);
            Console.WriteLine($"Number: {number}, base:{from}");
            int result = 0;
            if (from == 10)
            {
                result = dec2bin(number);
                Console.WriteLine($"binary conversion is {result}");
                result = dec2oct(number);
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 2)
            {
                result = bin2dec(number);
                Console.WriteLine($"decimal conversion is {result}");
                result = bin2oct(number);
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 8)
            {
                result = oct2bin(number);
                Console.WriteLine($"binary conversion is {result}");
                result = oct2dec(number);
                Console.WriteLine($"decimal conversion is {result}");
            }
            else
                Console.WriteLine("Error in base to convert from");
            int dec2bin(int n)
            {
                int acc = 0;
                int factor = 1;

                while (n > 0)
                {
                    int i = n % 2;
                    n = n / 2;
                    acc += i * factor;
                    factor *= 10;
                }

                return acc;
            }

            int dec2oct(int n)
            {
                int acc = 0;
                int factor = 1;

                while (n > 0)
                {
                    int i = n % 8;
                    n = n / 8;
                    acc += i * factor;
                    factor *= 10;
                }

                return acc;
            }
            int bin2dec(int n)
            {
                double acc = 0;
                double power = 0;

                while (n > 0)
                {
                    int i = n % 10;
                    double j = i * Math.Pow(2, power);
                    acc += j;
                    power++;
                    n = n / 10;
                }
                return (int)acc;
            }
            int bin2oct(int n)
            {
                int acc = 0;
                int factor = 1;

                while (n > 0)
                {
                    int i = n % 1000;
                    int j = i % 10;
                    int k = ((i / 10) % 10) * 2;
                    int l = (i / 100) * 4;
                    int m = j + k + l;
                    acc += m * factor;
                    factor *= 10;
                    n = n / 1000;
                }
                return acc;
            }
            int oct2bin(int n)
            {
                int j = 0;
                int k = 0;
                int answer = 0;
                int factor = 1;

                while(n >0)
                {
                    j = n % 10;
                    k = dec2bin(j);
                    answer += k * factor;
                    factor *= 1000;
                    n = n / 10;
                }
                return answer;
            }
            int oct2dec(int n)
            {
                double acc = 0;
                double factor = 0;

                while (n > 0)
                {
                    int i = n % 10;
                    acc += (i * Math.Pow(8, factor));
                    factor++;
                    n = n / 10;
                }

                return (int)acc;
            }
        } 
    }
}

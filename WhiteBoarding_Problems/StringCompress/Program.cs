using System;

namespace StringCompress
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This program compresses like characters in a string. For 
             * example for the user input string aaabbccc the program would
             * return a3b2c3.  If the new string is longer than the original
             * string it will return the old string. */

            Console.WriteLine("Please enter a string to be compressed: ");
            string input = Console.ReadLine();
            Console.WriteLine(Compress(input));

            string Compress(string s)
            {
                string output = "";
                int sum = 1;

                for(int i = 0; i < s.Length -1; i++)
                {
                    if(s[i] == s[i + 1])
                    {
                        sum++;
                    }
                    else
                    {
                        output = output + s[i] + sum;
                        sum = 1;
                    }
                }
                output = output + s[s.Length - 1] + sum;
                if (output.Length > s.Length)
                {
                    return s;
                }
                else return output;
            }
        }
    }
}

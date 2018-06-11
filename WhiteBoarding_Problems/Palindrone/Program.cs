using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrone
{
    class Program
    {
        static void Main(string[] args)
        {

            /* This program checks to see if a user given input is a palindrone.
             * I solved it first with a while loop then solved it again with a for loop
             * for more practice and to see if I could. */

            string userWord = Console.ReadLine();

            Console.WriteLine(IsPalindrone(userWord));
            Console.WriteLine(IsPalindrone2(userWord));

            bool IsPalindrone(string word)
            {
                for (int start = 0, end = word.Length - 1; start < end; start++, end--)
                {
                    if (word[start] != word[end])
                    {
                        return false;
                    }
                }    
                return true;
            }

            bool IsPalindrone2(string word)
            {
                int start = 0;
                int end = word.Length - 1;

                while (start < end)
                {
                    if (word[start] != word[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
                return true;
            }

        }
    }
}

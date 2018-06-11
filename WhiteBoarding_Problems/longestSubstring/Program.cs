using System;
using System.Linq;

namespace longestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Given a string, find the length of the longest substring without repeating characters.
             * For example the string abcabcbb should return abc as this is the longest substring of
             * non repeating characters. This program is incomplete and doesn't work for all strings,
             * however it is close. After reading through some solutions to this problem I realized 
             * I took an entirely different approach to the problem than most.*/ 
            
            Console.WriteLine("Please enter a string: ");
            string input = Console.ReadLine();
            string answer = longestSub(input);
            Console.WriteLine(answer);                   

            string longestSub(string s)
            {
                string output2 = "";                
                int count2 = 0;
                string output = "";
                int count = 1;

                for (int i = 0; i < s.Length - 1; i++)
                {                   
                    if (s[i] != s[i + 1])
                    {                        
                        if(output.Contains(s[i]) == false && output.Contains(s[i + 1]) == false)
                        {
                            count++;
                            output = output + s[i] + s[i + 1];
                        }
                        if(output.Contains(s[i + 1]) == false)
                        {
                            count++;
                            output = output + s[i + 1];
                        }
                        
                    }                    
                    if (s[i] == s[i + 1])
                    {
                        if (count > count2)
                        {
                            count2 = count;
                            output2 = output;                            
                        }
                        count = 1;
                        output = "";
                    }
                }
                return output2;
            }

        }
    }
}

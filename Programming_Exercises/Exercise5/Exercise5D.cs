using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5D
{
    class Exercise5D
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            for (int i = 0; i < C.Length - 1; i++)
            {
                int next = i + 1;
                Console.WriteLine($"{i}: {C[i]}   {next}: {C[next]}");
                if (C[i] > C[next])
                {
                    int temp = C[i];
                    C[next] = C[i];
                    C[i] = temp;
                      
                }
            }

            foreach (int item in C)
            {
                Console.WriteLine(item);
            }
        }
    }
}

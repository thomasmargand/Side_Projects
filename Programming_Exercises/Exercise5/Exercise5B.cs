using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5B
{
    class Exercise5B
    {
        static void Main(string[] args)
        {
            int[] A = {0, 2, 4, 6, 8, 10};
            int[] B = {1, 3, 5, 7, 9};
            int[] C = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9};

            void reverseArray(int[] p)
            {
                int[] D = new int[p.Length];
                for (int i = 0; i < p.Length; i++)
                {
                    int J = (p.Length - i);
                    D[i] = p[--J];
                }

                foreach(int E in D)
                {
                    Console.WriteLine(E);
                }

            }
            reverseArray(A);
        }
    }
}

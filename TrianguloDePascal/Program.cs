using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloDePascal
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 9; n++)
            {
                for (int k = 0; k <= n; k++)
                {
                    Console.Write("{0,5}", c(n, k));
                }
                Console.WriteLine();
            }
        }

        static int c(int n, int k)
        {
            return fatorial(n) / (fatorial(k) * fatorial(n - k));
        }

        static int fatorial(int n)
        {
            int fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }
            return fatorial;
        }

    }
}

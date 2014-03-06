using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());

            int c = fatorial(n) / (fatorial(k) * fatorial(n - k));

            Console.WriteLine("C({0}, {1}) = {2}", n, k, c);
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

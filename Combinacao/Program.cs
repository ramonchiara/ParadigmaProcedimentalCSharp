using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());

            int fatorialN = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorialN = fatorialN * i;
            }

            int fatorialK = 1;
            for (int i = 1; i <= k; i++)
            {
                fatorialK = fatorialK * i;
            }

            int fatorialNK = 1;
            for (int i = 1; i <= (n - k); i++)
            {
                fatorialNK = fatorialNK * i;
            }

            int c = fatorialN / (fatorialK * fatorialNK);

            Console.WriteLine("C({0}, {1}) = {2}", n, k, c);
        }
    }
}

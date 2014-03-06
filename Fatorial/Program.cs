using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("n! = {0}", fatorial);
        }
    }
}

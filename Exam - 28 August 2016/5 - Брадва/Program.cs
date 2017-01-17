using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}", new string('-',3*n), new string('*', 2), new string('-', n*2 -2));

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('-', 3 * n), new string('*', 1), new string('-', 1+i), new string('*', 1), new string('-',n*2-3 -i));

            }
            for (int j = 0; j < n/2; j++)
            {
                Console.WriteLine("{0}{1}{2}{3}", new string('*', 3 * n +1), new string('-', n-1), new string('*',1), new string('-', n - 1));
            }
            for (int k = 0; k < (n-2)/2; k++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('-', 3 * n-k), new string('*',1),new string('-', n-1+2*k), new string('*', 1), new string('-',n-1-k));
            }
            if (n%2==0)
            {
                Console.WriteLine("{0}{1}{2}", new string('-', (5 * n) / 2 + 1), new string('*', 2 * n - 1), new string('-', (n + 1) / 2));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", new string('-', (5 * n) / 2 + 2), new string('*', 2 * n - 2), new string('-', (n + 1) / 2));
            }
        }
    }
}

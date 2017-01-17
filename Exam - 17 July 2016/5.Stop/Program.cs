using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Знак_СТОП
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            Console.WriteLine("{0}{1}{2}", new string('.', n + 1), new string('_', n * 2 + 1), new string('.', n + 1));

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0}{1}{2}{3}{4}", new string('.', n - i), new string('/', 2),
                    new string('_', 2 * n - 1 + i * 2), new string('\\', 2), new string('.', n - i));
            }
            Console.WriteLine("{0}{1}{2}{3}{4}", new string('/', 2), new string('_', 2 * n - 3), "STOP!", new string('_', 2 * n - 3), new string('\\', 2));
            Console.WriteLine("{0}{1}{2}", new string('\\', 2), new string('_', 4 * n - 1), new string('/', 2));

            for (int j = 0; j < n - 1; j++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('.', 1 + j), new string('\\', 2),
                    new string('_', 4 * n - 3 - count), new string('/', 2), new string('.', 1 + j));
                count += 2;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', 2 * n - 1) + new string('/', 1) + new string('|', 1) + new string('\\', 1) + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + new string('\\', 1) + new string('|', 1) + new string('/', 1) + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + new string('*', 3) + new string('.', 2 * n - 1));

            for (int i = 0; i < n * 2 - 1; i++)
            {
                Console.WriteLine(new string('.', 2 * n - 2 - i) + new string('*', 1) + new string('-', 1 + i) + new string('*', 1) + new string('-', 1 + i) + new string('*', 1) + new string('.', 2 * n - 2 - i));
            }

            Console.WriteLine(new string('*', 4 * n + 1));
            Console.Write((String.Concat(Enumerable.Repeat("*.", 2*n))));
            Console.WriteLine(new string('*', 1));
            Console.WriteLine(new string('*', 4 * n + 1));


        }
    }

}
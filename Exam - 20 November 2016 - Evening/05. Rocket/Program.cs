using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', (n *3)/2 -1 -i) + new string('/', 1) + new string(' ', i*2) + new string('\\', 1) + new string('.', (n * 3) / 2 -1 - i));
            }

            Console.WriteLine(new string('.', n/2) + new string('*', n*2) + new string('.', n/2));

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine(new string('.', n/2)+ new string('|', 1) + new string('\\', 2*n -2) + new string('|', 1) + new string('.', n / 2));
            }
            var count = 0;
            for (int j = 0; j < n/2; j++)
            {
                count += 2;
                Console.WriteLine(new string('.', n/2 - j) + new string('/', 1) + new string('*', n*2-4 + count) + new string('\\', 1) + new string('.', n/2-j));
            }
        }
    }
}

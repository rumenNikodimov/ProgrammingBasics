using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            {
                Console.WriteLine(new string(' ', n - 1) + new string('*', 1) + new string(' ', n - 1));

                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write(new string(' ', n-2-i) + String.Concat(Enumerable.Repeat("*-", 1 + i)));
                    Console.WriteLine(new string('*', 1));
                }
                for (int i = 1; i <= n-1; i++)
                {
                    Console.Write(new string(' ', i) + String.Concat(Enumerable.Repeat("*-", n-1 - i)));
                    Console.WriteLine(new string('*', 1));
                }
            }
        }
    }
}

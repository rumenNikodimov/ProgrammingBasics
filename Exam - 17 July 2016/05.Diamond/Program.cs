using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var count1 = 0;
            var top = 3 * n;
            var midle = 5 * n;
            var bottom = 2 * n + 1;


            Console.WriteLine("{0}{1}{2}", new string('.', n), new string('*', top), new string('.', n));


            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', n-i), new string('.', top +count), new string('.', n-i));
                count += 2;
            }
           
            Console.WriteLine(new string('*', midle));

            for (int i = 0; i < bottom-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', 1+i),new string('.', midle - 4 - count1), new string('.', 1 + i));
                count1 += 2;
            }
            Console.WriteLine("{0}{1}{2}", new string('.', bottom), new string('*', midle - 2 * bottom), new string('.', bottom));
        }
    }
}

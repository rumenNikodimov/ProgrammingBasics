using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var count1 = 0;

            for (int i = 0; i < n; i++)
                
            {
                count += 1;
                Console.WriteLine(new string('*', count)+ new string('\\',1) + new string('-', n*2-1 -i*2) + new string('/',1) + new string('*',count));
            }
            for (int j = 0; j < n/3; j++)
            {
                Console.WriteLine(new string('|', 1) + new string('*', n / 2 + j) + new string('\\', 1) + new string('*', n - 2*j ) + new string('/', 1 ) + new string('*', n / 2 + j) + new string('|', 1));
            }


            for (int i = 0; i < n; i++)

            {
                count1 += 1;
                Console.WriteLine(new string('-', count1) + new string('\\', 1) + new string('*', n * 2 - 1 - i * 2) + new string('/', 1) + new string('-', count1));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 1;
            var count1 = 1;
            var midlecount = 0;
            var midlePart = n / 2;

            for (int i = 0; i < n; i++)
            {
                var firstSide = new string('*', i + 1) + '\\' + new string('-', 2 * n - (i + count)) + '/' + new string('*', i + 1);
                count += 1;
                Console.WriteLine(firstSide);
            }

            for (int i = 0; i < n / 3; i++)
            {

                var midleSide = new string('|', 1) + new string('*', midlePart + i) + new string('\\', 1) + new string('*', n - midlecount) + new string('/', 1)
                    + new string('*', midlePart + i) + new string('|', 1);
                midlecount += 2;

                Console.WriteLine(midleSide);
            }
            for (int i = 0; i < n; i++)
            {
                var thirdSide = new string('-', i + 1) + '\\' + new string('*', 2 * n - (count1)) + '/' + new string('-', i + 1);
                count1 += 2;
                Console.WriteLine(thirdSide);
            }
        }
    }
}

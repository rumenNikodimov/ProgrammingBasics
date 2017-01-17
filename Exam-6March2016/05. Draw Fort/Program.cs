using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var roof = n / 2;

            
                var roof = new string('/', 1) + new string('^', n / 2) + new string('\\', 1)+ new string('_', (n+1)/2-2)+new string('_', (n+1)/2-2) + new string('/', 1) +
                    new string('^', n / 2) + new string('\\', 1);
                Console.WriteLine(roof);
  
            for (int j = 1; j <= n-3; j++)
            {
                var midleSide = new string('|', 1) + new string(' ', 2 * n - 2) + new string('|', 1);
                Console.WriteLine(midleSide);
            }
            var underScore = new string('|', 1) + new string(' ', n / 2 + 1) + new string('_', (n + 1) / 2 - 2) + new string('_', (n + 1) / 2 - 2) +
                new string(' ', n / 2 + 1) + new string('|', 1);
            Console.WriteLine(underScore);
            var basic = new string('\\', 1) + new string('_', n / 2) + new string('/', 1)+ new string(' ', (n+1)/2-2)+new string(' ', (n+1)/2-2) + new string('\\', 1) + 
                new string('_', n /2) + new string('/',1);
            Console.WriteLine(basic);
        }
    }
}

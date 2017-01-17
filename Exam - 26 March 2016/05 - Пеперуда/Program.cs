using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Пеперуда
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var z = (n * 2) / 6;


            var firstSide = new string('*', n - 2) + new string('\\', 1) + new string(' ', 1) + new string('/', 1) + new string('*', n - 2);
            Console.WriteLine(firstSide);

            for (int j = 0; j < z; j++)
            {
                var midlePart = new string('-', n - 2) + new string('\\', 1) + new string(' ', 1) + new string('/', 1) + new string('-', n - 2);
                Console.WriteLine(midlePart);
                //break;   
                for (int k = 0; k < 1; k++)
                {
                    var firsSide = new string('*', n - 2) + new string('\\', 1) + new string(' ', 1) + new string('/', 1) + new string('*', n - 2);
                    Console.WriteLine(firsSide);
                }
            }


            var midle = new string(' ', n - 1) + new string('@', 1) + new string(' ', n - 1);
            Console.WriteLine(midle);

            var firSide = new string('*', n - 2) + new string('/', 1) + new string(' ', 1) + new string('\\', 1) + new string('*', n - 2);
            Console.WriteLine(firSide);

            for (int l = 0; l < z; l++)
            {
                var midlePart = new string('-', n - 2) + new string('/', 1) + new string(' ', 1) + new string('\\', 1) + new string('-', n - 2);
                Console.WriteLine(midlePart);
                //break;   
                for (int m = 0; m < 1; m++)
                {
                    var firsSide = new string('*', n - 2) + new string('/', 1) + new string(' ', 1) + new string('\\', 1) + new string('*', n - 2);
                    Console.WriteLine(firsSide);
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var allP1 = p1 * h;
            var allP2 = p2 *h;
            var all = allP1 + allP2;

            var percentOfP1 = allP1 * 100 / all;
            var percentOfP2 = allP2 * 100 / all;

            var PercenOFFull = all * 100 / v;
            var def = Math.Abs(v - all);

            if (v>=all)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(PercenOFFull), 
                    Math.Truncate(percentOfP1), Math.Truncate(percentOfP2));

            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, def);

            }

        }
    }
}

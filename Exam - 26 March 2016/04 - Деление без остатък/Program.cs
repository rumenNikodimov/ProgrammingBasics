using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) p1++;
                if (num % 3 == 0) p2++;
                if (num % 4 == 0) p3++;
               
            }
            var percentP1 = p1 * 100 / n;
            var percentP2 = p2 * 100 / n;
            var percentP3 = p3 * 100 / n;
            Console.WriteLine("{0:f2}%", percentP1);
            Console.WriteLine("{0:f2}%", percentP2);
            Console.WriteLine("{0:f2}%", percentP3);
        }
    }
}

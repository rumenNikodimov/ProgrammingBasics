using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
     
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            var p4 = 0;
            var p5 = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200) p1++;
                else if (num < 400) p2++;
                else if (num < 600) p3++;
                else if (num < 800) p4++;
                else p5++;
            }
            var sump1 = p1 * 100 / n;
            var sump2 = p2 * 100 / n;
            var sump3 = p3 * 100 / n;
            var sump4 = p4 * 100 / n;
            var sump5 = p5 * 100 / n;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}

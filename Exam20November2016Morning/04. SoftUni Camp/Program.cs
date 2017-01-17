using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            double auto = 0;
            double microBus = 0;
            double miniBus = 0;
            double bus = 0;
            double train = 0;

            for (int i = 0; i < num; i++)
            {
                var n = double.Parse(Console.ReadLine());

                if (n <= 5)
                {
                    auto += n;
                }
                else if (n >= 6 && n <= 12)
                {
                    microBus += n;
                }
                else if (n >= 13 && n <= 25)
                {
                    miniBus += n;
                }
                else if (n >= 26 && n <= 40)
                {
                    bus += n;
                }
                else if (n > 40)
                {
                    train += n;
                }
            }
            var all = (auto + microBus + miniBus + bus + train);
            Console.WriteLine("{0:f2}" + "%", (auto / all * 100));
            Console.WriteLine("{0:f2}" + "%", (microBus / all * 100));
            Console.WriteLine("{0:f2}" + "%", (miniBus / all * 100));
            Console.WriteLine("{0:f2}" + "%", (bus / all * 100));
            Console.WriteLine("{0:f2}" + "%", (train / all * 100));
        }
    }
}

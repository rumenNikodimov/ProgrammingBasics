using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lastnum = int.MinValue;
            int num;
            var count = 0;
            var max = 0;

            for (int i = 1; i <= n; i++)
            {

                num = int.Parse(Console.ReadLine());

                if (num > lastnum)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                lastnum = num;

                if (count > max)
                {
                    max = count;
                }
            }
            Console.WriteLine(max);
        }
    }
}

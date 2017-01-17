using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var read = 0;
            var sum = 0;
            var sum1 = 0;
            var sum2 = 0;
            var count1 = 1;
            var count2 = 2;
            var count3 = 3;

            for (int i = 1; i <= n; i++)
            {
                read = int.Parse(Console.ReadLine());

                if (count1 == i)
                {
                    count1 += 3;
                    sum += read;
                }
                else if (i == count2)
                {
                    count2 += 3;
                    sum1 += read;
                }
                else if (i == count3)
                {
                    count3 += 3;
                    sum2 += read;
                }
            }
            Console.WriteLine("sum1 = {0}", sum);
            Console.WriteLine("sum2 = {0}", sum1);
            Console.WriteLine("sum3 = {0}", sum2);

        }
    }
}

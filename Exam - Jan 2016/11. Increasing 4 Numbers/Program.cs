using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var diference = Math.Abs(a-b);

            if (diference<4)
            {
                Console.WriteLine("No");
            }

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j < b; j++)
                {
                    for (int k = a; k < b; k++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            if (a <= i && i < j && j < k && k < l && l <= b)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);

                            }
                            
                        }
                    }
                }
            }
        }
    }
}
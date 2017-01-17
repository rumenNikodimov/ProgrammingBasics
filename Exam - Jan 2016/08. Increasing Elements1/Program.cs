using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            for (int left = -n; left <=0; left++)
            {
                for (int top = n; top>=0; top--)
                {
                    for (int right = -n; right <=0; right++)
                    {
                        for (int bottom = n; bottom >= 0; bottom--)
                        {
                            if (n >= left && left < right && right <= n)
                            {
                                Console.WriteLine($"({left}, {top})({right}, {bottom})");
                            }
                        }
                    }
                }
            }

        }
    }
}

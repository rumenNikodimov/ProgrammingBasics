using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    Console.Write("<{0}-{1}>", i, j);
                    count++;
                    if (count == maxCombinations)
                    {
                        return;
                    }
                }
            }
        }
    }
}

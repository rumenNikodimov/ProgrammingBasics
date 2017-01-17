using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            var firstRow = new string('%', 2 * n);
            Console.WriteLine(firstRow);

            for (int i = 0; i < n - 3; i++)
            {
                var midlePart = new string('%', 1) + new string(' ',2*n -2) + new string('%', 1);
                Console.WriteLine(midlePart);
            }
            if (n%2==0)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.WriteLine(new string('%', 1) + new string(' ', 2*n-2) + new string('%', 1));

                }
            }
           
            Console.WriteLine(firstRow);

        }
    }
}

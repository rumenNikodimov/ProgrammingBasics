using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___Jan_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
           
            if (num1 == num2+num3)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(num3, num2), Math.Max(num3, num2), num1);

            }
            else if (num2 == num1 + num3)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(num1, num3), Math.Max(num1, num3), num2);

            }
            else if (num3 == num2 + num1)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(num1, num2), Math.Max(num1, num2), num3);

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

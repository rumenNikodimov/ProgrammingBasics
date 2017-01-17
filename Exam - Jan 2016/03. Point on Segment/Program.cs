using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var diference = Math.Abs(firstNum - point);
            var diference1 = Math.Abs(secondNum - point);

            if ((firstNum <=  point && secondNum >= point) || (firstNum >= point && secondNum <= point))
            {
                Console.WriteLine("in");
                Console.WriteLine("{0}", Math.Min(diference,diference1));
            }
            else 
            {
                Console.WriteLine("out");
                Console.WriteLine("{0}", Math.Min(diference, diference1));
            }

        }
    }
}

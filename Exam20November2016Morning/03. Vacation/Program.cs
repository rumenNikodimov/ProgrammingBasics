using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            var trans = Console.ReadLine();
            var Noshtuvki = 82.99 * num3;
            var comisionna = 0.10;
            double AllTrans = 0;
            if (trans == "train")
            {
                AllTrans = (((num1 * 24.99) + (num2 * 14.99))*2);
                if (num1 + num2 >= 50)
                {
                    AllTrans = AllTrans / 2;
                }
                var commision = (Noshtuvki + AllTrans) * 0.1;
                Console.WriteLine("{0:f2}", (commision + Noshtuvki + AllTrans));
            }
            else if (trans == "bus")
            {
                AllTrans = (((num1 * 32.50) + (num2 * 28.50)) * 2);
                var commision = (Noshtuvki + AllTrans) * 0.1;
                Console.WriteLine("{0:f2}", (Noshtuvki + AllTrans + commision));
            }
            else if (trans == "boat")
            {
                AllTrans = (((num1 * 42.99) + (num2 * 39.99)) * 2);
                var commision = (Noshtuvki + AllTrans) * 0.1;
                Console.WriteLine("{0:f2}", (Noshtuvki + AllTrans + commision));
            }
            else if (trans == "airplane")
            {
                AllTrans = (((num1 * 70) + (num2 * 50))*2);
                var commision = (Noshtuvki + AllTrans) * 0.1;
                Console.WriteLine("{0:f2}", (Noshtuvki + AllTrans + commision));
            }

        }
    }
}

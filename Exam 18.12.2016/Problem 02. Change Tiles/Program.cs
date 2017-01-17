using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var spendMoney = double.Parse(Console.ReadLine());
            var shirinaNaPoda = double.Parse(Console.ReadLine());
            var daljinaNaPoda = double.Parse(Console.ReadLine());
            var stranaNaTriugulnika = double.Parse(Console.ReadLine());
            var visochinaNaTriugulnika = double.Parse(Console.ReadLine());
            var cenaNaPlochka = double.Parse(Console.ReadLine());
            var sumNaMaistora = double.Parse(Console.ReadLine());

            var triangleArea = stranaNaTriugulnika * visochinaNaTriugulnika / 2;
            var area = shirinaNaPoda * daljinaNaPoda;
            var broiPlochki = Math.Ceiling(area / triangleArea + 5);

            var price = broiPlochki * cenaNaPlochka + sumNaMaistora;

            var def = Math.Abs(price - spendMoney);

            if (spendMoney>=price)
            {
                Console.WriteLine("{0:f2} lv left.", def);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", def);
            }
           

        }
    }
}

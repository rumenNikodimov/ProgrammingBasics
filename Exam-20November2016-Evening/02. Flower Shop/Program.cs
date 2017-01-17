using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var zumbul = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var kaktus = int.Parse(Console.ReadLine());
            double priceForPresent = double.Parse(Console.ReadLine());

            double priceOfMagnolii = magnolii * 3.25;
            double priceOfZumbul = zumbul * 4.00;
            double priceOfRoses = roses * 3.50;
            double priceOfKaktus = kaktus * 8.00;

            double allMoney = priceOfMagnolii + priceOfZumbul + priceOfRoses + priceOfKaktus;
            double totalMoney = allMoney * 0.95;

            double diference = Math.Abs(priceForPresent - totalMoney);

            if (totalMoney >= priceForPresent)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(diference));
            }
            else if (totalMoney < priceForPresent)
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(diference));
            }           
        }
    }
}

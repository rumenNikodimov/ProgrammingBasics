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
            var numberOfMagnolii = int.Parse(Console.ReadLine());
            var numberOfZumbuli = int.Parse(Console.ReadLine());
            var numberOfRoses = int.Parse(Console.ReadLine());
            var numberOfCactus = int.Parse(Console.ReadLine());
            var priceOfPresent = double.Parse(Console.ReadLine());
            var priceOfFlowers = (numberOfMagnolii * 3.25 + numberOfZumbuli * 4 + numberOfRoses * 3.50 + numberOfCactus * 8) * 0.95;
            var difference = Math.Abs(priceOfFlowers - priceOfPresent);

            if (priceOfPresent <= priceOfFlowers)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(difference));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(difference));
            }
        }
    }
}

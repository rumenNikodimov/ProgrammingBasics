using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaOfVineyard = double.Parse(Console.ReadLine());
            var grapesPerQuare = double.Parse(Console.ReadLine());
            var needLitersWine = double.Parse(Console.ReadLine());
            var numberOFEmployes = double.Parse(Console.ReadLine());
            double harvest = areaOfVineyard * grapesPerQuare;
            double grapesForWine = harvest * 0.40;
            double litersWine = grapesForWine / 2.5;
            double diference = Math.Abs(needLitersWine - litersWine);

            if (needLitersWine <= litersWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(litersWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(diference), Math.Ceiling(diference/numberOFEmployes));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(diference));
            }
        }
    }
}

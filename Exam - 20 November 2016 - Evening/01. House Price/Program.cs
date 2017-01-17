using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var pricePerM2 = double.Parse(Console.ReadLine());
            var bathRoom = smallestRoom / 2;
            var secondRoom = smallestRoom * 1.10;
            var thirdRoom = secondRoom * 1.10;
            var coridoor = (smallestRoom + secondRoom + thirdRoom + kitchen + bathRoom) * 0.05;
            var allArea = (smallestRoom + secondRoom + thirdRoom + kitchen + bathRoom + coridoor) * pricePerM2;

            Console.WriteLine("{0:f2}",allArea);
        }
    }
}

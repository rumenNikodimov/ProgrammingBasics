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
            var smallestRoomSize = double.Parse(Console.ReadLine());
            var kitchenSize = double.Parse(Console.ReadLine());
            var pricePerM2 = double.Parse(Console.ReadLine());

            double bathroomSize = smallestRoomSize / 2;
            double secondRoom = smallestRoomSize + (smallestRoomSize* 0.10);
            double thirdRoom = secondRoom + (secondRoom * 0.10);
            double tempArea = smallestRoomSize + kitchenSize + bathroomSize + secondRoom + thirdRoom;
            double coridor = tempArea * 0.05;

            double area = (tempArea + coridor)*pricePerM2;
            
            Console.WriteLine("{0:f2}", area);
        }
    }
}

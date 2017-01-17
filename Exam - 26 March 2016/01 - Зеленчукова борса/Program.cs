using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVegitables = double.Parse(Console.ReadLine());
            var priceFriuts = double.Parse(Console.ReadLine());
            var allVegitables = int.Parse(Console.ReadLine());
            var allFriuts = int.Parse(Console.ReadLine());
            var price = (priceVegitables * allVegitables + priceFriuts * allFriuts) /1.94;
            Console.WriteLine(price);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var aveableFood = int.Parse(Console.ReadLine());
            var foodPerDayForDog = double.Parse(Console.ReadLine());
            var foodPerDayForCat = double.Parse(Console.ReadLine());
            var foodPerDayForTurtleInGrams = double.Parse(Console.ReadLine());
            var foodPerDayForTurtle = foodPerDayForTurtleInGrams / 1000;
            var foodForDog = foodPerDayForDog * days;
            var foodForCat = foodPerDayForCat * days;
            var foodForTurtle = foodPerDayForTurtle * days;
            var foodAll = foodForDog + foodForCat + foodForTurtle;
            var foodDeference = Math.Abs(aveableFood - foodAll);
            //Console.WriteLine(foodPerDayForTurtle);
            if (aveableFood >= foodAll)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodDeference));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodDeference));
            }
        }
    }
}
 
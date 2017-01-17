using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersOfPockemons1 = int.Parse(Console.ReadLine());
            var numbersOfPockemons2 = int.Parse(Console.ReadLine());
            var numbersOfFights = int.Parse(Console.ReadLine());
            var count = 0;



            for (int j = 1; j <= numbersOfPockemons1; j++)
            {
                for (int k = 1; k <= numbersOfPockemons2; k++)

                {
                    Console.Write("({0} <-> {1}) ", j, k);
                    count++;
                    if (count == numbersOfFights)
                    {
                        return;
                    }
                }
            }
        }
    }
}

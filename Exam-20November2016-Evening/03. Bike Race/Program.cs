using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfJuniors = int.Parse(Console.ReadLine());
            int numbersOfSeniors = int.Parse(Console.ReadLine());
            var roadType = Console.ReadLine();
            double trail = (numbersOfJuniors * 5.50) + (numbersOfSeniors * 7);
            double crossCountry = numbersOfJuniors * 8 + numbersOfSeniors * 9.50;
            double downHill = numbersOfJuniors * 12.25 + numbersOfSeniors * 13.75;
            double road = numbersOfJuniors * 20 + numbersOfSeniors * 21.50;

            if (roadType=="trail")
            {
                Console.WriteLine("{0:f2}", trail*0.95);
            }
            else if (roadType=="cross-country" && (numbersOfJuniors+numbersOfSeniors)>=50)
            {
                crossCountry = crossCountry * 0.75;
                Console.WriteLine("{0:f2}", crossCountry*0.95);
            }
            else if (roadType == "cross-country" && (numbersOfJuniors + numbersOfSeniors) < 50)
            {
                Console.WriteLine("{0:f2}", crossCountry * 0.95);
            }
            else if (roadType=="downhill")
            {
                Console.WriteLine("{0:f2}", downHill*0.95);
            }
            else if (roadType=="road")
            {
                Console.WriteLine("{0:f2}", road*0.95);
            }
        }
    }
}

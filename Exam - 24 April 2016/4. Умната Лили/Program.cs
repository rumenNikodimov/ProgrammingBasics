using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceWasher = double.Parse(Console.ReadLine());
            var priceOfToy = double.Parse(Console.ReadLine());

            var moneyb = 0;
            var count = 0;
            var money2 = 0;
            var oddYears = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {                  
                        money2 += 10;
                        moneyb += money2;                                     
                }
                else
                {
                 
                    oddYears += 1;
                }
            }

            var moneyToys = oddYears * priceOfToy;
            var evenyears = age - oddYears;
            var moneyBirth = moneyb - (evenyears*1);
            var allMoney = moneyToys + moneyBirth;
            var def = Math.Abs(allMoney-priceWasher);

            if (priceWasher<=allMoney)
            {
                Console.WriteLine("Yes! {0:F2}", def);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", def);
            }

           // Console.WriteLine(allMoney);
            //Console.WriteLine(moneyb);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var baseYearSpending = 12000;
            var curentMoneyEven = 0;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money -= baseYearSpending;
                    curentMoneyEven += baseYearSpending;
                }
                else
                {
                    var currentYears = 18 + (i - 1800);
                    var additionalSpendings = 50 * currentYears;
                    var totalSpendings = baseYearSpending + additionalSpendings;
                    money -= totalSpendings;
                }
            }

            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0} dollars to survive.", Math.Abs(money));
            }
        }
    }
}

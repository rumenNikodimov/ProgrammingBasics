using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var changeUSD = double.Parse(Console.ReadLine());

            var moneyPerMonth = workDays * moneyPerDay;
            var moneyPerYear = ((moneyPerMonth * 12)+(moneyPerMonth *2.5));
            var moneyAll = (moneyPerYear  *0.75)*changeUSD;
            double moneyPerDay1 = moneyAll / 365;

            Console.WriteLine("{0:f2}", moneyPerDay1);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var numberOfFans = int.Parse(Console.ReadLine());
            double budgetForTransport = 0.00;
            double priceForTickets = 0.00;

            if (numberOfFans <= 4)
            {
                budgetForTransport = budget * 0.75;
            }
            if (numberOfFans >= 5 && numberOfFans <= 9)
            {
                budgetForTransport = budget * 0.60;
            }
            if (numberOfFans >= 10 && numberOfFans <= 24)
            {
                budgetForTransport = budget * 0.50;
            }
            if (numberOfFans > 24 && numberOfFans < 50)
            {
                budgetForTransport = budget * 0.40;
            }
            if (numberOfFans >= 50)
            {
                budgetForTransport = budget * 0.25;
            }
            if (category == "VIP")
            {
                priceForTickets = numberOfFans * 499.99;
            }
            if (category == "Normal")
            {
                priceForTickets = numberOfFans * 249.99;
            }
            double allMoney = priceForTickets + budgetForTransport;
            double diference = Math.Abs((priceForTickets + budgetForTransport) - budget);

            if (budget >= allMoney )
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", diference);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", diference);
            }
        }
    }
}

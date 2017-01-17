using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var days = int.Parse(Console.ReadLine());
            var priceForApartment = 0.00;
            var priceForApartment1 = 0.00;
            var priceForStudio = 0.00;
            var priceForStudio1 = 0.00;

            if (month == "May" || month == "October")
            {
                priceForStudio = 50 * days;
                priceForApartment = 65 * days;               
            }
            if (month == "June" || month == "September")
            {
                priceForStudio = 75.20 * days;
                priceForApartment = 68.70 * days;             
            }
            if (month == "July" || month == "August")

            {
                priceForStudio = 76 * days;
                priceForApartment = 77 * days;
            }
            if (days > 7 &&days <=14 && (month == "May" || month == "October"))
            {
                priceForStudio1 = priceForStudio * 0.95;
                priceForStudio = priceForStudio1;
            }
            if (days > 14 && (month == "May" || month == "October"))
            {
                priceForStudio1 = priceForStudio * 0.70;
                priceForStudio = priceForStudio1;
            }
            if (days > 14 && (month == "June" || month == "September"))
            {
                priceForStudio1 = priceForStudio * 0.80;
                priceForStudio = priceForStudio1;
            }
            if (days >14)
            {
                priceForApartment1 = priceForApartment * 0.90;
                priceForApartment = priceForApartment1;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", priceForApartment);
            Console.WriteLine("Studio: {0:f2} lv.", priceForStudio);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numBuyHrizantemi = int.Parse(Console.ReadLine());
            var numBuyRozi = int.Parse(Console.ReadLine());
            var numBuylaleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var praznik = Console.ReadLine();

            var priceHrizantemi = 0.00;
            var priceRozi = 0.00;
            var priceLaleta = 0.00;
            var numberOfallFlowers = numBuyHrizantemi + numBuyRozi + numBuylaleta;
            double sum = 0.00;
            double sum1 = 0.00;


            if (season == "Spring" || season == "Summer")
            {
                priceHrizantemi = 2.00;
                priceRozi = 4.10;
                priceLaleta = 2.50;
            }
            if (season == "Autumn" || season == "Winter")
            {
                priceHrizantemi = 3.75;
                priceRozi = 4.50;
                priceLaleta = 4.15;
            }
            sum = (numBuyHrizantemi * priceHrizantemi) + (numBuyRozi * priceRozi) + (numBuylaleta * priceLaleta);
            if (praznik == "Y")
            {
                sum = sum * 1.15;
               
            }
           
            if (numBuylaleta > 7 && season == "Spring")
            {
                sum = sum * 0.95;
               
            }
            if ((numBuyRozi >=10) && (season=="Winter"))
            {
                sum = sum * 0.90;
                
            }
            if (numberOfallFlowers>=20)
            {
                sum = sum * 0.80;
               
            }
            Console.WriteLine("{0:f2}", sum + 2);
        }
    }
}


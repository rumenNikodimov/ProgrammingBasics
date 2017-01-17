using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSkumriq = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());

            double pricePalamud = (priceSkumriq * 1.6)*kgPalamud;
            double priceSafrid = (priceCaca * 1.8)*kgSafrid;
            double priceMidi = kgMidi * 7.50;
            double priceAll = pricePalamud + priceSafrid + priceMidi;
            
           Console.WriteLine("{0:f2}", priceAll);
           
           //Console.WriteLine(priceSafrid);
           //Console.WriteLine(pricePalamud);
           //Console.WriteLine(priceMidi);
        }
    }
}

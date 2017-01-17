using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberBitkoni = double.Parse(Console.ReadLine());
            var numberUni = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
            double levFromUni = (numberUni*0.15)* 1.76;
            double levFromBitcoin = numberBitkoni * 1168;
            double bgnToEuro = (levFromBitcoin + levFromUni)/ 1.95;
            Console.WriteLine(bgnToEuro - (bgnToEuro* comission/100));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loads = int.Parse(Console.ReadLine());

            int loadsTones = 0;

            int loadsBus = 0;
            int loadsTruck = 0;
            int loadsTrain = 0;

            int priceBus = 0;
            int priceTruck = 0;
            int priceTrain = 0;

            for (int i = 1; i <= loads; i++)
            {
                loadsTones = int.Parse(Console.ReadLine());

                if (loadsTones <= 3)
                {
                    loadsBus += loadsTones;
                    priceBus = loadsBus * 200;
                }
                if (loadsTones >= 4 && loadsTones <= 11)
                {
                    loadsTruck += loadsTones;
                    priceTruck = loadsTruck * 175;
                }
                if (loadsTones >= 12)
                {
                    loadsTrain += loadsTones;
                    priceTrain = loadsTrain * 120;
                }
            }
            double priceAll = priceBus + priceTruck + priceTrain;
            double loadsAll = loadsBus + loadsTruck + loadsTrain;

            double percentBus = loadsBus / loadsAll * 100;
            double percentTruck = loadsTruck / loadsAll * 100;
            double percentTrain = loadsTrain / loadsAll * 100;
            double priceAverage = priceAll / loadsAll;

            Console.WriteLine("{0:f2}", priceAverage);
            Console.WriteLine("{0:f2}%", percentBus);
            Console.WriteLine("{0:f2}%", percentTruck);
            Console.WriteLine("{0:f2}%", percentTrain);
           // Console.WriteLine(priceTrain);
            //Console.WriteLine(loadsTrain);
        }
    }
}

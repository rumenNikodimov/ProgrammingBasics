using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var metersOfSide = double.Parse(Console.ReadLine());
            var shirinaPlochka = double.Parse(Console.ReadLine());
            var daljinaPlochka = double.Parse(Console.ReadLine());
            var shirinaPeika = double.Parse(Console.ReadLine());
            var daljinaPeika = double.Parse(Console.ReadLine());
            
            double area = (metersOfSide * metersOfSide) - (shirinaPeika * daljinaPeika);
            double areaPlochki = daljinaPlochka * shirinaPlochka;
            double needPlochki = area / areaPlochki;
            var time = needPlochki * 0.2;
            Console.WriteLine(needPlochki);
            Console.WriteLine(time);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var needHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var employesOvertime = int.Parse(Console.ReadLine());
            var allHuors = (days * 0.90)*8;
            var overTime = employesOvertime * 2*days;
            var allTime = allHuors + overTime;
            var diference = Math.Abs(needHours - allTime);

            if (needHours<=allTime)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(diference));

            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(diference));
            }
        }
    }
}

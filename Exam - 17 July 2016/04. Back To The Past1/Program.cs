using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past1
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            var needYear = int.Parse(Console.ReadLine());
            var spentMoney = 0.00;
            var spentMoney1 = 0.00;
            var spentMoney2 = 0.00;
            var count = 1;

            for (int i = 1800; i <= needYear; i++)
            {
                if (i % 2 == 0)
                {
                    spentMoney = 12000;
                    spentMoney1 += spentMoney;
                }
                else
                {
                    var curentYear = 18 + count;
                    spentMoney = 12000 + curentYear * 50;
                    spentMoney2 += spentMoney;
                    count += 2;

                    // Console.WriteLine(curentYear);
                }

                //Console.WriteLine(curentYear);
            }
            double allSpentMoney = spentMoney1 + spentMoney2;
            double difference = Math.Abs(heritage - allSpentMoney);

            if (heritage >= allSpentMoney)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", difference);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", difference);


            }
            //Console.WriteLine(diference);
            //Console.WriteLine(spentMoney2);
        }
    }
}

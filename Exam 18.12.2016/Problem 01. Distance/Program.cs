using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var firstTimeInMinutes = int.Parse(Console.ReadLine());
            var secondTimeInMinutes = int.Parse(Console.ReadLine());
            var thirdTimeInMinutes = int.Parse(Console.ReadLine());

            
                      
            double time1 = firstTimeInMinutes / 60.00;
            double time2 = secondTimeInMinutes / 60.00;
            double time3 = thirdTimeInMinutes / 60.00;
            var speed2 = speed * 1.10;

            var distance1 = time1 * speed;
            var distance2 = time2   * speed2;
            var distance3 = time3 * (speed2 * 0.95);
            var distance = distance3 + distance2 + distance1;

            Console.WriteLine("{0:f2}", distance);







            //razstoqnie = averageSpeed * thirdTimeInMinutes;
            //Console.WriteLine("{0}", razstoqnie);

        }
    }
}

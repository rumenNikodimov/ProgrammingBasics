using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var number = 0;


            var number3 = n % 10;
            number = n / 10;
            var number2 = number % 10;
            number = number / 10;
            var number1 = number % 10;

            for (int i = 0; i < number1 + number2; i++)
            {
                for (int j = 0; j < number1 + number3; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - number1;
                        Console.Write("{0} ", n);
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - number2;
                        Console.Write("{0} ", n);
                    }
                    else
                    {
                        n = n + number3;
                        Console.Write("{0} ", n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

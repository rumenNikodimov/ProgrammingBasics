using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                var magicNumber = int.Parse(Console.ReadLine());

                for (var number = 100000;
                    number <= 999999;
                    number++)
                {
                    var currentNumber = number;
                    var digitsProduct = 1;
                    while (currentNumber > 0)
                    {
                        var lastDigit =
                            currentNumber % 10;
                        digitsProduct *= lastDigit;
                        currentNumber /= 10;
                    }

                    if (digitsProduct == magicNumber)
                    {
                        Console.Write("{0} ",
                            number);
                    }
                }
            }
        }
    }
}
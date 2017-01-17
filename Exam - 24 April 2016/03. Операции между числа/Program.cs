using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var symbol = char.Parse(Console.ReadLine());
            var result = 0.00;

            if (symbol == '+')
            {
                result = n1 + n2;
                Console.WriteLine("{0} + {1} = {2} - {3}", n1, n2, result, (result % 2 == 0 ? "even" : "odd"));
            }
            if (symbol == '-')
            {
                result = n1 - n2;
                Console.WriteLine("{0} - {1} = {2} - {3}", n1, n2, result, (result % 2 == 0 ? "even" : "odd"));
            }
            if (symbol == '*')
            {
                result = n1 * n2;
                Console.WriteLine("{0} * {1} = {2} - {3}", n1, n2, result, (result % 2 == 0 ? "even" : "odd"));
            }
            if (symbol == '/')
            {
                result = n1 / n2;

                if (n2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1); 
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
                }

            }
            if (symbol == '%')
            {
                result = n1 % n2;

                if (n2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
                }
               
            }
        }
    }
}

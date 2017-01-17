using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(new string('.', 3 * number / 2) - 1 - i) + '/' + new string(' ', 2 * i) + "\\" + new string('.', 3 * number / 2) - 1 - i);
            }
        }
    }


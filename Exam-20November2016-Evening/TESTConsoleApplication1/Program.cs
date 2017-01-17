using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int line = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            for (int i = 1; i <= number; i++)
            {
                if (i == line)
                {
                    Console.WriteLine(new string('.', 13));
                    Console.WriteLine(new string('.', 3) + "+" + new string('-', 5) + "+" + new string('.', 3));
                    Console.WriteLine(new string('.', 3) + "|" + ".\\./." + "|" + new string('.', 3));
                    if (i < 10)
                    {
                        Console.WriteLine($"0{i}" + "." + "|" + ".." + symbol.ToUpper() + ".." + "|" + new string('.', 3));

                    }
                    else
                    {
                        Console.WriteLine($"{i}" + "." + "|" + ".." + symbol.ToUpper() + ".." + "|" + new string('.', 3));

                    }
                    Console.WriteLine(new string('.', 3) + "|" + "./.\\." + "|" + new string('.', 3));

                    Console.WriteLine(new string('.', 3) + "+" + new string('-', 5) + "+" + new string('.', 3));

                }
                else
                {
                    Console.WriteLine(new string('.', 13));
                    Console.WriteLine(new string('.', 3) + "+" + new string('-', 5) + "+" + new string('.', 3));
                    Console.WriteLine(new string('.', 3) + "|" + new string('.', 5) + "|" + new string('.', 3));
                    if (i < 10)
                    {
                        Console.WriteLine($"0{i}" + "." + "|" + new string('.', 5) + "|" + new string('.', 3));

                    }
                    else
                    {
                        Console.WriteLine($"{i}" + "." + "|" + new string('.', 5) + "|" + new string('.', 3));

                    }
                    Console.WriteLine(new string('.', 3) + "|" + new string('.', 5) + "|" + new string('.', 3));
                    Console.WriteLine(new string('.', 3) + "+" + new string('-', 5) + "+" + new string('.', 3));

                }
            }
            Console.WriteLine(new string('.', 13));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = start; i <= end; i++)


                for (int j = start; j <= end; j++)
                {

                    if (counter == max)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>", i, j);
                    counter++;
                }        

        }
    }
}

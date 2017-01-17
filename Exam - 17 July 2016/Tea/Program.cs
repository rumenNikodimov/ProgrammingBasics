using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;


namespace _08.Poredica
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int biggestLen = 1;
                for (int index = 0; index < arr.Length - 1; index++)
                {
                    int currentLen = 1;
                    int currentElement = arr[index];
                    for (int secondIndex = index + 1; secondIndex < arr.Length; secondIndex++)
                    {
                        int nextEl = arr[secondIndex];
                        if (currentElement < nextEl)
                        {
                            currentLen++;
                            currentElement = nextEl;
                        }
                        else
                        {
                            break;
                        }

                        if (currentLen > biggestLen)
                        {
                            biggestLen = currentLen;
                        }
                    }
                }

                Console.WriteLine(biggestLen);
            }
        }
    }
}
    }
}

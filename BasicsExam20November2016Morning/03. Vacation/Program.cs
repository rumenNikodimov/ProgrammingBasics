using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfAdults = int.Parse(Console.ReadLine());
            var numberOfStudents = int.Parse(Console.ReadLine());
            var numberOfNights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var priceTransport = 0.0;
            var allExpenses = 0.0;
            var allPassengers = numberOfAdults + numberOfStudents;
            var allNights = numberOfNights * 82.99;

            if (transport == "train" && allPassengers >= 50)
            {
                priceTransport = (numberOfAdults * 24.99 + numberOfStudents * 14.99);
                allExpenses = (priceTransport + allNights) * 1.1;
            }
            if (transport == "train" && allPassengers<50)
            {
                priceTransport = (numberOfAdults * 24.99 + numberOfStudents * 14.99) * 2;
                allExpenses = (priceTransport + allNights) * 1.1;
            }     
            if (transport == "bus")
            {
                priceTransport = (numberOfAdults * 32.50 + numberOfStudents * 28.50) * 2;
                allExpenses = (priceTransport + allNights) * 1.1;
            }
            if (transport == "boat")
            {
                priceTransport = (numberOfAdults * 42.99 + numberOfStudents * 39.99) * 2;
                allExpenses = (priceTransport + allNights) * 1.1;
            }
            if (transport == "airplane")
            {
                priceTransport = (numberOfAdults * 70 + numberOfStudents * 50) * 2;
                allExpenses = (priceTransport + allNights)*1.1;
            }
            Console.WriteLine("{0:f2}", allExpenses);
        }
    }
}

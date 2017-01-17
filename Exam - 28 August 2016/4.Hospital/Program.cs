using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());

            var traetedPatients = 0;

            var untreatedPatients = 0;
            var allPatients = 0;
            var doctors = 7;
            var untreatedPatients1 = 0;
            

            for (int i = 1; i <= period; i++)
            {
                var numberOfPatientForDay = int.Parse(Console.ReadLine());

                if (untreatedPatients1 > traetedPatients && i % 3 == 0)
                {
                    doctors += 1;
                }

                allPatients += numberOfPatientForDay;
                untreatedPatients = numberOfPatientForDay - doctors;
                untreatedPatients1 += untreatedPatients;

                traetedPatients = allPatients - untreatedPatients1;
            }


            Console.WriteLine("Treated patients: {0}.", allPatients - untreatedPatients1);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients1);
        }
    }
}


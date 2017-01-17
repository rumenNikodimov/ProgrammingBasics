using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersOfDays = int.Parse(Console.ReadLine());
            var treatedPatients = 0;
            var doctors = 7;
            var untretedPatients = 0;

            for (int i = 1; i <= numbersOfDays; i++)
            {
                var numbersOfPatients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && treatedPatients< untretedPatients)         
                {
                    doctors++;
                }

                var numberOftretedPatientsPerDay = Math.Min(doctors, numbersOfPatients);
                var untreatedPatientsPerDay = numbersOfPatients - numberOftretedPatientsPerDay;
                treatedPatients = treatedPatients + numberOftretedPatientsPerDay;
                untretedPatients = untretedPatients + untreatedPatientsPerDay;
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untretedPatients);

        }
    }
}

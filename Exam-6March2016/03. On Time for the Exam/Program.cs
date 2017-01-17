using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());

            int hourOfArived = int.Parse(Console.ReadLine());
            int minutesOfArived = int.Parse(Console.ReadLine());

            var timeExam = Math.Abs(hourOfExam - hourOfArived);

            var hourOfExamInMinutes = hourOfExam * 60 + minutesOfExam;
            var hourOfArivedInMinutes = hourOfArived * 60 + minutesOfArived;
            var difference = Math.Abs(hourOfArivedInMinutes - hourOfExamInMinutes);

            if (hourOfArivedInMinutes == hourOfExamInMinutes)
            {
                Console.WriteLine("On Time");
                return;
            }
            if ((hourOfExamInMinutes - hourOfArivedInMinutes) <= 30)
            {
                Console.WriteLine("On Time");
                Console.WriteLine("{0} minutes before the start", difference);
            }
            if ((hourOfArivedInMinutes - hourOfExamInMinutes) > 30)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", difference);
            }
            if ((hourOfExamInMinutes - hourOfArivedInMinutes) > 30)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", difference);
            }
            //Console.WriteLine(hourOfExamInMinutes);
        }
    }
}

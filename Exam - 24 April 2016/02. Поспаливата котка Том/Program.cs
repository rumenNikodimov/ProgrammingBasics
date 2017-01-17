using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            var restDays = int.Parse(Console.ReadLine());
            var workDays = 365 - restDays;
            var playall = (restDays * 127) + (workDays*63);
            var hours = playall/60;
            var minutes = playall % 60;
            var def = Math.Abs(30000 - playall);
            var defHours = def / 60;
            var defMinutes = def % 60;

            if (playall<=30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", defHours, defMinutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", defHours, defMinutes);
            }
           // Console.WriteLine(def);
           // Console.WriteLine(" {0}:{1}", defHours, defMinutes);


            //Tom will run away
//3 hours and 47 minutes more for play

            //
            //95 hours and 25 minutes less for play

        }
    }
}

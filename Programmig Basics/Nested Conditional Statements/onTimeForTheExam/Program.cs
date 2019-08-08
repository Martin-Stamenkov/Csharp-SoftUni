using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int comeHour = int.Parse(Console.ReadLine());
            int comeMinutes = int.Parse(Console.ReadLine());

            int mindiff = 0;
            int hourdiff = 0;
            if (comeHour > hourExam || comeMinutes > minutesExam)
            {

                Console.WriteLine("Late");
                hourdiff = comeHour - hourExam;
                mindiff = comeMinutes - minutesExam;
                Console.WriteLine($"{hourdiff}:{mindiff} minutes after the start” ");
                if (comeMinutes > minutesExam)
                {
                    mindiff = comeMinutes - minutesExam;
                    Console.WriteLine($"{mindiff} minutes after the start");
                }
               
              
            }
            else if (comeHour == hourExam && comeMinutes == minutesExam)
            {
                if (comeMinutes <= 30)
                {
                    Console.WriteLine("On time");
                }
                Console.WriteLine("On time");

            }
            else if (minutesExam - comeMinutes == 30)
            {

                mindiff = comeMinutes - minutesExam;
                Console.WriteLine("Early");
                Console.WriteLine($"{mindiff} minutes before the start");
                if (hourExam-comeHour > 1)
                {
                    hourdiff = hourExam - comeHour;
                    mindiff = minutesExam - comeMinutes;
                    Console.WriteLine($"{hourdiff}:{mindiff} hours before the start”");
                }
            }

        }
    }
}

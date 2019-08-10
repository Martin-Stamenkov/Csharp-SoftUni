using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInMetters = double.Parse(Console.ReadLine());
            double timeInSecForOneMetter = double.Parse(Console.ReadLine());
            double timeInSec = distanceInMetters * timeInSecForOneMetter;
            double timeSlower = Math.Floor(distanceInMetters / 50) * 30;
            double totalTime = timeInSec + timeSlower;
            if (totalTime < recordInSec)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime-recordInSec:f2} seconds slower.");
            }



        }
    }
}

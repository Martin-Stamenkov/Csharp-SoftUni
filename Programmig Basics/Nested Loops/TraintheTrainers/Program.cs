using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraintheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJudges = int.Parse(Console.ReadLine());
            double gradeSum = 0;
            double totalAvarage = 0;
            double avarageForOnePresent = 0;
            string presentation = Console.ReadLine();
            int gradeCount = 0;
            double gradeForAvarage = 0;

            while (presentation != "Finish")
            {
                for (int i = 0; i < numJudges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                    gradeForAvarage += grade;
                    gradeCount++;
                }
                avarageForOnePresent = gradeSum / numJudges;
                Console.WriteLine($"{presentation} - {avarageForOnePresent:f2}.");
                gradeSum = 0;
                presentation = Console.ReadLine();

            }
            totalAvarage = gradeForAvarage / gradeCount;
            Console.WriteLine($"Student's final assessment is {totalAvarage:f2}.");
        } 
    }
}

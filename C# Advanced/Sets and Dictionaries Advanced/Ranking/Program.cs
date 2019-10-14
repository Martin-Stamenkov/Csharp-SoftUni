using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> ranking = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> validContAndPass = new Dictionary<string, string>();
            Dictionary<string, int> finalResult = new Dictionary<string, int>();

            string contestAndPassword = Console.ReadLine();

            while (contestAndPassword !="end of contests")
            {
                string []tokens = contestAndPassword.Split(":");
                string contest = tokens[0];
                string password = tokens[1];

                if (!validContAndPass.ContainsKey(contest))
                {
                    validContAndPass[contest] = password;
                    
                }

                contestAndPassword = Console.ReadLine();
            }

            string submissions = Console.ReadLine();

            while (submissions != "end of submissions")
            {
                string[] currentSubmission = submissions.Split("=>");
                string contest = currentSubmission[0];
                string password = currentSubmission[1];
                string name = currentSubmission[2];
                int points = int.Parse(currentSubmission[3]);

                if (validContAndPass.ContainsKey(contest) && validContAndPass.ContainsValue(password))
                {
                    if (!ranking.ContainsKey(name))
                    {
                        ranking[name] = new Dictionary<string, int>();
                        ranking[name][contest] = points;
                        finalResult[name] = 0;
                        finalResult[name] += points;
                    }
                    else
                    {
                        if (!ranking[name].ContainsKey(contest))
                        {
                            ranking[name][contest] = points;
                            finalResult[name] += points;
                           
                        }
                        else
                        {
                            if (ranking[name][contest]<points)
                            {
                                ranking[name][contest] = points;
                                finalResult[name] += points;
                            }
                        }
                    }
                }

                submissions = Console.ReadLine();
            }
            string studentWhitMostPoints = "";
            int max = int.MinValue;

            foreach (var kvp in finalResult)
            {
                int maxPoints = kvp.Value;
                if (maxPoints>max)
                {
                    max = maxPoints;
                    studentWhitMostPoints = kvp.Key;
                   
                }
            }
            Console.WriteLine($"Best candidate is {studentWhitMostPoints} with total {max} points.");
            Console.WriteLine("Ranking: ");

            foreach (var name in ranking.OrderBy(x=>x.Key))
            {
                Console.WriteLine(name.Key);
                foreach (var contest in name.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }

            }
        }
    }
}

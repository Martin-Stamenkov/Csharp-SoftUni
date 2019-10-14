using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split(" ");
                string name = inputLine[0];
                double grade = double.Parse(inputLine[1]);

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                }
                 dict[name].Add(grade);
            }
            foreach (var kvp in dict)
            {
                string name = kvp.Key;

                Console.WriteLine($"{name} -> {string.Join(" ", kvp.Value.Select(x=>x.ToString("f2")))} (avg: {kvp.Value.Average():f2})");
               
            }
        }
    }
}

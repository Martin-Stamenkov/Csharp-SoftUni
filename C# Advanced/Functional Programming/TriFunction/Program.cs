using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = int.Parse(Console.ReadLine());

            var inpputNames = Console.ReadLine()
                .Split(" ");

            Func<string, int, bool> IsEqualOrLarger = (name, criteria) => name.Sum(x => x) >= criteria;

            Func<string[], Func<string, int, bool>, string> myFunc = (names, isLarger) 
                => names.FirstOrDefault(name => isLarger(name, target));

            string result = myFunc(inpputNames,IsEqualOrLarger);

            Console.WriteLine(result);
          
        }
    }
}

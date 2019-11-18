using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var level = int.Parse(Console.ReadLine());

            DarkKnight hero = new DarkKnight(name, level);

            Console.WriteLine(hero);

        }
    }
}
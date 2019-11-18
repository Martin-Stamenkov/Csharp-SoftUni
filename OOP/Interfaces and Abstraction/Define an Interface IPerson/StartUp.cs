using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var age = int.Parse(Console.ReadLine());

            var id = Console.ReadLine();    

            var birthdate = Console.ReadLine();

            IIdentifiable iIdentifiable = new Citizen(name,age,id,birthdate);

            IBirthable iBirthable = new Citizen(name,age,id,birthdate);

            Console.WriteLine(iIdentifiable.Id);
            Console.WriteLine(iBirthable.Birthdate);
        }
    }
}

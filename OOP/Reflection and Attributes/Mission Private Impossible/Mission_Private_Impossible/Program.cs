using System;

namespace Mission_Private_Impossible
{
    public class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            var result = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(result);

        }
    }
}

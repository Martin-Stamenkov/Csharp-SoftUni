using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();
            var result = spy.StealFieldInfo("Hacker", "username", "password");
            Console.WriteLine(result);
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod);
        foreach (var method in methods)
        {
            if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
            {
                var atrributes = method.GetCustomAttributes(false);

                foreach (AuthorAttribute atrribute in atrributes)
                {
                    Console.WriteLine($"{method.Name} is written by {atrribute.Name}");
                }

            }
        }
    }
}


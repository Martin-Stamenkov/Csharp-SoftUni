using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarToCel
{
    class Program
    {
        static void Main(string[] args)
        {
      
            double Cel = double.Parse(Console.ReadLine());
          
            double result = (Cel * 1.8) + 32;
            Console.WriteLine("{0:F2}", result);

        }
    }
}

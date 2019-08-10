using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBitcoin = int.Parse(Console.ReadLine());
            double numChinaUan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            double dollar = 1.76;
            double euro = 1.95;
            double bitcoinValue = numBitcoin * 1168;
            double uanValue = 0.15;

            double dollarToLeva = dollar * uanValue*numChinaUan;
            double total = (bitcoinValue + dollarToLeva) / euro;
            double totalAfterComision = total * (comision/100);
            double totalAfterAll = total - totalAfterComision;

            Console.WriteLine($"{totalAfterAll:f2}");

        }
    }
}

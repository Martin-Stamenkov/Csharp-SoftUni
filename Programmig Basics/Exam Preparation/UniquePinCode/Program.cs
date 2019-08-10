using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxFirstDigit = int.Parse(Console.ReadLine());
            int maxSecondDigit = int.Parse(Console.ReadLine());
            int maxThirdDigit = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <= maxFirstDigit; firstDigit++)
            {
                for (int secondDigit = 2; secondDigit <= maxSecondDigit; secondDigit++)
                {
                    for (int thirdDigit = 1; thirdDigit <= maxThirdDigit; thirdDigit++)
                    {
                        if (firstDigit%2==0 && thirdDigit%2==0)
                        {
                            if (secondDigit==2 || secondDigit ==3 || secondDigit==5 ||secondDigit==7 )
                            {
                                Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit}");
                            }
                        }
                    }
                }
            }
        }
    }
}

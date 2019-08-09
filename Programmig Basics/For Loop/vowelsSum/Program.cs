using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sumChar = 0;
          

            for (int i = 0; i < text.Length; i++)
                
            {
                char letter = text[i];

                switch (letter)
                {
                    case 'a':
                        sumChar += 1;
                        break;
                    case 'e':
                        sumChar += 2;
                        break;
                    case 'i':
                        sumChar += 3;
                        break;
                    case 'o':
                        sumChar += 4;
                        break;
                    case 'u':
                        sumChar += 5;
                        break;
                }


            }
            Console.WriteLine(sumChar);

        }
    }
}

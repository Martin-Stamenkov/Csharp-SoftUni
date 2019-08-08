using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята
            лицето й. Фигурите са четири вида: квадрат (square), правоъгълник (rectangle), кръг (circle) и триъгълник
            (triangle). На първия ред на входа се чете вида на фигурата (square, rectangle, circle или triangle). Ако
            фигурата е квадрат, на следващия ред се чете едно число - дължина на страната му. Ако фигурата е
            правоъгълник, на следващите два реда четат две числа - дължините на страните му. Ако фигурата е кръг, на
            следващия ред чете едно число - радиусът на кръга. Ако фигурата е триъгълник, на следващите два реда
            четат две числа - дължината на страната му и дължината на височината към нея. Резултатът да се закръгли до
            3 цифри след десетичната точка.*/
            string figure = Console.ReadLine();
            double area = double.Parse(Console.ReadLine());

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                

            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;

            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;

            }
            else if (figure == "treangle")
            {
                double h = double.Parse(Console.ReadLine());
                double w = double.Parse(Console.ReadLine());
                area = 0.5 * h * w;

            }
            Console.WriteLine("{0:f3}",area);

        }
    }
}

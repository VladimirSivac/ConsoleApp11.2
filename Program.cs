using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = Input("Введите радиус круга: ");
            
            double square = Square(radius);
            double length = Length(radius);
            
            Output("Радиус: ", radius);
            Output("Площадь круга: ", square);
            Output("Длина окружности: ", length);

            Console.ReadKey();
        }

        static double Input(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Output(string message, double result)
        {
            Console.WriteLine(message + result);
        }
        
        static double Square(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
        static double Length(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
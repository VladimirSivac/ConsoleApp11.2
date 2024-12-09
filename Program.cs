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
            double a1 = Input("a1 = ");
            double b1 = Input("b1 = ");
            double c1 = Input("c1 = ");
            
            double a2 = Input("a2 = ");
            double b2 = Input("b2 = ");
            double c2 = Input("c2 = ");
            
            double perimetr1 = Perimetr(a1, b1, c1);
            double perimetr2 = Perimetr(a2, b2, c2);
            
            double square1 = Square(a1, b1, c1);
            double square2 = Square(a2, b2, c2);
            
            Console.WriteLine($"Сумма периметров: {perimetr1 + perimetr2}");
            Console.WriteLine($"Сумма площадей: {square1 + square2}");

            Console.ReadKey();
        }

        static double Input(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }
        
        static double Perimetr(double a, double b, double c)
        {
            return a + b + c;
        }
        
        static double Square(double a, double b, double c)
        {
            double poluPerimeter = (a + b + c) / 2;
            return Math.Sqrt(poluPerimeter * (poluPerimeter - a) * (poluPerimeter - b) * (poluPerimeter - c));
        }
    }
}
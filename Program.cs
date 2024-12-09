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
            double x1 = Input("x1 = ");
            double y1 = Input("y1 = ");
            double x2 = Input("x2 = ");
            double y2 = Input("y2 = ");
            double x3 = Input("x3 = ");
            double y3 = Input("y3 = ");
            double x4 = Input("x4 = ");
            double y4 = Input("y4 = ");
            double x5 = Input("x5 = ");
            double y5 = Input("y5 = ");
            
            double square1 = Square(x1, y1, x2, y2, x3, y3);
            double square2 = Square(x1, y1, x3, y3, x4, y4);
            double square3 = Square(x1, y1, x4, y4, x5, y5);
            
            double square = square1 + square2 + square3;
            
            Output("Площадь пятиугольника: ", square);

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
        
        static double Otrezok(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        
        static double Square(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double side1 = Otrezok(x1, y1, x2, y2);
            double side2 = Otrezok(x2, y2, x3, y3);
            double side3 = Otrezok(x3, y3, x1, y1);
            
            double semiPerimeter = (side1 + side2 + side3) / 2;
            
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }
    }
}
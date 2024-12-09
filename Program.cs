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
            
            double side1 = Otrezok(x1, y1, x2, y2);
            double side2 = Otrezok(x2, y2, x3, y3);
            double side3 = Otrezok(x3, y3, x1, y1);
            
            double perimetr = side1 + side2 + side3;
            
            Output("Периметр треугольника: ", perimetr);

            Console.ReadKey();
        }

        static double Input(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }
        
        static double Otrezok(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        
        static void Output(string message, double result)
        {
            Console.WriteLine(message + result);
        }
    }
}
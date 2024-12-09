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
            double x1 = Input("x1: ");
            double y1 = Input("y1: ");
            double x2 = Input("x2: ");
            double y2 = Input("y2: ");
            double x3 = Input("x3: ");
            double y3 = Input("y3: ");
            
            double a = Side(x1, y1, x2, y2);
            double b = Side(x2, y2, x3, y3);
            double c = Side(x3, y3, x1, y1);
            
            string vid = Vid(a, b, c);
            
            Output(vid, a, b, c);
        }
        
        static double Input(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }
        
        static double Side(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        
        static string Vid(double a, double b, double c)
        {
            
            if (a == b || b == c || a == c)
            {
                if (a == b && b == c)
                {
                    return "Равносторонний";
                }
                else
                {
                    return "Равнобедренный";
                }
            }
            
            if ((a * a + b * b == c * c) || (b * b + c * c == a * a) || (a * a + c * c == b * b))
            {
                return "Прямоугольный";
            }
            
            return "Обычный";
        }
        
        static void Output(string vid, double a, double b, double c)
        {
            Console.WriteLine($"Длины сторон треугольника: a = {a:F2}, b = {b:F2}, c = {c:F2}");
            Console.WriteLine($"Вид треугольника: {vid}");
        }
    }
}
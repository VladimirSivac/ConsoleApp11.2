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
            int a = Input("Введите число a: ");
            int b = Input("Введите число b: ");
            int c = Input("Введите число c: ");
            int d = Input("Введите число d: ");
            int e = Input("Введите число e: ");
            int f = Input("Введите число f: ");
            int g = Input("Введите число g: ");
            int h = Input("Введите число h: ");
            
            int max1 = Max(a, b);
            int max2 = Max(c, d);
            int max3 = Max(e, f);
            int max4 = Max(g, h);

            int max_1_4 = Max(max1, max2);
            int max_4_8 = Max(max3, max4);

            int max = Max(max_1_4, max_4_8);
            
            Console.WriteLine($"Максимальное число: {max}");
        }
        
        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        static int Max(int x, int y)
        {
            return (x > y) ? x : y;
        }
    }
}
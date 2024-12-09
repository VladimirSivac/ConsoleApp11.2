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
            int a = Input("a = ");
            int b = Input("b = ");
            int c = Input("c = ");
            int d = Input("d = ");
            Output("Вывод до перестановки: ", a, b, c, d);
            SwapValues(ref a, ref b);
            SwapValues(ref c, ref d);
            Output("Вывод после перестановки: ", a, b, c, d);
            Console.ReadKey();
        }
        
        public static void SwapValues(ref int a, ref int b)
        {
            int p = a;
            a = b;
            b = p;
        }
        
        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        static void Output(string message, int result1, int result2, int result3, int result4)
        {
            Console.WriteLine(message + result1 + " " + result2 + " " + result3 + " " + result4);
        }
    }
}
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
            string a = Input("a = ");
            string b = Input("b = ");
            Output("Вывод до перестановки: ", a, b);
            SwapStrings(ref a, ref b);
            Output("Вывод после перестановки: ", a, b);
            Console.ReadKey();
        }
        
        public static void SwapStrings(ref string a, ref string b)
        {
            string p = a;
            a = b;
            b = p;
        }
        
        static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
        static void Output(string message, string result1, string result2)
        {
            Console.WriteLine(message + result1 + " " + result2);
        }
    }
}
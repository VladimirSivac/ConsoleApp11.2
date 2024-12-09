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
            Sort(ref a, ref b, ref c);
            Output("Числа в порядке возрастания: ", a, b, c);
            Console.ReadKey();
        }
        
        static void Sort(ref int a, ref int b, ref int c)
        {
            if (a > b)
            {
                int p = a;
                a = b;
                b = p;
            }
            if (a > c)
            {
                int p = a;
                a = c;
                c = p;
            }
            if (b > c)
            {
                int p = b;
                b = c;
                c = p;
            }
        }
        
        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        static void Output(string message, int result1, int result2, int result3)
        {
            Console.WriteLine(message + result1 + " " + result2 + " " + result3);
        }
    }
}
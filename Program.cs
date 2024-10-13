using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum operations
        {
            Sum,
            Dif,
            Multip,
            Div,
            Pow,
            Sqrt
        }

        static double DoOperation(operations op, int a, int b)
        {
            if (op == operations.Sum)
            {
                return a + b;
            }
            else if (op == operations.Dif)
            {
                return a - b;
            }
            else if (op == operations.Multip)
            {
                return a * b;
            }
            else if (op == operations.Div)
            {
                return a / b;
            }
            else if (op == operations.Pow)
            {
                return Math.Pow(a, b);
            }
            else if (op == operations.Sqrt)
            {
                return Math.Sqrt(a);
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите 2 числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            operations op = operations.Sqrt;
            Console.WriteLine(DoOperation(op, a, b));




        }
    }
}

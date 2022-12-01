using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum3_Task2
{
    internal class Program
    {
        static double f(double x)
        {
            double y;
            if (Math.Abs(x) <= 0.1) y = Math.Pow(x, 3) - 0.1;
            else if (Math.Abs(x) > 0.1 && Math.Abs(x) <= 0.2) y = 0.2 * x - 0.1;
            else y = Math.Pow(x, 3) + 0.1;
            return y;

        }

        static void Main(string[] args)
        {
            double a, b, h;

            while (true)
            {
                try
                {
                    Console.Write("Введите значение a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение шага h: ");
                    h = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Вы ввели некорректные значения!");
                }
            }

            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine($"f({i}) = {f(i)}");
            }
               

        }
    }
}

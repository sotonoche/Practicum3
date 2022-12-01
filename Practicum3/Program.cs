using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum3
{
    internal class Program
    {
        static double f(double x)
        {
            return Math.Cos(2 * x) + Math.Sin(x - 3);
        }
        
        static void Main(string[] args)
        {
            double a, b;

            while (true)
            {
                try
                {
                    Console.Write("Введите значение точки a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение точки b: ");
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
            }

            if (f(a) < f(b)) Console.WriteLine($"В точке a, равной {Math.Round(f(a), 2)}, функция принимает наименьшее значение.");
            else Console.WriteLine($"В точке b, равной {Math.Round(f(b), 2)}, функция принимает наименьшее значение.");
        }
    }
}
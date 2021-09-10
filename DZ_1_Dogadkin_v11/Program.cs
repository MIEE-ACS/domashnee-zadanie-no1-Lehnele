using System;

namespace pr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x = ");
            int x = int.Parse(Console.ReadLine())
            Console.Write($"3*x^6 - 6*x^2 - 7 = {3 * Math.Pow(x,6) - 6 * Math.Pow(x,2)-7}");
        }
    }
}

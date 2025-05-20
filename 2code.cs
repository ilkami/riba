using System;

namespace _2coderun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool isTriangle = a + b > c && a + c > b && b + c > a;
            Console.WriteLine(isTriangle ? "Да" : "Нет");
        }
    }
}
using System;

namespace _5coderun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coefficients = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = coefficients[0], b = coefficients[1], c = coefficients[2];

            double discrim = b * b - 4 * a * c;

            if (discrim == 0)
            {
                double x = -b / (2.0 * a);
                Console.WriteLine(x);
            }
            else
            {
                double sqrtD = Math.Sqrt(discrim);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                Console.WriteLine($"{x1} {x2}");
            }
        }
    }
}
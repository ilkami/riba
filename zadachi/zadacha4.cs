using System;

namespace FactorialCalculator
{
    internal class Program
    {
        static void CalculateFactorial(int number)
        {
            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Факториал {number}! = {factorial}");
        }

        static void Main()
        {
            Console.Write("Введите целое число для вычисления факториала: ");
            int inputNumber = int.Parse(Console.ReadLine());
            
            CalculateFactorial(inputNumber);
        }
    }
}
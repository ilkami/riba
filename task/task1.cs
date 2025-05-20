using System;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два целых числа:");
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nРезультаты операций:");
            Console.WriteLine($"Сумма: {num1 + num2}");
            Console.WriteLine($"Разность: {num1 - num2}");
            
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно");
            }
            else
            {
                Console.WriteLine($"Целочисленное деление: {num1 / num2}");
                Console.WriteLine($"Остаток от деления: {num1 % num2}");
            }
            
            Console.WriteLine($"Произведение: {num1 * num2}");
        }
    }
}
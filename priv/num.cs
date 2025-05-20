using System;

namespace MultiplicationApp
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа умножения чисел [0-10]");
            Console.WriteLine("--------------------------------");
            
            while (true)
            {
                Console.Write("Введите первый множитель (0-10): ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Введите второй множитель (0-10): ");
                int b = int.Parse(Console.ReadLine());

                if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
                {
                    Console.WriteLine($"\n{a} × {b} = {a * b}");
                    break;
                }
                else
                {
                    Console.WriteLine("\nНекорректный ввод! Допустимы только целые числа от 0 до 10.\n");
                }
            }
            
            Console.WriteLine("\nРасчёт завершён.");
        }
    }
}
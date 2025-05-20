using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ТАБЛИЦА УМНОЖЕНИЯ 10x10");
            Console.WriteLine("-----------------------");
            
            for (int multiplier = 1; multiplier <= 10; multiplier++)
            {
                for (int multiplicand = 1; multiplicand <= 10; multiplicand++)
                {
                    Console.Write($"{multiplier * multiplicand,4}");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\nГотово!");
        }
    }
}
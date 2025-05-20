using System;

namespace ArraySumCalculator
{
    internal class Program
    {
        static int CalculateSum(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 3, 5, 6, 7, 8, 9, 10 };
            
            Console.WriteLine($"Сумма элементов массива: {CalculateSum(numbers)}");
        }
    }
}
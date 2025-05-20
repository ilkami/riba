using System;

namespace MaxNumberFinder
{
    internal class Program
    {
        static int FindMaxNumber(int[] numbers)
        {
            int max = numbers[0]; 
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 3, 5, 6, 7, 8, 9, 10 };
            
            Console.WriteLine($"Максимальное число в массиве: {FindMaxNumber(numbers)}");
        }
    }
}
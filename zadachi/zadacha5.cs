using System;
using System.Collections.Generic;

namespace UniqueNumbers
{
    internal class Program
    {
        static void RemoveDuplicates(int[] numbers)
        {
            List<int> uniqueNumbers = new List<int>();
            
            foreach (int num in numbers)
            {
                if (!uniqueNumbers.Contains(num))
                {
                    uniqueNumbers.Add(num);
                }
            }

            Console.WriteLine("Уникальные числа:");
            Console.WriteLine(string.Join(" ", uniqueNumbers));
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 5, 6, 7, 8, 7, 9, 10 };
            
            RemoveDuplicates(numbers);
        }
    }
}
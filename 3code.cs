using System;

namespace _3coderun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            int count = 0;

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
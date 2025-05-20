using System;

namespace _4coderun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[Math.Max(n + 1, 3)]; 
            
            fib[1] = fib[2] = 1;  

            for (int i = 3; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += fib[i];
            }

            Console.WriteLine(sum);
        }
    }
}
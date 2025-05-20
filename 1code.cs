using System;

namespace _1coderun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] xy = Console.ReadLine().Split(' ');
            byte x = byte.Parse(xy[0]);
            byte y = byte.Parse(xy[1]);
            Console.WriteLine(x + y);
        }
    }
}
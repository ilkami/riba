using System;

namespace ThreeDArrayPrinter
{
    internal class Program
    {
        static void Main()
        {
            int[,,] array3D = {
                { { 1, 2 }, { 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
            };

            Console.WriteLine("Элементы трехмерного массива:");
            
            for (int layer = 0; layer < array3D.GetLength(0); layer++)
            {
                Console.WriteLine($"Слой {layer + 1}:");
                
                for (int row = 0; row < array3D.GetLength(1); row++)
                {
                    for (int col = 0; col < array3D.GetLength(2); col++)
                    {
                        Console.Write($"{array3D[layer, row, col],3}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
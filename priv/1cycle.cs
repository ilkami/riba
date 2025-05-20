using System;

namespace calculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите сумму вклада: ");
            decimal deposit = decimal.Parse(Console.ReadLine());

            Console.Write("Введите срок в месяцах: ");
            int months = int.Parse(Console.ReadLine());
            
            const decimal rate = 0.07m;
            
            for (int i = 0; i < months; i++)
            {
                deposit += deposit * rate;
            }

            Console.WriteLine($"Итоговая сумма: {deposit:F2}");
        }
    }
}
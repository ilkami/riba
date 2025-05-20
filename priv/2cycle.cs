using System;

namespace calculator2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Первоначальная сумма вклада: ");
            decimal deposit = decimal.Parse(Console.ReadLine());

            Console.Write("Срок в месяцах: ");
            int months = int.Parse(Console.ReadLine());
            
            const decimal monthlyRate = 0.07m;
            int currentMonth = 0;
            
            while (currentMonth < months)
            {
                deposit += deposit * monthlyRate;
                currentMonth++;
            }

            Console.WriteLine($"Итоговый вклад: {deposit:F2}");
        }
    }
}
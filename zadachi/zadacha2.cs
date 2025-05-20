using System;
using System.Linq;

namespace PalindromeChecker
{
    internal class Program
    {
        static void CheckPalindrome(string word)
        {
            string cleanedWord = word.ToLower();
            bool isPal = cleanedWord.SequenceEqual(cleanedWord.Reverse());
            
            string result = isPal ? "палиндромом" : "не палиндромом";
            Console.WriteLine($"Слово '{word}' {result}");
        }

        static void Main()
        {
            Console.Write("Проверка палиндрома. Введите слово: ");
            string input = Console.ReadLine();
            CheckPalindrome(input);
        }
    }
}
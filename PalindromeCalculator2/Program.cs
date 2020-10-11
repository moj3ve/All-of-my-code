using System;

namespace PalindromeCalculator2
{
    class Program
    {
        static bool CheckAnagram(char[] firstWord, char[] comparedWord) {
            Array.Sort(firstWord);
            Array.Sort(comparedWord);
            return (string.Join("", firstWord).Equals(string.Join("", comparedWord)));
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your first word: ");
            char[] firstWord = Console.ReadLine().ToCharArray();
            Console.Write("Enter your second word: ");
            char[] comparedWord = Console.ReadLine().ToCharArray();
            Console.WriteLine(CheckAnagram(firstWord, comparedWord));
            Console.ReadKey(true);
        }
    }
}

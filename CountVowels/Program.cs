using System;
using System.Linq;

namespace CountVowels
{
    class Program
    {
        static (int, int) CountVowels(string inputString)
        {
            int amountOfVowels = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char ch in inputString)
            {
                if (vowels.Contains(ch))
                    amountOfVowels++;
            }
            return (amountOfVowels, inputString.Length - amountOfVowels);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine(CountVowels(inputString));
        }
    }
}

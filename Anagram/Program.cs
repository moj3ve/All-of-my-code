using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your first word: ");
            char[] firstWord = Console.ReadLine().ToCharArray();
            Console.WriteLine("Input your second word: ");
            List<char> secondWord = Console.ReadLine().ToList();
            int secondWordLength = secondWord.Count;
            List<int> compiledComparedChars = new List<int>();
            foreach (char comparedChar in firstWord)
            {
                if (secondWord.Contains(comparedChar))
                {
                    secondWord.Remove(comparedChar);
                    compiledComparedChars.Add(comparedChar);
                }
            }
            if (compiledComparedChars.Count == firstWord.Length && compiledComparedChars.Count == secondWordLength)
            {
                Console.WriteLine("Your words are anagrams!");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Your words aren't anagrams!");
                Console.ReadKey(true);
            }
        }
    }
}

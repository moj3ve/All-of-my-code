using System;
using System.Collections.Generic;
using System.Linq;


namespace PalindromeCalculator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first word: ");
            string comparedWordString = Console.ReadLine().ToLower();
            string comparedWordBackwardsString = null;

            List<char> comparedWordBackwards = comparedWordString.ToList<char>();
            comparedWordBackwards.Reverse();

            foreach(char ch in comparedWordBackwards)
                comparedWordBackwardsString += ch;

            if(comparedWordBackwardsString == comparedWordString) {
                Console.WriteLine("Your word is a palindrome! ");
            }
            else {
                Console.WriteLine("Your word is not a palindrome! ");
            }
        }
    }
}

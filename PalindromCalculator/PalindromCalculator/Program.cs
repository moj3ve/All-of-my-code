using System;
using System.Text;

namespace PalindromCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter your word");
            string word = Console.ReadLine();
            StringBuilder wordStringBuilder = new StringBuilder(word);
            wordStringBuilder = wordStringBuilder.Replace(" ", "");
            char[] wordArray = word.ToCharArray();
            StringBuilder backwardsWord = new StringBuilder();
            for (uint wordArrayIndex = (uint)wordArray.Length; wordArrayIndex-- > 0;) {
                if(!(wordArray[wordArrayIndex] == ' ')) {
                    backwardsWord.Append(wordArray[wordArrayIndex]);
                }
            }
            if (backwardsWord.ToString() == wordStringBuilder.ToString()) {
                Console.WriteLine("The inputted word was a palindrome");
                Console.ReadKey(true);
            } else {
                Console.WriteLine("The inputted word was not a palindrome");
                Console.ReadKey(true);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateCharacters
{
    class Program
    {
        public class CheckWord {
            public bool check(string inputStr) {
                //I have no fucking clue how this works
                return inputStr.Where((c, i) => i > 0 && c == inputStr[i - 1]).Cast<char?>().FirstOrDefault() != null;
            }
        }
        static void Main(string[] args)
        {
            CheckWord checkMethod = new CheckWord();
            Console.WriteLine("Enter your word: ");
            Console.WriteLine(checkMethod.check(Console.ReadLine()));
        }
    }
}
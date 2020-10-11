using System;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Enter your substring: ");
            string substring = Console.ReadLine();
            Console.WriteLine(Reverse.ReversedSubstrings(inputString, substring));
        }
    }
}

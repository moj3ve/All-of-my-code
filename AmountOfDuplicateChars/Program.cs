using System;

namespace AmountOfDuplicateChars
{
    class Program
    {
        static int AmountOfDuplicates(string inputString, char duplicateChar)
        {
            int amountOfDupes = 0;
            foreach (char ch in inputString)
            {
                if (ch == duplicateChar)
                    amountOfDupes++;
            }
            return amountOfDupes;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Input duplicate char: ");
            char duplicateChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(AmountOfDuplicates(inputString, duplicateChar));
        }
    }
}

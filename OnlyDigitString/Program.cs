using System;

namespace OnlyDigitString
{
    class Program
    {
        static bool onlyHasInt(string inputString)
        {
            try
            {
                Convert.ToInt16(inputString);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string inputtedString = Console.ReadLine();
            Console.WriteLine(onlyHasInt(inputtedString));
        }
    }
}

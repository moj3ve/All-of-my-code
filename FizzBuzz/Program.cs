using System;

namespace FizzBuzz
{
    class Program
    {
        static string FizzBuzz(int inputInt)
        {
            switch (inputInt)
            {
                case int n when (inputInt % 3 == 0):
                    return "Fizz";
                case int n when (inputInt % 5 == 0):
                    return "Buzz";
                case int n when (inputInt % 15 == 0):
                    return "FizzBuzz";
            }
            return string.Empty;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your integer: ");
            uint inputInt = Convert.ToUInt32(Console.ReadLine());
            for (int i = 1; i <= inputInt; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
        }
    }
}

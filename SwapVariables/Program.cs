using System;

namespace SwapVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your value for int 1:");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your value for int 2:");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            firstValue = firstValue + secondValue;
            secondValue = firstValue - secondValue;
            firstValue = firstValue - secondValue;

            Console.WriteLine(firstValue.ToString() + "\n" + secondValue.ToString());
        }
    }
}

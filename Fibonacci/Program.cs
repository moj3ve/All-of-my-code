using System;

namespace Fibonacci
{
    class Program
    {
        static string fib(int amountOfInts) {
            int[] fibonacciArray = new int[amountOfInts];
            int result = 1;
            for(int i = 1; i < amountOfInts; i++) {
                fibonacciArray[i] = result;
                result = fibonacciArray[i - 1] + result;
            }
            return String.Join(' ', fibonacciArray);
        }
        static void Main(string[] args)
        {
            Console.Write("Input your amount of returned integers: ");
            int amountOfReturnedValues = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fib(amountOfReturnedValues));
        }
    }
}
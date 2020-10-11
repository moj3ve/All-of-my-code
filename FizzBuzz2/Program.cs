using System;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            uint inputInt = Convert.ToUInt32(Console.ReadLine());
            for(int checkedInt = (int)inputInt; checkedInt != 0; checkedInt--) {
                switch(checkedInt) {
                    case int n when (checkedInt % 15 == 0):
                        Console.WriteLine("FizzBuzz" + n);
                        break;
                    case int n when (checkedInt % 3 == 0 && checkedInt % 15 != 0):
                        Console.WriteLine("Fizz" + n);
                        break;
                    case int n when (checkedInt % 5 == 0 && checkedInt % 15 != 0):
                        Console.WriteLine("Buzz" + n);
                        break;
                }
            }
            Console.ReadKey(true);
        }
    }
}

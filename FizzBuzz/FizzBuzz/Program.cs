using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz {
    class Program {
        static void start(uint inputInt) {
            for(int i = 1; i != (int)inputInt + 1; i++) {
                if (i % 3 == 0 && i % 15 != 0) {
                    Console.WriteLine("fizz");
                } else if (i % 5 == 0 && i % 15 != 0) {
                    Console.WriteLine("buzz");
                } else if (i % 15 == 0) {
                    Console.WriteLine("fizzbuzz");
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args) {
            Console.Write("Input your number: ");
            uint inputInt = Convert.ToUInt32(Console.ReadLine());
            start(inputInt);
        }
    }
}
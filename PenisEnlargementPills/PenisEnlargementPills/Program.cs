using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenisEnlargementPills
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            string dickString = "8=D";
            StringBuilder dick = new StringBuilder(dickString);
            bool biggerDick = true;
            bool anotherPill = true;
            while (biggerDick)
            {
            Console.WriteLine("Nice cock bro, but what if it were bigger? \nThis is your dick now:\n" + dick);
            Console.Write("Do you want to take the pill? y/n");
            cki = Console.ReadKey(true);
            if(cki.Key != ConsoleKey.Y)
                {
                    Console.WriteLine("\nYour loss ");
                    Console.ReadKey(true);
                    biggerDick = false;
                }
            while(cki.Key == ConsoleKey.Y && anotherPill)
            {
                Console.Clear();
                dick.Insert(1, "=");
                Console.WriteLine("\n" + dick);
                Console.Write("You want to take another? y/n");
                cki = Console.ReadKey(true);
                    if(cki.Key == ConsoleKey.Y)
                    {
                    }
                    else
                    {
                        Console.WriteLine("\nYour loss ");
                        Console.ReadKey(true);
                        anotherPill = false;
                        biggerDick = false;
                    }
                }
            }
        }
    }
}
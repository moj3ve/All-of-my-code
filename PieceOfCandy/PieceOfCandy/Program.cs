using System;

namespace PieceOfCandy
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfCandy = 1;
            Console.WriteLine("Ooh piece of candy, you want it? y/n ");
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Cool you have 1 piece of candy");
                amountOfCandy++;
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Well your loss mine now");
                Console.ReadKey(true);
                Environment.Exit(0);
            }
            while (amountOfCandy > 1 && amountOfCandy != 11)
            {
                Console.WriteLine("Ooh piece of candy, you want it? y/n ");
                ConsoleKeyInfo keyPressed2 = Console.ReadKey(true);
                if (keyPressed2.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("Cool you have " + amountOfCandy + " pieces of candy");
                    amountOfCandy++;
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Well your loss mine now");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Oops you took to much candy fatass you're getting kidnapped");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
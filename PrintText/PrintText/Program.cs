using System;
using System.IO;
using System.Text;

namespace PrintText
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Enter directory of text file: ");
            string directory = Console.ReadLine();
            PrintTextFile text = new PrintTextFile();
            text.Print(directory);
            }
            catch (System.IO.DirectoryNotFoundException exception)
            {
                Console.Clear();
                Console.WriteLine("Invalid directory");
                Console.ReadKey(true);
                Console.Write("Do you want to see the advanced info? y/n: ");
                ConsoleKeyInfo info = Console.ReadKey(true);
                if(info.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.WriteLine(exception);
                    Console.ReadLine();
                }
                else
                {
                }
            }
        }
    }
}

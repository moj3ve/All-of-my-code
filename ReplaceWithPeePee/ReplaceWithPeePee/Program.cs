using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWithPeePee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text");
            string textEntry = Console.ReadLine();
            textEntry = textEntry.Replace("I", "peepee");
            Console.WriteLine(textEntry + " :)");
            Console.ReadKey(true);
        }
    }
}
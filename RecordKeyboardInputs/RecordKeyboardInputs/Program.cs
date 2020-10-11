using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeyboardInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC to stop");
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine(Console.ReadKey(true).Key);
            }
        }
    }
}

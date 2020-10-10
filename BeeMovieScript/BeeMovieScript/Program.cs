using System;
using System.Text;
using System.IO;

namespace BeeMovieScript
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("/Users/brandonsmacbookpro/Documents/BeeMovieScript.rtf"));
            Console.ReadKey(true);
        }
    }
}

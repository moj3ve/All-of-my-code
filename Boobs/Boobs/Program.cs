using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boobs
{
    class Program
    {
        static void Main(string[] args)
        {
            string boobs = "https://lh3.googleusercontent.com/proxy/E2vXtddpsZiq3Aw67-uL5TbG7pZA3gSCs0gPzz8vroilDmuHdH4WY2-0Fia2SmWPIO5_p60yPXmvt1KY5yEzNn9K2YGQs2-GDp7ko63rfA";
            Console.WriteLine("Say something damnit: ");
            string answer = Console.ReadLine();
            if (answer.Contains("boob"))
            {
            Console.WriteLine(boobs);
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Wrong answer stupid fucker");
                Console.ReadKey(true);
            }
        }
    }
}

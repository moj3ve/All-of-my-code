using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ask;
            bool runAgain = true;
            while (runAgain)
            {
                ask = true;
            string[] ballAnswers = {"Yes", "No", "Maybe", "Ask a different time" };
            Random randomInit = new Random();
            int ballAnswersIndex = randomInit.Next(0, 3);
            Console.Write("Enter your question: ");
                string question = Console.ReadLine();
                int questionIndex = question.Length;
                questionIndex--;
            Console.ReadLine();
            if(question[questionIndex] == '?')
                {
            Console.WriteLine(ballAnswers[ballAnswersIndex]);
            Console.ReadLine();
                    Console.Clear();
                    while (ask == true)
                    {
                Console.Write("Would you like to ask again?: y/n ");
                ConsoleKeyInfo askAgain = Console.ReadKey();
                if(askAgain.Key == ConsoleKey.Y)
                {
                    runAgain = true;
                            ask = false;
                            Console.Clear();
                }
                if(askAgain.Key == ConsoleKey.N)
                {
                    runAgain = false;
                            ask = false;
                }
                        if(askAgain.Key != ConsoleKey.N && askAgain.Key != ConsoleKey.Y)
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Answer: ");
                            ask = true;
                            runAgain = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Improperly formatted question: ");
                    Console.ReadLine();
                    runAgain = true;
                }
            }
        }
    }
}

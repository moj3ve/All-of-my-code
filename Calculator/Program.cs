using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        public static int returnedInt = 0;
        static int doMath(string operation, List<int> numList)
        {
            foreach (int i in numList)
            {
                switch (operation)
                {
                    case "add":
                        returnedInt = numList.Sum();
                        break;
                    case "subtract":
                        returnedInt = ;
                        break;
                    case "multiply":
                        break;
                    case "divide":
                        break;
                }
            }
            return returnedInt;
        }
        static void Main(string[] args)
        {
            bool finishedInputting = false;
            List<int> inputList = new List<int>();
            while (!finishedInputting)
            {
                Console.Write("Enter your numbers: ");
                inputList.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Are you finished inputting? y/n \n");
                finishedInputting = Console.ReadKey(true).Key == ConsoleKey.Y;
            }
            Console.Write("Which operation do you want to use?: ");
            string operation = Console.ReadLine().ToLower();
            Console.WriteLine(doMath(operation, inputList));
        }
    }
}

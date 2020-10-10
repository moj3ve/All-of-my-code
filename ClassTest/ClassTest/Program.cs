using System;
using System.Collections.Generic;
using ClassTest.Calc;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool invalidResponse = false;
            string operationInput = "";
            string[] operation = { "+", "-", "*", "/"};
            bool lastInput = false;
            List<double> userInputNumbers = new List<double>();
            int placeNum = 1;
            try
            {

            while (!lastInput)
            {
                Console.Write("What's the " + placeNum + " number you would like to use?: ");
                userInputNumbers.Add(Convert.ToDouble(Console.ReadLine()));
                placeNum++;
                if (!invalidResponse && placeNum > 2)
                {
                    ConsoleKeyInfo cki;
                    Console.Write("Is that it?: y/n ");
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Y)
                    {
                        lastInput = true;
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        lastInput = false;
                    }
                    if(cki.Key != ConsoleKey.Y && cki.Key != ConsoleKey.N)
                        {
                            Console.Clear();
                            Console.Write("Invalid Response");
                            invalidResponse = true;
                        }
                    while (lastInput == true)
                    {
                        Console.Write("What operation would you like to use?: (+, -, *, /) ");
                        operationInput = Console.ReadLine();
                        lastInput = false;
                    }
                    int n = Convert.ToInt32(userInputNumbers.Count);
                    int n1 = Convert.ToInt32(userInputNumbers.Count);
                    if (operationInput == operation[0])
                    {
                        Calculator add = new Calculator();
                        add.Add(n, n1, operationInput, operation[0], userInputNumbers);
                    }
                    if (operationInput == operation[1])
                    {
                        Calculator subtract = new Calculator();
                        subtract.Subtract(n, n1, operationInput, operation[1], userInputNumbers);
                    }
                    if (operationInput == operation[2])
                    {
                        Calculator multiply = new Calculator();
                        multiply.Multiply(n, n1, operationInput, operation[2], userInputNumbers);
                    }
                    if (operationInput == operation[3])
                    {
                        Calculator divide = new Calculator();
                        divide.Divide(n, n1, operationInput, operation[3], userInputNumbers);
                    }
                    if(operationInput != operation[0] && operationInput != operation[1] && operationInput != operation[2] && operationInput != operation[3])
                    {
                            Console.Clear();
                        Console.WriteLine("Invalid operation: ");
                        lastInput = false;
                    }
                }
            }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e + "\n Format of answer invalid");
            }
        }
    }
}
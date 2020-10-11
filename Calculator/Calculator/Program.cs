using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopAsking = false;
            int placeHolderInt = 1;
            string[] operations = {"add", "subtract", "multiply", "divide"};
            List<int> Inputs = new List<int>();
            while(!stopAsking)
            {
                Console.Write("Enter number " + placeHolderInt + ": ");
                placeHolderInt++;
                Inputs.Add(Convert.ToInt32(Console.ReadLine()));
                if(placeHolderInt > 2)
                {
                    Console.WriteLine("Are you finished? y/n");
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if(cki.Key == ConsoleKey.Y)
                    {
                        stopAsking = true;
                    } else if (cki.Key == ConsoleKey.N)
                    {
                        stopAsking = false;
                    }
                }
            }
            Console.Write("What operation do you want to use?: (add, subtract, multiply, divide) ");
            string operationAnswer = Console.ReadLine();
            for(int nums = 0; nums != Inputs.Count; nums++)
            {
                int inputsIndex = 0;
                if(operationAnswer == operations[0])
                {
                    while(inputsIndex != Inputs.Count)
                    {
                        int sum = Inputs[inputsIndex] + Inputs[inputsIndex++];
                        if(Inputs.Count - 1 == inputsIndex && Inputs.Count > 2)
                        {
                            sum = sum + Inputs[inputsIndex];
                            Console.WriteLine(sum);
                            Console.ReadLine();
                            Environment.Exit(0);
                        } else if(Inputs.Count == inputsIndex + 1 && Inputs.Count == 2)
                        {
                            Console.WriteLine(sum);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                } else if (operationAnswer == operations[1])
                {
                    while (inputsIndex != Inputs.Count)
                    {
                        int difference = Inputs[inputsIndex] - Inputs[inputsIndex++];
                        if (Inputs.Count - 1 == inputsIndex && Inputs.Count > 1)
                        {
                            difference = difference - Inputs[inputsIndex];
                            Console.WriteLine(difference);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        else if (Inputs.Count == inputsIndex)
                        {
                            Console.WriteLine(difference);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                } else if (operationAnswer == operations[2])
                {
                    while (inputsIndex != Inputs.Count)
                    {
                        int product = Inputs[inputsIndex] * Inputs[inputsIndex++];
                        if (Inputs.Count - 1 == inputsIndex && Inputs.Count > 1)
                        {
                            product = product * Inputs[inputsIndex];
                            Console.WriteLine(product);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        else if (Inputs.Count == inputsIndex)
                        {
                            Console.WriteLine(product);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                } else if (operationAnswer == operations[3])
                {
                    while (inputsIndex != Inputs.Count)
                    {
                        int quotient = Inputs[inputsIndex] / Inputs[inputsIndex++];
                        if (Inputs.Count - 1 == inputsIndex && Inputs.Count > 1)
                        {
                            quotient = quotient / Inputs[inputsIndex];
                            Console.WriteLine(quotient);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        else if (Inputs.Count == inputsIndex)
                        {
                            Console.WriteLine(quotient);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                } else
                {
                    Console.WriteLine("Invalid Answer: ");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
    }
}

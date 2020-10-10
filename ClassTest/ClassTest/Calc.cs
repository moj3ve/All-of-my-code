using System;
using System.Collections.Generic;

namespace ClassTest.Calc
{
    public class Calculator
    {
        public void Add(int n, int n1, string operationInput, string operation, List<double>userInputNumbers)
        {
            int userInputNumbersIndex = 0;
            double result;
            while (operationInput == operation && n > 0)
            {
            if (n1 == n)
            {
                n--;
            }
            n--;
            result = userInputNumbers[userInputNumbersIndex] + userInputNumbers[userInputNumbersIndex + 1];
            userInputNumbersIndex++;
            userInputNumbers[userInputNumbersIndex] = Convert.ToInt32(result);
            if(n == 0)
                {
                    Console.WriteLine(result);
                }
            }
        }
        public void Subtract(int n, int n1, string operationInput, string operation, List<double> userInputNumbers)
        {
            int userInputNumbersIndex = 0;
            double result;
            while (operationInput == operation && n > 0)
            {
                if (n1 == n)
                {
                    n--;
                }
                n--;
                result = userInputNumbers[userInputNumbersIndex] - userInputNumbers[userInputNumbersIndex + 1];
                userInputNumbersIndex++;
                userInputNumbers[userInputNumbersIndex] = Convert.ToInt32(result);
                if (n == 0)
                {
                    Console.WriteLine(result);
                }
            }
        }
        public void Multiply(int n, int n1, string operationInput, string operation, List<double> userInputNumbers)
        {
            int userInputNumbersIndex = 0;
            double result;
            while (operationInput == operation && n > 0)
            {
                if (n1 == n)
                {
                    n--;
                }
                n--;
                result = userInputNumbers[userInputNumbersIndex] * userInputNumbers[userInputNumbersIndex + 1];
                userInputNumbersIndex++;
                userInputNumbers[userInputNumbersIndex] = Convert.ToInt32(result);
                if (n == 0)
                {
                    Console.WriteLine(result);
                }
            }
        }
        public void Divide(int n, int n1, string operationInput, string operation, List<double> userInputNumbers)
        {
            int userInputNumbersIndex = 0;
            double result;
            while (operationInput == operation && n > 0)
            {
                if (n1 == n)
                {
                    n--;
                }
                n--;
                result = userInputNumbers[userInputNumbersIndex] / userInputNumbers[userInputNumbersIndex + 1];
                userInputNumbersIndex++;
                userInputNumbers[userInputNumbersIndex] = Convert.ToInt32(result);
                if (n == 0)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
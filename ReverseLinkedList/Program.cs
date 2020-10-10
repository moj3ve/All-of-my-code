using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseLinkedList
{
    class Program
    {
        static List<int> reverseList(List<int> inputList)
        {
            for (uint i = (uint)inputList.Count - 1, n = 0; n < inputList.Count; i--, n++)
            {
                int nPlaceHolder = inputList[(int)n];
                int iPlaceHolder = inputList[(int)i];
                inputList[(int)i] = nPlaceHolder;
                inputList[(int)n] = iPlaceHolder;
            }
            return inputList;
        }
        static void Main(string[] args)
        {
            int[] linkedListTester = new int[20];
            Random randValue = new Random();
            for (int i = 0; i < linkedListTester.Length; i++)
                linkedListTester[i] = randValue.Next();
            Console.WriteLine(string.Join(" ", reverseList(linkedListTester.ToList<int>())));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;


namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Enumerable.Range(1, 100).ToArray();
            Random randInt = new Random();
            List<int> intList = intArray.ToList<int>();
            int removedInt = randInt.Next(100);
            intList.RemoveAt(removedInt);
            foreach(int checkedInt in intList) {
                switch(checkedInt) {
                    case int n when(checkedInt != intList.Last() && intList[intList.IndexOf(checkedInt) + 1] != checkedInt + 1):
                    Console.WriteLine(checkedInt + 1);
                    return;

                    case int n when(checkedInt == intList.Last()):
                    Console.WriteLine("100");
                    return;
                }
            }
        }
    }
}

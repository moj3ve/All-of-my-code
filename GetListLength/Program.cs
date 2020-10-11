using System;
using System.Collections.Generic;

namespace GetListLength
{
    class Program
    {
        //btw this is terrible implementation and it takes like 20 seconds to return
        static int Length(List<int> usedList)
        {
            int length = 0;
            foreach (int i in usedList)
                length++;
            return length;
        }
        static void Main(string[] args)
        {
            Random randInt = new Random();
            int size = randInt.Next();
            List<int> generatedList = new List<int>(size);
            Console.WriteLine(generatedList.Count);
            for (int i = 0; i < size; i++)
                generatedList.Add(randInt.Next());
            Console.WriteLine(Length(generatedList));
        }
    }
}

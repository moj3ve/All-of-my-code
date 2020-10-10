using System;
using System.Linq;

namespace SmallestAndLargestInt
{
    class Program
    {
        static (int, int) returnMinMax(int[] intArray)
        {
            int largestInt = 0, smallestInt = 0, comparedInt1 = intArray[0], comparedInt2 = intArray[0];
            foreach (int i in intArray)
            {
                //I'll test with switch later
                if (i <= comparedInt1)
                    largestInt = comparedInt1;
                else
                    comparedInt1 = i;
                if (i >= comparedInt2)
                    smallestInt = comparedInt2;
                else
                    comparedInt2 = i;
            }
            return (largestInt, smallestInt);
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] randArray = new int[20];
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = rand.Next();
            }
            Console.WriteLine(returnMinMax(randArray));
            Console.WriteLine(randArray.Max() + " " + randArray.Min());
        }
    }
}

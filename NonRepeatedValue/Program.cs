using System;
using System.Collections.Generic;
using System.Linq;

namespace NonRepeatedValue
{
    class Program
    {
        static string returnFirstDistinct(int[] comparedArray) {
            List<int> comparedList = comparedArray.ToList<int>();
            comparedList.Sort();
            for(int i = 1; i < comparedList.Count; i++) {
                if(comparedList[i] != comparedList[i - 1])
                    return "The first unique integer was " + comparedList[i - 1].ToString();
            }
            return "There were no duplicate integers";
        }
        static void Main(string[] args)
        {
            int[] intArray = new int[3];
            for(int i = 0; i < intArray.Length; i++) {
                Console.WriteLine("Input numbers: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(returnFirstDistinct(intArray));
        }
    }
}

using System;

namespace Magic8ball_CustomRandomNumber_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "Yes", "No", "Ask later", "Maybe"};
            int rand = Random(0, 3);
            Console.WriteLine(strs[rand]);
            Console.ReadLine();
        }
        static int Random(int beginningIndex, int endingIndex)
        {
            bool indexOutOfRange = false;
            while(!indexOutOfRange)
            {
                DateTime now = DateTime.Now;
                int second = now.Second;
                if(second > endingIndex)
                {
                    second = second - 10;
                    if(second < beginningIndex)
                    {
                        second = beginningIndex;
                        return second;
                    }
                } else
                {
                    return second;
                }
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int placeHolder = 0;
            double sum = 0;
            string answer = "";
            string[] operation = { "+", "-", "*", "/"};
            bool firstNum;
            List<double> nums = new List<double>();
            int n;
            int placeNum = 1;
            bool lastNum = false;
            while(!lastNum)
            {
                Console.Write("What's the " + placeNum + " number you would like to use?: ");
                nums.Add(Convert.ToDouble(Console.ReadLine()));
                    firstNum = true;
                    placeNum++;
                if(firstNum == true && placeNum > 2)
                {
                Console.Write("Is that it?: y/n ");
                string yn = Console.ReadLine();
                if(yn == "y")
                {
                    lastNum = true;
                }
                if(yn == "n")
                    {
                        lastNum = false;
                    }
                if(lastNum == true)
                    {
                        Console.Write("What operation would you like to use?: (+, -, *, /) ");
                        answer = Console.ReadLine();
                    }
                        n = Convert.ToInt32(nums.Count);
                    int n1 = Convert.ToInt32(nums.Count);
                while(answer == operation[0] && n > 0)
                    {
                        if(n1 == n)
                        {
                        n--;
                        }
                        n--;
                        sum = nums[placeHolder] + nums[placeHolder + 1];
                        placeHolder++;
                        nums[placeHolder] = Convert.ToInt32(sum);
                    }
                while (answer == operation[1] && n > 0)
                    {
                        if (n1 == n)
                        {
                            n--;
                        }
                        n--;
                        sum = nums[placeHolder] - nums[placeHolder + 1];
                        placeHolder++;
                        nums[placeHolder] = Convert.ToInt32(sum);
                    }
                while (answer == operation[2] && n > 0)
                    {
                        if (n1 == n)
                        {
                            n--;
                        }
                        n--;
                        sum = nums[placeHolder] * nums[placeHolder + 1];
                        placeHolder++;
                        nums[placeHolder] = Convert.ToInt32(sum);
                    }

                while(answer == operation[3] && n > 0)
                    {
                        if (n1 == n)
                        {
                            n--;
                        }
                        n--;
                        sum = nums[placeHolder] / nums[placeHolder + 1];
                        placeHolder++;
                        nums[placeHolder] = Convert.ToInt32(sum);
                    }
                    if (lastNum == true && answer != "")
                    {
                    Console.Write("Your number is: " + sum);
                    Console.ReadLine();
                        bool invalid = false;
                        while (!invalid && lastNum == true)
                        {
                        Console.Write("Would you like to do another calculation?: y/n ");
                        string calcAnsString = Console.ReadLine();
                        StringBuilder newCalc = new StringBuilder(calcAnsString);
                        if(newCalc[0] == 'y')
                        {
                            lastNum = false;
                                invalid = true;
                                placeNum = 1;
                                placeHolder = 0;
                                nums.Clear();
                        }
                        if(newCalc[0] == 'n')
                        {
                            lastNum = true;
                                invalid = true;
                        }
                        if(newCalc[0] != 'n' && newCalc[0] != 'y')
                        {
                            Console.Write("Invalid answer: ");
                                invalid = false;
                        }
                        }

                        
                    }
                }
            }

        }
    }
}
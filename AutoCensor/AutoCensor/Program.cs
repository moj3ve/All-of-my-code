using System;
using System.Text;
using System.Linq;

namespace AutoCensor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] swears = { "fuck", "shit", "ass", "crap", "bitch", "pussy", "dick", "cunt", "asshole", "bitchass", "shitface", "dumbass" };
            Console.Write("Enter text you want to censor: ");
            string entryString = Console.ReadLine();
            string[] entryStringParser = entryString.Split(' ');
            foreach (var entryStringParsed in entryStringParser)
            {
                bool stringIsSwear = true;
                if (stringIsSwear)
                {
                        if (!swears.Any(entryStringParsed.Contains))
                        {
                            Console.Write($"{entryStringParsed} ");
                        }
                        if (swears.Any(entryStringParsed.Contains))
                        {
                        StringBuilder entryStringParsedCensored = new StringBuilder(entryStringParsed);
                        entryStringParsedCensored.Replace(entryStringParsedCensored[1], '*');
                        Console.Write($"{entryStringParsedCensored} ");
                        }
                    }
                }
            }
        }
    }
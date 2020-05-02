using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator1.Operations;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                string[] swears = { "fuck ", "shit ", "ass ", "crap ", "bitch ", "pussy ", "dick ", "cunt ", "asshole ", "bitchass ", "shitface ", "dumbass " };
                Console.Write("Enter your string: ");
                string entryString = Console.ReadLine();
                StringBuilder entryBuilder = new StringBuilder(entryString);
                Console.Write("Which letter do you want to edit?: ");
                int index = Convert.ToInt32(Console.ReadLine());
                index--;
                Console.Write("Do you want to {delete(0), upper(1), lower(2), manually edit(3), censor(4)} ");
                string operationsIndex = Console.ReadLine();
                string operationsIndexString = operationsIndex.ToLower();
                if (operationsIndex == "0" || operationsIndexString == "delete")
                {
                    Operation delete = new Operation();
                    delete.Delete(entryBuilder, index);
                }
                if (operationsIndex == "1" || operationsIndexString == "upper")
                {
                    Operation upper = new Operation();
                    upper.Upper(entryBuilder, index);
                }
                if (operationsIndex == "2" || operationsIndexString == "lower")
                {
                    Operation lower = new Operation();
                    lower.Lower(entryBuilder, index);
                }
                if (operationsIndex == "3" || operationsIndexString == "manually edit")
                {
                    Operation manuallyEdit = new Operation();
                    manuallyEdit.ManuallyEdit(entryBuilder);
                }
                if (operationsIndex == "4" || operationsIndexString == "censor")
                {
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
                                Operation entryStringParsedCensored = new Operation();
                                entryStringParsedCensored.Censor(entryStringParsed);
                            }
                        }
                    }
                }
                if (operationsIndex != "0" && operationsIndex != "1" && operationsIndex != "2" && operationsIndex != "3" && operationsIndexString != "delete" && operationsIndexString != "upper" && operationsIndexString != "lower" && operationsIndexString != "manually edit" && operationsIndex != "4" && operationsIndexString != "censor")
                {
                    Console.WriteLine("Invalid Answer ");
                    done = true;
                }
                Console.WriteLine("Do you want to continue?: y/n ");
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Y)
                {
                    done = false;
                }
                if (cki.Key == ConsoleKey.N)
                {
                    done = true;
                }
                if (cki.Key != ConsoleKey.Y && cki.Key != ConsoleKey.N)
                {
                    Console.WriteLine("Invalid Answer ");
                    Console.ReadLine();
                    done = true;
                }
            }
        }
    }
}
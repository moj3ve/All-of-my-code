using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1.Operations
{
    class Operation
    {
        public void Delete(StringBuilder entryBuilder, int index)
        {
            int indexPlusOne = index + 1;
            if(indexPlusOne == 1)
            {
                entryBuilder = entryBuilder.Remove(index, index + 1);
                Console.WriteLine(entryBuilder);
                Console.ReadLine();
            }
            if(indexPlusOne > 1)
            {
                entryBuilder = entryBuilder.Remove(index, index);
                Console.WriteLine(entryBuilder);
                Console.ReadLine();
            }
        }
        public void Upper(StringBuilder entryBuilder, int index)
        {
            char charReplace = entryBuilder[index];
            charReplace = char.ToUpper(charReplace);
            entryBuilder = entryBuilder.Replace(entryBuilder[index], charReplace, index, 1);
            Console.WriteLine(entryBuilder);
            Console.ReadLine();
        }
        public void Lower(StringBuilder entryBuilder, int index)
        {
            char charReplace = entryBuilder[index];
            charReplace = char.ToLower(charReplace);
            entryBuilder = entryBuilder.Replace(entryBuilder[index], charReplace, index, 1);
            Console.WriteLine(entryBuilder);
            Console.ReadLine();
        }
        public void ManuallyEdit(StringBuilder entryBuilder)
        {
            Console.Write("Where would you like to add text?: ");
            int index = Convert.ToInt32(Console.ReadLine());
            index = index - 1;
            Console.Write("Input text you would like to add?: ");
            string inputText = Console.ReadLine();
            entryBuilder = entryBuilder.Insert(index, inputText, 1);
            Console.WriteLine(entryBuilder);
            Console.ReadLine();
        }
        public void Censor(string entryStringParsed)
        {
            StringBuilder entryStringParsedCensored = new StringBuilder(entryStringParsed.Length);
            for (int i = 0; i < entryStringParsed.Length; i++)
            {
                entryStringParsedCensored.Append('*');
            }
            Console.Write($"{entryStringParsedCensored} ");
        }
    }
}

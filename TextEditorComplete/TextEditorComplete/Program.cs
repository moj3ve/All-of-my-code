using System;
using System.Text;
using System.IO;

namespace TextEditorComplete
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Do you want to input text to edit or use an already made file? (file/input) ");
            string answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "file")
            {
                Console.Write("Enter directory of text file: ");
                string directory = Console.ReadLine();
                    string text = File.ReadAllText(directory);
                    StringBuilder newText = new StringBuilder(text);
                    string[] words = text.Split(' ');
                    Console.WriteLine(text);
                    Console.Write("What is the number of the word you want to edit?: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    for (int wordsIndex = 0; wordsIndex != index - 1; wordsIndex++)
                    {
                        Console.Write(words[wordsIndex] + " ");
                    }
                        string addedText = Console.ReadLine();
                        newText.Remove(words[index - 2].Length + 1, words[index - 1].Length);
                        newText.Insert(words[index - 2].Length + 1, addedText, 1);
                        Console.WriteLine(newText);
                        using (StreamWriter outputFile = new StreamWriter(directory, true))
                        {
                            File.WriteAllText(directory, String.Empty);
                            outputFile.Write(newText);
                        }
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.Write(e);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.Write(e);
            }
        }
    }
}

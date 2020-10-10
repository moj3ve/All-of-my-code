using System.IO;
using System;

public class PrintTextFile
{
    public void Print(string directory)
    {
        string textFile = File.ReadAllText(path: directory);
        Console.Clear();
        Console.WriteLine(textFile);
        Console.ReadKey(true);
    }
}

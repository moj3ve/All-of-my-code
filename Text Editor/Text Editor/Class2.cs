using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Encryption
{
	public void Class1(string input, int key)
	{
		int sbIndex = 0;
		string[] letters = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
		StringBuilder output = new StringBuilder(input);
		foreach(char ch in StringBuilder(output))
		{
			for (int index = 0; letters[sbIndex] = output[index]; index++)
            {
				output = output.Replace(output[sbIndex], letters[0 + key]);
				Console.WriteLine(output);
				Console.ReadKey(true)
            };
        }
	}
}

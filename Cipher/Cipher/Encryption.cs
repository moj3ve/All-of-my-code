using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    public class Encryption
    {
			public void Cipher(string input, int key)
			{
			bool matchChars = false;
			int index = 0;
				string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
			while (!matchChars)
			{
				index++;
				foreach (char ch in input)
				{
					if (input == letters[index])
				{
					input = letters[index + key];
					StringBuilder output = new StringBuilder(input);
					matchChars = true;
					Console.Write(output);
					Console.ReadLine();
				}
				}
			}
			}
		}
	}
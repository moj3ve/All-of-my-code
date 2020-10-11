using System;

namespace ReverseWords
{
    public static class Reverse
    {
        public static string reverseString(string reversedString)
        {
            char[] reversedStringArray = reversedString.ToCharArray();
            for (int i = 0; i < reversedString.Length / 2; i++)
            {
                char placeHolderString2 = reversedStringArray[i];
                char placeHolderString = reversedString[(reversedString.Length - 1) - i];
                reversedStringArray[i] = placeHolderString;
                reversedStringArray[(reversedString.Length - 1) - i] = placeHolderString2;
                reversedString = string.Join("", reversedStringArray);
            }
            return reversedString;
        }
        public static string ReversedSubstrings(string inputString, string reversedSubstring)
        {
            string[] words = inputString.Split(' ');
            foreach (string checkedString in words)
            {
                if (checkedString == reversedSubstring)
                {
                    words[Array.IndexOf(words, checkedString)] = Reverse.reverseString(checkedString);
                }
            }
            Array.Reverse(words);
            return String.Join(" ", words);
        }
    }
}
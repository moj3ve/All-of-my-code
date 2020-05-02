using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cipher;
namespace CaesarCypher
{
    class Program
    {
        static char Encrypt(char ch, int code)
        {
            if (!char.IsLetter(ch)) return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((ch + code - offset) % 26 + offset);
        }

        static string Encrypt(string input, int code)
        {
            return new string(input.Select(ch => Encrypt(ch, code)).ToArray());
        }

        static string Decrypt(string input, int code)
        {
            return Encrypt(input, 26 - code);
        }


        static void Main()
        {
            Console.WriteLine("Input text you want to encrypt: ");
            string TestCase = Console.ReadLine();
            string str = TestCase;

            Console.WriteLine(str);
            str = Encrypt(str, 5);
            Console.WriteLine("Encrypted: " + str);
            str = Decrypt(str, 5);
            Console.WriteLine("Decrypted: " + str);
            Console.ReadKey();
        }
    }
}
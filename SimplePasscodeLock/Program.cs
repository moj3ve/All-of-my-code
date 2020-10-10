using System;
using System.Collections.Generic;

namespace SimplePasscodeLock
{
    class Program
    {
        public static List<string> usernameList = new List<string>();
        public static List<string> passwordList = new List<string>();
        static void openHome()
        {
            Console.Clear();
            Console.WriteLine("Welcome");
            Console.ReadKey(true);
        }
        static bool submitPass()
        {
        Redo:
            Console.Clear();
            Console.WriteLine("Register or Login?");
            string answer = Console.ReadLine().ToLower();
        Start:
            if (answer == "register")
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                if (usernameList.Contains(username))
                {
                    Console.WriteLine("That username is already taken! ");
                    Console.ReadLine();
                    goto Start;
                }
                usernameList.Add(username);
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                /*bool finishedInput = false;
                while (!finishedInput)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        password = password.ToLower();
                        passwordList.Add(password);
                        finishedInput = true;
                    }
                    else
                        password += key.KeyChar;
                }*/
                Console.Clear();
                Console.WriteLine("Successfully registered! ");
                Console.ReadKey(true);
                goto Redo;
            }
            else if (answer == "login")
            {
                Console.Write("Enter your username: ");
                string usernameInput = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = null;
                bool finishedInput = false;
                while (!finishedInput)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        passwordList.Add(password);
                        finishedInput = true;
                    }
                    else
                    {
                        password += key.KeyChar;
                    }
                }
                if (usernameList.IndexOf(usernameInput) == passwordList.IndexOf(password) && usernameList.Contains(usernameInput) && passwordList.Contains(password))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("This username doesn't exist or doesn't match the password!");
                    Console.ReadLine();
                    goto Start;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            usernameList.Add("poop");
            passwordList.Add("poop");
            Console.Clear();
            if (submitPass())
            {
                openHome();
            }
        }
    }
}

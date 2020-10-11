using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int intString = 12;
            string str = "|\\";
            string str1 = "|_\\";
            StringBuilder tri = new StringBuilder(str);
            StringBuilder tri1 = new StringBuilder(str1);
            Console.WriteLine(tri);
            for(int i = 0; i != intString; i++)
            {
                tri.Insert(1, " ");
                tri1.Insert(1, "_");
                Console.WriteLine(tri);
            }
            Console.WriteLine(tri1);
            Console.ReadKey(true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Openurl
{
    class Program
    {
        static void Main(string[] args)
        {
            var psi = new ProcessStartInfo("chrome.exe");
            psi.Arguments = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            Process.Start(psi);
        }
    }
}
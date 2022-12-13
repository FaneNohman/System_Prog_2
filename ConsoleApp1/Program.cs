using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process.Start("chrome.exe", "https://github.com/");
            Process[] Chrome = Process.GetProcessesByName("chrome");

            for(int i = 0; i<Chrome.Length;i++)
            {
                Console.WriteLine($"{i}: {Chrome[i].ProcessName}");
            }
            Console.ReadLine(); 
        }
    }
}

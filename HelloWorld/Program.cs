using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGreeting();
            Console.ReadKey();
        }

        /// <summary>
        /// Displays greeting to user
        /// </summary>
        static void DisplayGreeting()
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your second name?");
            string lname = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}, you're the man bro", name, lname);
            Console.ReadLine();
        }
    }
}

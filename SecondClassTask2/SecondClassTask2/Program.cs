using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClassTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name? ");
            string name = Console.ReadLine();

            Console.WriteLine("what is your address? ");
            string address = Console.ReadLine();

            Console.WriteLine("How young are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your e-mail? ");
            string email = Console.ReadLine();

            Console.WriteLine("What is your pin? ");
            int pin = int.Parse(Console.ReadLine());

            Console.WriteLine("Hey {0}, You live at {1}, you are only {2}, your e-mail is {3}, and your pin is: {4}", name, address, age, email,pin);
            Console.ReadLine();
            

            
        }
    }
}

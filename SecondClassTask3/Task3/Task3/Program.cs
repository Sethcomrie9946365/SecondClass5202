using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another whole number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter a decimal number: ");
            double dec1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter another decimal number: ");
            double dec2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your e-mail: ");
            string email = Console.ReadLine();

            Console.Write("Whole number: {0}\nSecond whole number: {1}\nDecimal number: {2}\nSecond decimal: {3}\nName: {4}\nEmail: {5}", num1, num2, dec1, dec2, name, email);
            Console.ReadLine();

        }
    }
}

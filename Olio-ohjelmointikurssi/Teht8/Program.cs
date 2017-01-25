using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.WriteLine("Anna luku 1: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku 2: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku 3: ");
            number3 = int.Parse(Console.ReadLine());

            if (number1 >= number2 && number1 >= number3)
            {
                Console.WriteLine("Suurin luku on: " + number1);
            }

            if (number2 >= number1 && number2 >= number3)
            {
                Console.WriteLine("Suurin luku on: " + number2);
            }

            if (number3 >= number1 && number3 >= number2)
            {
                Console.WriteLine("Suurin luku on: " + number3);
            }
        }
    }
}

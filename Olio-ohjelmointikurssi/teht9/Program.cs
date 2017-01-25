using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            Console.WriteLine("Anna luku ");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                sum = sum + number;
                Console.WriteLine("Anna seuraava luku ");
                number = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Lukujen summa " + sum);
        }
    }
}

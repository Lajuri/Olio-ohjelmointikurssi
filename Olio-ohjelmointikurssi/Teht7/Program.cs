using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Anna vuosi ");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Vuosi " + year + " on karkausvuosi");
            
            }
            else
            {
                Console.WriteLine("Vuosi " + year + " ei ole karkausvuosi");
            }

        }
    }
}

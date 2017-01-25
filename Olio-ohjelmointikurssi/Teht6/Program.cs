using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            double consumption = 0.0702;
            double price = 1.595;
            double totalconsumption;
            int kilometers;


            Console.WriteLine("Anna matka >");
            kilometers = int.Parse(Console.ReadLine());
            totalconsumption = kilometers * consumption;

            Console.WriteLine("Bensaa kuluu " + totalconsumption + " litraa, kustannus " + (totalconsumption * price) + " euroa");
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice=1;
            int number;
            Heater harvia = new Heater();
            harvia.PrintData();
            while (choice != 0)
            {
                Console.WriteLine("Harvia control panel");
                Console.WriteLine("1. Switch on/off");
                Console.WriteLine("2. Adjust temperature");
                Console.WriteLine("3. Adjust humidity");
                Console.WriteLine("0. exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        harvia.Switch();
                        break;
                    case 2:
                        Console.WriteLine("Give new temperature:");
                        number = int.Parse(Console.ReadLine());

                        break;



                }
                harvia.Switch();
                harvia.Temp(90);
                harvia.Humi(70);
                harvia.PrintData();
            }
        }
    }
}

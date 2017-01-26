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
            int choice=0;
            int number;
            Heater harvia = new Heater();
            harvia.PrintData();

            do
            {
                Console.WriteLine("Harvia control panel");
                Console.WriteLine("1. Switch on/off");
                Console.WriteLine("2. Adjust temperature");
                Console.WriteLine("3. Adjust humidity");
                Console.WriteLine("4. Print info");
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
                        harvia.Temp(number);
                        break;
                    case 3:
                        Console.WriteLine("Give new humidity:");
                        number = int.Parse(Console.ReadLine());
                        harvia.Humi(number);
                        break;
                    case 4:
                        harvia.PrintData();
                        break;
                    
                } 

                    harvia.PrintData();
            } while (choice != 0);
        }
    }
}

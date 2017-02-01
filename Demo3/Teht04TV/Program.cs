using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04TV
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int number;
            TV tollo = new TV();
            tollo.PrintData();

            do
            {
                Console.WriteLine("TV control panel");
                Console.WriteLine("1. Switch on/off");               
                Console.WriteLine("2. Choose channel");
                Console.WriteLine("3. Increase volume");
                Console.WriteLine("4. Decrease volume");
                Console.WriteLine("5. Print data");
                Console.WriteLine("0. exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        tollo.Switch();
                        break;
                    case 2:
                        Console.WriteLine("Choose channel");
                        number = int.Parse(Console.ReadLine());
                        tollo.ChannelSwitch(number);
                        break;
                    case 3:
                        tollo.VolumeInc();
                        break;
                    case 4:
                        tollo.VolumeDec();
                        break;
                    case 5:
                        tollo.PrintData();
                        break;

                }

                tollo.PrintData();
            } while (choice != 0);
        }
    }
}
//
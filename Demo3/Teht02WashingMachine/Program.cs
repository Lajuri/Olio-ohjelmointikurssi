using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02WashingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int number;
            Washer miele = new Washer();
            miele.PrintData();

            do
            {
                Console.WriteLine("Washer control panel");
                Console.WriteLine("1. Switch on/off");
                Console.WriteLine("2. Empty washer");
                Console.WriteLine("3. Choose program");
                Console.WriteLine("4. Turn sling on/off");
                Console.WriteLine("5. Print data");
                Console.WriteLine("0. exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        miele.Switch();
                        break;
                    case 2:                       
                        miele.Empty();
                        break;
                    case 3:
                        Console.WriteLine("Give program number:");
                        number = int.Parse(Console.ReadLine());
                        miele.Prog(number);
                        break;
                    case 4:
                        miele.Slinging();
                        break;
                    case 5:
                        miele.PrintData();
                        break;

                }

                miele.PrintData();
            } while (choice != 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02WashingMachine
{
    class Washer
    {
        //properties
        public bool IsOn { get; set; }
        public int Program { get; set; }
        public bool Sling { get; set; }
        public bool WaterIn { get; set; }

        //construction
        public Washer()
        {

        }


        //Method to empty washer
        public void Empty()
        {
            if (WaterIn == true) 
                WaterIn = false;

            }
        //Method to switch on and off
        public void Switch()
        {
            if (IsOn == true)
                IsOn = false;
            else
                IsOn = true;

        }
        //Method to choose program
        public void Prog(int value)
        {
            Program = value;
        }
        //Method to turn sling on or off
        public void Slinging(bool value)
        {
            Sling = value;
        }
        public void PrintData()
        {
            if (IsOn == true)
                Console.WriteLine("Washer is On");
            else
                Console.WriteLine("Washer is Off");
            Console.WriteLine("Program: " + Program);
            if (Sling == true)
                Console.WriteLine("Sling is On");
            else
                Console.WriteLine("Sling is Off");
            if (WaterIn == true)
                Console.WriteLine("There is water in washer");
            else
                Console.WriteLine("Washer is empty");
            Console.WriteLine();
        }
    }
}

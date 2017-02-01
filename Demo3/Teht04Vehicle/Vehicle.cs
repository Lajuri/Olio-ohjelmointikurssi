using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04Vehicle
{
    class Vehicle
    {
        //properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        


        //construction
        public Vehicle(string name, int speed, int tyres)
        {
            Name = name;
            Speed = speed;
            Tyres = tyres;
        }
   
        //Method to print data as string
        public void PrintData()
        {
            Console.WriteLine("Vehicle name: " + Name);
            Console.WriteLine("Vehicle speed: " + Speed);
            Console.WriteLine("Vehicle tyres: " + Tyres);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car hiivatti = new Car();
            hiivatti.PrintData();
            hiivatti.Model = "Fiat Bravo";
            hiivatti.Color = "Yellow";
            hiivatti.Engine = 1.2;
            hiivatti.Speed = 10;
            hiivatti.FuzzyDices = true;
            hiivatti.DoorCount = 3;
            Car.SomeProperty = 100;
            hiivatti.PrintData();
            hiivatti.Accelerate();
            Console.WriteLine("Speed = " + hiivatti.Speed);
            hiivatti.Brake(2);
            Console.WriteLine("Speed = " + hiivatti.Speed);

            //Create a new instance from Car class

            Car nascar = new Car("Speedstrep");
            nascar.PrintData();
            nascar.Color = "Black";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            nascar.DoorCount = 3;
            nascar.PrintData();
           


        }
    }
}

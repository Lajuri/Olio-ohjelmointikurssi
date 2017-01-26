using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }

        //Default constructor

        public Car()
        {

        }

        //Constructor
        public Car(string model)
        {
            Model = model;
        }

        //Method to give more speed
        public void Accelerate()
        {
            Speed += 10;

        }
        //Method to decrease speed
        public void Brake(int value)
        {
            Speed -= value;
        
        }

        //method to display car properties

        public void PrintData()
        {
            Console.WriteLine("Car data");
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Engine: " + Engine);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Dices: " + FuzzyDices);
            Console.WriteLine("Doors: " + DoorCount);
            Console.WriteLine("Property: " + SomeProperty);
        }
     
    }
}

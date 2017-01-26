using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Heater
    {
        //properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }

        //construction
        public Heater()
        {

        }
        public Heater(bool isOn, int temperature, double humidity)
        {
            IsOn = isOn;
            Temperature = temperature;
            Humidity = humidity;

        }


        //Method to switch on and off
        public void Switch()
        {
            if (IsOn == true)
                IsOn = false;
            else
                IsOn = true;

        }
        //Method to adjust temperature
        public void Temp(int value)
        {
            Temperature = value;
        }
        //Method to adjust humidity
        public void Humi(int value)
        { 
            Humidity = value;
        }
        public void PrintData()
        {
            if (IsOn == true)
                Console.WriteLine("Heater is On");
            else
                Console.WriteLine("Heater is Off");
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine("Humidity: " + Humidity+"%");
            Console.WriteLine();
        }

    }
}

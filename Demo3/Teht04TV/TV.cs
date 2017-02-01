using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04TV
{
    class TV
    {
        //properties
        public bool IsOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
        

        //construction
        public TV()
        {

        }



        //Method to switch on and off
        public void Switch()
        {
            if (IsOn == true)
            {
                IsOn = false;          
            }
            else
            {
                IsOn = true;
            }
        }
        //Method to choose channel
        public void ChannelSwitch(int value)
        {
            Channel = value;
        }
        //Method to turn sling on or off
        public void VolumeInc()
        {
            Volume += 1;
        }
        public void VolumeDec()
        {
            Volume -= 1;
        }
        public void PrintData()
        {
            if (IsOn == true)
                Console.WriteLine("Washer is On");
            else
                Console.WriteLine("Washer is Off");
            Console.WriteLine("Channel: " + Channel);
            Console.WriteLine("Volume: " + Volume);
            Console.WriteLine();
        }
    }
}

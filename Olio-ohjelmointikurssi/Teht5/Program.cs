using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds1;
            int hours;
            int minutes;
            int seconds2;


            Console.WriteLine("Anna sekunnit > \n");
            seconds1 = int.Parse(Console.ReadLine());
            hours = seconds1 / 60 / 60;
            if (hours < 1)
            {
                hours = 0;
            }
            minutes = hours * 60 * 60;
            minutes = (seconds1 - minutes) / 60;
            if (minutes < 0)
            {
                minutes = 0;
            }
            seconds2 = (hours * 60 * 60) + (minutes * 60);
            seconds2 = seconds1 - seconds2;
            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + hours + " tunti " + minutes + " minuuttia " + seconds2 +" sekunttia");
  
        }
    }
}

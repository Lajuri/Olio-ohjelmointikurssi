﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " HEP");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

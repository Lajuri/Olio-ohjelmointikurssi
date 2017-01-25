using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int k = 4;
            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine("Anna luku: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            k = 0;
            for (int i = 4; i >= k; i--)
            {
                Console.Write(numbers[i]);
                if (i!=0)
                {
                    Console.Write(", ");
                }
                
            }
            Console.WriteLine();
        }
        
    }
}

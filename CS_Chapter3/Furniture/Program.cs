using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your desired wood");
            if (Console.ReadLine().Equals("P"))
            {
                Console.WriteLine("Pine is 100.00");
            }
            else if (Console.ReadLine().Equals("O"))
                Console.WriteLine("Oak is 225.00");

            else if (Console.ReadLine().Equals("M"))
                Console.WriteLine("Mahogany is 310.00");

            else Console.WriteLine("0.00");
        }

        }
    }   
        

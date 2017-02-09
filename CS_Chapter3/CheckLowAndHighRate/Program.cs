using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hourly pay:");
            string line = Console.ReadLine();
            double pay = Convert.ToDouble(line);
            if (pay < 5.65 || pay > 49.99)
            {
                Console.WriteLine("ERROR");
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
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
                line = Console.ReadLine();
                pay = Convert.ToDouble(line);

                if (pay < 5.65 || pay > 49.99)
                {
                    Console.WriteLine("ERROR");
                }
            }
            else Console.WriteLine(pay * 40);
        }
    }
}

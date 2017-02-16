using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string PayString;
            string HoursString;
            decimal PayRate;
            decimal HoursWorked;
            decimal GrossPay;
            decimal Tax;
            decimal Withhold;
            decimal NetPay;


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  Please Enter An Hourly Pay Rate :  ");
            PayString = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  Please Enter Hours Worked :  ");
            HoursString = Console.ReadLine();

            
            PayRate = Convert.ToDecimal(PayString);
            HoursWorked = Convert.ToDecimal(HoursString);

            GrossPay = PayRate * HoursWorked;

            if (GrossPay <= 300)
                Tax = .1M;
            else
                Tax = .12M;

            Withhold = GrossPay * Tax;

            NetPay = GrossPay - Withhold;



            Console.WriteLine("Gross Pay =  {0}", GrossPay);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Withholding Tax = {0}", Withhold);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Net Pay =  {0}", NetPay);


            Console.ReadLine();
        }
    }
}


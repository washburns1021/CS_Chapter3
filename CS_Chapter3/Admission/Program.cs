using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double pointAverage = 3.0;
            double testScore = 60;
            double testScore1 = 80;
            double userinput, userinput2;
            string stringuserinput, stringuserinput2;



            Console.WriteLine("enter your point grade average");
            stringuserinput = Console.ReadLine();
            userinput = Convert.ToDouble(stringuserinput);

            Console.WriteLine("enter your admission test score");
            stringuserinput2 = Console.ReadLine();
            userinput2 = Convert.ToDouble(stringuserinput2);

            if (userinput >= pointAverage && userinput2 >= testScore)
            {
                Console.WriteLine("You are accepted, congratulations");
                return;
            }
            if (userinput < pointAverage && userinput2 >= testScore1)
            {
                Console.WriteLine("You are accepted , conratulations");
                return;
            }
            else
            {
                Console.WriteLine(" Sorry, but you do not meet requirements ");
            }
        }
    }
}

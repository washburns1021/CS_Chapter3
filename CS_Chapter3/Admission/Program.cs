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
            double userInPut1, userInPut2;
            string stringUserInPut1, stringUserInPut2;



            Console.WriteLine("Please enter your point grade average");
            stringUserInPut1 = Console.ReadLine();
            userInPut1 = Convert.ToDouble(stringUserInPut1);

            Console.WriteLine("Please enter your admission test score");
            stringUserInPut2 = Console.ReadLine();
            userInPut2 = Convert.ToDouble(stringUserInPut2);

            if (userInPut1 >= pointAverage && userInPut2 >= testScore)
            {
                Console.WriteLine("You are accepted, congratulations!");
                return;
            }
            if (userInPut1 < pointAverage && userInPut2 >= testScore1)
            {
                Console.WriteLine("You are accepted , conratulations!");
                return;
            }
            else
            {
                Console.WriteLine(" Sorry, but you do not meet requirements ");
            }
        }
    }
}

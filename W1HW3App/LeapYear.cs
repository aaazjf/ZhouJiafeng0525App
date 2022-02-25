using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter year:");
            if (int.TryParse(Console.ReadLine(), out year))
            {
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                    Console.WriteLine("it is  a Leap");
                
                else
                    Console.WriteLine("it is not a Leap");
            }
            else
                Console.WriteLine("input error,try again");

            Console.ReadLine();

        }
    }
}

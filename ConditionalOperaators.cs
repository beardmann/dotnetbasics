using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetbasics
{
    public class ConditionalOperaators
    {
        public void DrivingLicense(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible for a driving license.");
            }
            else
            {
                Console.WriteLine("You are not eligible for a driving license.");
            }
        }

        public void CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        // if-else if-else ladder

        public void CheckNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // switch statement example

        public void DayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
        }
    }
}

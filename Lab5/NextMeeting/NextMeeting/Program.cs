/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		5
*/

using System;

namespace NextMeeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Today's day: ");
            int current = int.Parse(Console.ReadLine());
            Console.Write("Number of days to the meeting day: ");
            int days = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Today is " + Day(current));
            Console.WriteLine("Days to the meeting is " + days + " days");
            Console.WriteLine("Meeting day is " + Day((current + days) % 7));
        }

        static string Day (int input)
        {
            switch (input)
            {
                case 0:
                    return "Sunday";
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                default:
                    return "INVALID INPUT";
            }
        }
    }
}

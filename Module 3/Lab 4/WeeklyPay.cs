/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		4
*/

using System;

namespace WeeklyPay
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 40;
            Console.WriteLine("You entered " + hours + " hours.");
            int earnings = 0;
            if (hours > 40)
            {
                hours -= 40;
                earnings += 400;
                earnings += hours * 15;
            }else
            {
                earnings += hours * 10;
            }
            Console.WriteLine("Gross earning is $" + earnings);
        }
    }
}

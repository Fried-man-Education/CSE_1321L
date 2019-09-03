/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		3
*/

using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter number of quarters: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter number of dimes: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter number of nickels: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number of pennies: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // print stored values
            Console.WriteLine("You entered " + q + " quarters");
            Console.WriteLine("You entered " + d + " dimes");
            Console.WriteLine("You entered " + n + " nickels");
            Console.WriteLine("You entered " + p + " pennies");
            Console.WriteLine();
            // compute & print answer
            int total = q * 25 + d * 10 + n * 5 + p;
            int dollars = total / 100;
            int cents = total % 100;
            Console.WriteLine("Your total is " + dollars + " Dollars and " + cents +" Cents.");
        }
    }
}

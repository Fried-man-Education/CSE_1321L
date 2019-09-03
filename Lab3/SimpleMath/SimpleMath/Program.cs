/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		3
*/

using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter R: ");
            float r = float.Parse(Console.ReadLine());
            Console.Write("Enter T: ");
            float t = float.Parse(Console.ReadLine());
            Console.Clear(); // fresh screen
            // output & calculations
            Console.WriteLine("R = " + r);
            Console.WriteLine("T = " + t);
            Console.WriteLine("R + T = " + (r + t));
            Console.WriteLine("R - T = " + (r - t));
            Console.WriteLine("R * T = " + r * t);
        }
    }
}

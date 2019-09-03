/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		3
*/

using System;

namespace SumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            int z = int.Parse(Console.ReadLine());
            Console.Clear(); // fresh screen
            // output values
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("Z = " + z);
            // calculate and output average
            Console.WriteLine("Average = " + (double)(x + y + z) / 3);
        }
    }
}

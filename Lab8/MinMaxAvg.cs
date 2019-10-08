/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		8
*/
using System;

namespace MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input for values
            Console.WriteLine("Enter values:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.Clear(); // fresh screen
            // console output
            Console.WriteLine("You entered: " + x + ", " + y + ", " + z);
            Console.WriteLine("Max value: " + max(x, y, z));
            Console.WriteLine("Min value: " + min(x, y, z));
            Console.WriteLine("Average value: " + average(x, y, z));
        }

        static int max(int x, int y, int z) // finds maximum number
        {
            return Math.Max(x, Math.Max(y, z));
        }
        static int min(int x, int y, int z) // finds minimum number
        {
            return Math.Min(x, Math.Min(y, z));
        }
        static int average(int x, int y, int z) // finds average number
        {
            return (x + y + z) / 3;
        }
    }
}

/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		1
*/
using System;

// Program Facts.cs
// Demonstrate string concatenation operator conversion of an integer to a string. 
public class Facts
{
    // Prints various facts. 
    public static void Main(String[] args)
    {
        // Strings can be concatenated into one long string 
        Console.WriteLine("We present the following facts for your "
          + "extracurricular edification:");
        Console.WriteLine();

        // A string can contain numeric digits 
        Console.WriteLine("Letters in the Hawaiian alphabet: 12");

        // A numeric value can be concatenated to a string 
        Console.WriteLine("Dialing code for Antarctica: " + 672);
        Console.WriteLine("Year in which Leonardo da Vinci invented "
            + "the parachute: " + 1515);
        Console.WriteLine("Speed of ketchup: " + 40 + " km per year");
    }
}

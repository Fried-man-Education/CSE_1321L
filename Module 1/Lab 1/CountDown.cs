/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		1
*/
using System;

// Program CountDown.cs
// Demonstrate the difference between Write and WriteLine methods. 

public class CountDown
{
    // Prints two lines of output representing a rocket countdown. 
    public static void Main(String[] args)
    {
        Console.Write("Three... ");
        Console.Write("Two... ");
        Console.Write("One... ");
        Console.Write("Zero... ");
        Console.WriteLine("Liftoff!"); // appears on first line 
        Console.WriteLine("Houston, we have a problem.");
    }
}


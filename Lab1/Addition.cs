/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		1
*/
using System;

// Program Addition.cs
// Demonstrate the difference between the addition and string concatenation operators. 

public class Addition
{
    // Concatenates and adds two numbers and prints the results. 
    public static void Main(String[] args)
    {
        Console.WriteLine("24 and 45 concatenated: " + 24 + 45);
        Console.WriteLine("24 and 45 added: " + (24 + 45));
    }
}
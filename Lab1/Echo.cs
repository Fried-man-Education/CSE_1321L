/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		1
*/
using System;

// Program Echo.cs
// Demonstrate reading a string from the user.  

public class Echo
{
    // Reads a character string from the user and prints it.  
    public static void Main(String[] args)
    {
        String message;
        Console.Write("Enter a line of text:");
        message = Console.ReadLine();
        Console.WriteLine("You entered: \"" + message + "\"");
    }
}
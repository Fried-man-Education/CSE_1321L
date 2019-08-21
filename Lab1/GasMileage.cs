/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		1
*/
using System;

// Program GasMileage.cs
public class GasMileage
{
    // Calculates fuel efficiency based on values entered by the user.    
    public static void Main(String[] args)
    {
        int miles;
        double gallons, mpg;
        Console.Write("Enter the number of miles: ");
        miles = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the gallons of fuel used: ");
        gallons = Convert.ToInt32(Console.ReadLine());

        mpg = miles / gallons;
        Console.WriteLine("Miles Per Gallon: " + mpg);
    }
}

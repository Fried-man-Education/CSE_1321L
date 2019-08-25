/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		7
*/

using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 9; i++) // Print row by row
            {
                for (int spacing = 0; spacing <= 7-i; spacing++) // print spacing left of the triangle
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < i*2-1; star++) // print stars for center
                {
                    Console.Write("*");
                }
                // no right spacing needed because of writeline
                Console.WriteLine(); // go to next row
            }
        }
    }
}

/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		7
*/
using System;

namespace Symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            // get size
            Console.Write("Size: ");
            int size = int.Parse(Console.ReadLine());
            // get char
            Console.Write("Char: ");
            char symbol = char.Parse(Console.ReadLine());
            Console.Clear(); // fresh screen
            for (int line = 0; line < size; line++) // print line by line
            {
                for (int i = 0; i < size; i++) // print char by char
                {
                    Console.Write(symbol); // print user symbol
                }
                Console.WriteLine(); // go to next line
            }
        }
    }
}

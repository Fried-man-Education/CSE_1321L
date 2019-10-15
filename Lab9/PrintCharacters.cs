/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		9
*/

using System;

namespace PrintCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Start character: ");
            char ch1 = char.Parse(Console.ReadLine());
            Console.Write("End character: ");
            char ch2 = char.Parse(Console.ReadLine());
            Console.Write("Output: ");
            // output logic
            if (ch1 < ch2) // if values valid
            {
                printChars(ch1, ch2);
            }else // ch2 is before ch1
            {
                Console.WriteLine("start and end characters are out of order. Try again.");
            }
        }

        static void printChars(char ch1, char ch2) // prints chars in 5 length table
        {
            int counter = 5; // inital spacing
            for (int i = ch1; i <= ch2; i++) // ch1 to ch2
            {
                if (counter >= 5) // go to next line
                {
                    Console.WriteLine();
                    counter = 0; // reset counter
                }
                Console.Write((char)i + " "); // print current char
                counter++;
            }
        }
    }
}

/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		4
*/

using System;

namespace Youth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("You entered: ");
            int age = int.Parse(Console.ReadLine());
            if (age <= 21)
            {
                Console.WriteLine("Youth is a wonderful thing. Enjoy.");
            }
            Console.WriteLine("Age is a state of mind. ");
        }
    }
}

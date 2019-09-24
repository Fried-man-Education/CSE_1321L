/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		6
*/

using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(rnd.Next(1,51));
            }
        }
    }
}

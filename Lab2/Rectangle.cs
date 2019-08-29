/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		2
*/

using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 4;
            int height = 8;
            Console.WriteLine("The width = " + width);
            Console.WriteLine("The height = " + height);
            Console.WriteLine("The area = " + width * height);
            Console.WriteLine("The perimeter = " + (width + height) * 2);
        }
    }
}
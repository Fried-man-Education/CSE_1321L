/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		5
*/

using System;

namespace ProcessGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Grades:");
            int g1 = int.Parse(Console.ReadLine());
            int g2 = int.Parse(Console.ReadLine());
            int g3 = int.Parse(Console.ReadLine());
            int g4 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("You entered:	" + g1 + ", " + g2 + ", " + g3 + ", " + g4);
            Console.WriteLine("Highest grade: " + Math.Max(g1, Math.Max(g2, Math.Max(g3, g4))));
            Console.WriteLine("Lowest grade: " + Math.Min(g1, Math.Min(g2, Math.Min(g3, g4))));
            Console.WriteLine("Average grade: " + (float)(g1 + g2 + g3 + g4) / 4);
        }
    }
}

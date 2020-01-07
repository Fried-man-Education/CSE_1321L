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
            Console.Write("Highest grade: ");
            int temp1 = g1;
            int temp2 = g3;
            if (g1 < g2)
            {
                temp1 = g2;
            }
            if (g3 < g4)
            {
                temp2 = g4;
            }
            if (temp1 > temp2)
            {
                Console.WriteLine(temp1);
            }else
            {
                Console.WriteLine(temp2);
            }
            Console.Write("Lowest grade: ");
            temp1 = g1;
            temp2 = g3;
            if (g1 > g2)
            {
                temp1 = g2;
            }
            if (g3 > g4)
            {
                temp2 = g4;
            }
            if (temp1 < temp2)
            {
                Console.WriteLine(temp1);
            }
            else
            {
                Console.WriteLine(temp2);
            }
            Console.WriteLine("Average grade: " + (float)(g1 + g2 + g3 + g4) / 4);
        }
    }
}

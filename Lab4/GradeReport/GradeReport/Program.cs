/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		4
*/

using System;

namespace GradeReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 100;
            Console.WriteLine("You entered " + grade);
            if (grade > 100) // input sanitation
            {
                grade = 100;
            }
            switch (Math.Floor((float)grade/10))
            {
                case 10:
                    Console.WriteLine("That grade is a perfect score. Well done.");
                    break;
                case 9:
                    Console.WriteLine("That grade is well above average. Excellent work.");
                    break;
                case 8:
                    Console.WriteLine("That grade is above average. Nice job.");
                    break;
                case 7:
                    Console.WriteLine("That grade is average work.");
                    break;
                case 6:
                    Console.WriteLine("That grade is not good, you should seek help!");
                    break;
                default:
                    Console.WriteLine("That grade is not passing.");
                    break;
            }
        }
    }
}

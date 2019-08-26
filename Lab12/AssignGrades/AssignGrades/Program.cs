/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		12
*/

using System;

namespace AssignGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            // get class size
            Console.WriteLine("Class size: ");
            int[] Class = new int[int.Parse(Console.ReadLine())]; // set size of class
            // get student grades
            for (int i = 0; i < Class.Length; i++)
            {
                int temp;
                while (true) // while input not valid
                {
                    Console.WriteLine("Student " + i + " score (0-100):");
                    temp = int.Parse(Console.ReadLine());
                    if (temp > 0 && temp < 100) // escape if input valid
                    {
                        break;
                    }
                }
                Class[i] = temp; // store valid grades
            }
            Console.Clear(); // fresh screen
            // output values
            Console.WriteLine("Class size: " + Class.Length);
            Console.Write("Entered grades: ");
            for (int i = 0; i < Class.Length; i++) // print values for each student
            {
                Console.Write(Class[i]);
                if (i < Class.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(); // end of line
            Console.WriteLine(); // spacing
            for (int i = 0; i < Class.Length; i++) // print summaries for students
            {
                Console.WriteLine("Student " + i + " score is " + Class[i] + " and grade is " + printGrades(Class[i]));
            }
        }

        static string printGrades(int grade) // convert numbers to letter grades
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}

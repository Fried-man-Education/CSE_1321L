/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		8
*/

using System;

namespace ComputeAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate square area
            Console.Write("Square side: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Square area: " + squareArea(side)); // call method
            Console.WriteLine(); // spacing
            // calculate rectangle area
            Console.Write("Rectangle width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Rectangle height: ");
            double rectangleHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Square area: " + rectangleArea(width, rectangleHeight)); // call method
            Console.WriteLine(); // spacing
            // calculate circle area
            Console.Write("Circle radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Circle area: " + circleArea(radius)); // call method
            Console.WriteLine(); // spacing
            // calculate triangle area
            Console.Write("Triangle base: ");
            double Base = double.Parse(Console.ReadLine());
            Console.Write("Triangle height: ");
            double triangleHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Circle area: " + triangleArea(Base, triangleHeight)); // call method
        }

        static double squareArea(double side) // calculates area of square
        {
            return side * side;
        }
        static double rectangleArea(double width, double length) // calculates area of rectangle
        {
            return width * length;
        }
        static double circleArea(double radius) // calculates area of circle
        {
            return Math.PI * Math.Pow(radius, 2);
            //return 3.14f * (radius * radius);
        }
        static double triangleArea(double Base, double height) // calculates area of triangle
        { // lowercase "base" not allowed?
            return Base * height / 2;
        }
    }
}

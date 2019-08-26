/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		11
*/

using System;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle example = new Circle();
            Console.WriteLine("Print radius:");
            Console.WriteLine("The radius is " + example.getRadius() + ".");
            Console.WriteLine("Print area:");
            Console.WriteLine("The area is " + example.getArea());
            Console.WriteLine("Print perimeter:");
            Console.WriteLine("The perimeter is " + example.getPerimeter());
            Console.WriteLine("Set radius to 10 and print the object:");
            example.setRadius(10);
            Console.WriteLine("The circle has radius " + example.getRadius() + ".");
            Console.WriteLine("Print area:");
            Console.WriteLine("The area is " + example.getArea());
            Console.WriteLine("Print perimeter:");
            Console.WriteLine("The perimeter is " + example.getPerimeter());
        }
    }

    class Circle
    {
        private double radius = 1;
        public Circle()
        {
        }
        public Circle(int newRadius)
        {
            radius = newRadius;
        }
        public double getRadius ()
        {
            return radius;
        }
        public void setRadius(int value)
        {
            radius = value;
        }
        public double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public void toString()
        {
            Console.WriteLine("The circle has radius " + radius);
        }
    }
}

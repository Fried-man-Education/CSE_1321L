/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		10
*/

using System;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle object1 = new Rectangle();
            Rectangle object2 = new Rectangle(5, 6);
            Console.WriteLine("First object: ");
            object1.getHeight();
            object1.getWidth();
            object1.getArea();
            object1.getPerimeter();
            Console.WriteLine();
            Console.WriteLine("Second object: ");
            object2.getHeight();
            object2.getWidth();
            object2.getArea();
            object2.getPerimeter();
        }
    }

    class Rectangle
    {
        double height;
        double width;
        public Rectangle()
        {
            height = 1.0;
            width = 1.0;
        }
        public Rectangle(double newHeight, double newWidth)
        {
            height = newHeight;
            width = newWidth;
        }
        public void getArea()
        {
            Console.WriteLine("Area: " + height * width);
        }
        public void getPerimeter()
        {
            Console.WriteLine("Perimeter: " + (height + width) * 2);
        }
        public void getHeight()
        {
            Console.WriteLine("Height: " + height);
        }
        public void getWidth()
        {
            Console.WriteLine("Width: " + width);
        }
    }
}

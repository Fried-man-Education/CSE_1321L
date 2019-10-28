using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pac player = new Pac();
            while (true) // "driver"
            {
                Console.WriteLine("Current location – X: " + player.x + " Y: " + player.y);
                Console.WriteLine("(U)p, (D)own, (L)eft, (R)ight or (Q)uit:");
                switch (Console.ReadLine())
                {
                    case "U":
                        player.moveUp();
                        break;
                    case "D":
                        player.moveDown();
                        break;
                    case "L":
                        player.moveLeft();
                        break;
                    case "R":
                        player.moveRight();
                        break;
                    case "Q":
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("invalid input...");
                        break;
                }
            }
        }
    }

    class Pac
    {
        public int x, y;
        public Pac()
        {
            x = 5;
            y = 5;
        }
        public Pac(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }
        public void moveUp()
        {
            y = (y + 1) % 10;
        }
        public void moveDown()
        {
            y = (y - 1) + (1 / (y + 1) * 10);
        }
        public void moveLeft()
        {
            x = (x - 1) + (1 / (x + 1) * 10);
        }
        public void moveRight()
        {
            x = (x + 1) % 10;
        }
    }
}

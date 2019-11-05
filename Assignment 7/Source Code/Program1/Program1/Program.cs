using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameWon = false;
            char[] holes = generateHoles();
            // game part
            Console.WriteLine("Find the Rabbit!");
            printHoles(holes, gameWon);
            while (!gameWon)
            {
                Console.Write("Pick a hole (0-9): ");
                int guess = int.Parse(Console.ReadLine());
                if (holes[guess] == 'R') {
                    gameWon = true;
                }else
                {
                    holes[guess] = 'X';
                }
                printHoles(holes, gameWon);
            }
            Console.WriteLine("You found the rabbit!");
        }

        static char[] generateHoles ()
        {
            Random n = new Random();
            char[] holes = new char[10];
            for (int i = 0, rabbit = n.Next(10); i < holes.Length; i++)
            {
                if (i == rabbit)
                {
                    holes[i] = 'R';
                }
                else
                {
                    holes[i] = ' ';
                }
            }
            return holes;
        }

        static void printHoles (char[] holes, bool gameWon)
        {
            for (int i = 0; i < holes.Length; i++)
            {
                Console.Write("|");
                if ((holes[i] == 'R' && gameWon) || holes[i] == 'X')
                {
                    Console.Write(holes[i]);
                }else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("|");
        }
    }
}

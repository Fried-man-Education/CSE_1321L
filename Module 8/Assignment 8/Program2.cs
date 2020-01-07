using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = // basically ascii art
            {
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', 'S', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', 'S', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', 'S', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', 'S', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', 'S', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', 'S', 'S', 'S', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
            };
            while (gameGoing(board)) // while game active
            {
                printBoard(board); // print board
                markSpot(board); // ask user for another spot
            }
            printBoard(board); // final board
            Console.WriteLine("64m3 0v3r");
        }

        static void printBoard(char[,] arr) // print 2d array
        {
            for (int a = 0; a < arr.GetLength(0); a++) // row
            {
                Console.Write("|");
                for (int b = 0; b < arr.GetLength(1); b++) // column
                {
                    if(arr[a, b] == 'S') // hide S
                    {
                        Console.Write(" |");
                    }else
                    {
                        Console.Write(arr[a, b] + "|"); // print value and spacing
                    }
                }
                Console.WriteLine(); // new row
            }
        }

        static void markSpot (char[,] arr) // asks user for input and marks on board
        {
            Console.Write("Enter x: ");
            int b = int.Parse(Console.ReadLine()); // flip the script
            Console.Write("Enter y: ");
            int a = int.Parse(Console.ReadLine()); // flip the script pt. 2
            if (arr[a, b] == ' ') // unused spot
            {
                arr[a, b] = 'X';
            }else if (arr[a, b] == 'S') // found part of ship or rabbit or whatever
            {
                arr[a, b] = '!';
            }
        }

        static bool gameGoing (char[,] arr) // checks to see if game is over
        {
            for (int a = 0; a < arr.GetLength(0); a++) // row
            {
                for (int b = 0; b < arr.GetLength(1); b++) // column
                {
                    if (arr[a, b] == 'S') // hide X
                    {
                        return true; // ships still need to be found
                    }
                }
            }
            return false; // 64m3 0v3r
        }
    }
}

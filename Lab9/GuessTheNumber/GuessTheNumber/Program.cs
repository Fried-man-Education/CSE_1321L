/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		9
*/

using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int highScore = 0;
            while (true)
            {
                Console.WriteLine("Guess the number!");
                Console.WriteLine("Highscore: " + highScore);
                Console.Write("Play? (Y/N): ");
                char response = char.Parse(Console.ReadLine());
                if (response == 'Y')
                {
                    bool gameActive = true;
                    int score = 0;
                    while(gameActive)
                    {
                        Console.Clear();
                        int secret = roll();
                        int n = action();
                        Console.Clear();
                        gameActive = answer(secret, n);
                        if (gameActive)
                        {
                            score++;
                        }else
                        {
                            Console.WriteLine("You lost the game but keep on guessing");
                            while (n != secret) {
                                n = action();
                                answer(secret, n);
                            }
                            Console.WriteLine("Highscore: " + highScore);
                            if (score > highScore)
                            {
                                highScore = score;
                            }
                        }
                        Console.WriteLine("Score: " + score);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }

        static int roll ()
        {
            Random rnd = new Random();
            return rnd.Next(1,21);
        }

        static int action ()
        {
            Console.WriteLine("What is your guess?");
            Console.Write("Guess: ");
            return int.Parse(Console.ReadLine());
        }
                                                                                      
        static bool answer (int secret, int n)
        {
            if (n == secret)
            {
                Console.WriteLine("Your answer was correct!");
                return true;
            }else if (n > secret)
            {
                Console.WriteLine("Your answer was too high!");
            }
            else if (n < secret)
            {
                Console.WriteLine("Your answer was too low!");
            }
            return false;
        }                                                                           
    }
}

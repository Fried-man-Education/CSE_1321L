using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("It is a dark and stormy night. Do you want to take an umbrella? (Y/N) : ");
            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine("Good - you have an umbrella.");
                if (secondPrompt() == "F")
                {
                    Console.WriteLine("You take out your umbrella and jab it into the wolf's paw! It runs away and you live another day.");
                }
                else
                {
                    Console.WriteLine("You begin running so fast, the umbrella opens and you fly away like Mary Poppins.You're a little embarrassed, but you see the wolf fading off in the distance.");
                }
                
            }
            else
            {
                Console.WriteLine("You decide not to take an umbrella.");
                if (secondPrompt() == "F")
                {
                    Console.WriteLine("You begin fighting the wolf only to realize you had just eaten a McGrease® meal earlier.You fall dead from rigorous exercise, having had a heart attack.");
                }else
                {
                    Console.WriteLine("Are you serious? You can't outrun a wolf! The wolf catches you and you are somewhat relieved because you don't have to worry about that Calculus exam…");
                }
            }
        }

        static string secondPrompt ()
        {
            Console.WriteLine();
            Console.Write("You start to walk down a path and hear a scream. You realize that the person screaming is YOU because you see a wolf! Do you fight with your umbrella or run ? ((F)ight / (R)un) : ");
            string response = Console.ReadLine();
            Console.WriteLine();
            return response;
        }
    }
}

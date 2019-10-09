using System;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            do
            {
                Console.WriteLine(Insult(name));
                Console.Write("Shall I taunt you another time [yes/no]? ");
                if (Console.ReadLine() == "no")
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Now go away, you silly English Knnnnniggets!");
        }

        static string Insult(string name)
        {
            var rand = new Random();
            switch(rand.Next(5))
            {
                case 0:
                    return name + ", you look like something that I would draw with my left hand.";
                case 1:
                    return name + ", in spite of what it did to you, don't you love nature?";
                case 2:
                    return name + ", You have the perfect face for radio!";
                case 3:
                    return name + ", you're not as bad as people say. You're a whole lot worse.";
                case 4:
                    return name + ", Wow! You look like a before picture!";
                default:
                    return "error";
            }
            
        }
    }
}

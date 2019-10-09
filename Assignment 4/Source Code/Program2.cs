using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroHP, heroDPS, monsterHP, monsterDPS;
            Random rnd = new Random();
            Console.Write("Enter the hero's starting hit points: ");
            heroHP = int.Parse(Console.ReadLine());
            Console.Write("Enter the damage the hero’s weapon does per strike: ");
            heroDPS = int.Parse(Console.ReadLine());
            Console.Write("Enter the monster's starting hit points: ");
            monsterHP = int.Parse(Console.ReadLine());
            Console.Write("Enter the monster's damage per strike: ");
            monsterDPS = int.Parse(Console.ReadLine());
            for (int i = 1; ; i++)
            {
                Console.WriteLine("====== ROUND " + i + " ======");
                int temp = rnd.Next(heroDPS + 1);
                Console.WriteLine("Hero attacks for: " + temp);
                monsterHP -= temp;
                Console.WriteLine("Monster has " + monsterHP + " HP left");
                if (monsterHP <= 0)
                {
                    Console.WriteLine("The monster dies and you earn 5 XP");
                    break;
                }else
                {
                    temp = rnd.Next(monsterDPS + 1);
                    Console.WriteLine("Monster attacks you for: " + temp);
                    heroHP -= temp;
                    Console.WriteLine("You have " + heroHP + " HP left");
                    if (heroHP <= 0)
                    {
                        Console.WriteLine("You are killed by the monster and lose 10 gold.");
                        break;
                    }
                }
            }
            Console.WriteLine("Battle ends...");
        }
    }
}

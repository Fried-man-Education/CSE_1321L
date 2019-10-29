/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		11
*/

using System;

namespace Radios
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio example = new Radio();
            for (int i = 0; i < 7; i++)
            {
                RandomAction(example);
                example.toString();
                Console.WriteLine();
            }
        }

        static void RandomAction (Radio example)
        {
            Random rnd = new Random();
            switch(rnd.Next(1,5))
            {
                case 1:
                    Console.WriteLine("Turn radio on:");
                    example.turnOn();
                    break;
                case 2:
                    Console.WriteLine("Turn radio off:");
                    example.turnOff();
                    break;
                case 3:
                    int change = rnd.Next(example.getStation() * -1 + 1, 10 - example.getStation());
                    if (change >= 0) {
                        Console.WriteLine("Move station up by " + change + ":");
                        for (int i = 0; i < change; i++)
                        {
                            example.stationUp();
                        }
                    }else
                    {
                        Console.WriteLine("Move station down by " + change * -1 + ":");
                        for (int i = 0; i < change * -1; i++)
                        {
                            example.stationDown();
                        }
                    }
                    break;
                case 4:
                    int change2 = rnd.Next(example.getVolume() * -1 + 1, 10 - example.getVolume());
                    if (change2 >= 0)
                    {
                        Console.WriteLine("Move volume up by " + change2 + ":");
                        for (int i = 0; i < change2; i++)
                        {
                            example.volumeUp();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Move volume down by " + change2 * -1 + ":");
                        for (int i = 0; i < change2 * -1; i++)
                        {
                            example.volumeDown();
                        }
                    }
                    break;
            }
        }
    }

    class Radio
    {
        private int station = 1;
        private int volume = 1;
        private bool on = false;
        public Radio()
        {
        }
        public int getStation()
        {
            return station;
        }
        public int getVolume()
        {
            return volume;
        }
        public void turnOn()
        {
            on = true;
        }
        public void turnOff()
        {
            on = false;
        }
        public void stationUp()
        {
            station++;
        }
        public void stationDown()
        {
            station--;
        }
        public void volumeUp()
        {
            volume++;
        }
        public void volumeDown()
        {
            volume--;
        }
        public void toString()
        {
            if (on)
            {
                Console.WriteLine("The radio station is " + station + " and the volume level is " + volume + ".");
            }else
            {
                Console.WriteLine("The radio is off.");
            }
        }
    }
}

using System;

namespace Task7
{
    public class Player
    {
        public string PlayerName;
        public int Level;
        public int Health;

        // Default constructor
        public Player()
        {
            Console.WriteLine("Default constructor called.");
        }

        // Parameterized constructor
        public Player(string name, int lvl, int hp)
        {
            PlayerName = name;
            Level = lvl;
            Health = hp;
        }
    }
}
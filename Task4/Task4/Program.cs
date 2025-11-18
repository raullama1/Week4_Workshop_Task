using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();  // calls default constructor
            Player p2 = new Player("Raul", 10, 100);  // calls parameterized constructor

            // display p2 details
            Console.WriteLine(p2.playerName + ", " + p2.level + ", " + p2.health);
        }
    }
}
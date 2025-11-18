using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks: ");
            bool m = int.TryParse(Console.ReadLine(), out int marks);

            Console.Write("Enter total: ");
            bool t = int.TryParse(Console.ReadLine(), out int total);

            // BREAKPOINT 1 — before calculation

            double percentage = (double)marks / total * 100;

            // BREAKPOINT 2 — after calculation

            Console.WriteLine("Percentage: " + percentage + "%");
        }
    }
}
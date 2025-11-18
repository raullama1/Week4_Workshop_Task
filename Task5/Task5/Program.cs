using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to enter a day
            Console.Write("Enter day: ");
            string day = Console.ReadLine().ToLower();

            // check if it's weekend
            if (day == "friday" || day == "saturday")
            {
                Console.WriteLine("It is: Weekend");
            }
            else
            {
                Console.WriteLine("It is: Weekday");
            }

            // create first book
            Book b1 = new Book("C#", "Raul Lama", 9.99);

            // create second book using 'with'
            Book b2 = b1 with { title = "C# Advance", price = 19.99 };

            // print first book
            Console.WriteLine(b1);

            // deconstruct second book and print values
            var (t, a, p) = b2;
            Console.WriteLine(t + ", " + a + ", " + p);
        }
    }
}
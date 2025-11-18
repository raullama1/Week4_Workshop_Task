using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object
            Calculator c = new Calculator();

            // Calling welcome method
            c.Welcome();

            // Calling Add method and printing
            Console.WriteLine("Addition: " + c.Add(10, 20));
            
            // Multiply using only one input (num2 will be 1 by default)
            Console.WriteLine("Multiply (one input): " + c.Multiply(11));

            // Multiply using both inputs
            Console.WriteLine("Multiply (two inputs): " + c.Multiply(2, 3));
        }
    }
}
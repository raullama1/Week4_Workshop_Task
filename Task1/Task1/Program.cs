using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // First object
            Student s1 = new Student();
            s1.name = "Raul";
            s1.age = 20;
            s1.section = "C7";
            
            // Second object
            Student s2 = new Student();
            s2.name = "Tenta";
            s2.age = 21;
            s2.section = "C1";
            
            // Print first object
            Console.WriteLine("Student 1: ");
            Console.WriteLine($"Name: {s1.name}, Age: {s1.age}, Section: {s1.section}");
            
            // Print second object
            Console.WriteLine("Student 2: ");
            Console.WriteLine($"Name: {s2.name}, Age: {s2.age}, Section: {s2.section}");
            
            // Print static
            Console.WriteLine($"Major: {Student.major}");
        }
    }
}
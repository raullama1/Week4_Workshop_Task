using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example: Constructors
            Player p1 = new Player(); // default constructor
            Player p2 = new Player("Raul", 10, 100); // parameterized constructor
            Console.WriteLine($"{p2.PlayerName}, Level: {p2.Level}, Health: {p2.Health}");

            // Example: Encapsulation - BankAccount
            BankAccount account = new BankAccount();
            account.Deposit(500);
            Console.WriteLine("Account balance: " + account.GetBalance());

            // Example: Encapsulation - Student
            Student student = new Student();
            student.SetMarks(95);
            Console.WriteLine("Student marks: " + student.GetMarks());
        }
    }
}
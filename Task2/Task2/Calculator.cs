namespace Task2;

public class Calculator
{
    // Method to show Welcome message.
    public void Welcome()
    {
        Console.WriteLine("Welcome to the Calculator"); 
    }
    
    // Method for adding two numbers.
    public int Add(int num1, int num2)
    {
        return num1 + num2; 
    }

    // Method for multiplying two numbers where num2 default value is 1.
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
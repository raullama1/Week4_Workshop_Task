using System;

namespace Task3;
class Program
{
    static void Main(string[] args)
    {
        ParameterDemo p = new ParameterDemo();

        // ref example
        int value = 5;
        p.Increase(ref value);  // value becomes 15
        Console.WriteLine(value);

        // out example
        p.GetFullName(out string myName);  // myName is assigned inside method
        Console.WriteLine(myName);

        // params example
        int total = p.SumAll(1, 2, 3, 4, 5);  // sums all numbers
        Console.WriteLine("Sum: " + total);

    }
}
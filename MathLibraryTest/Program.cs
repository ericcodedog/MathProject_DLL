using System;
using MathLibrary;

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Console.WriteLine("5 + 3 = " + math.Add(5, 3));
        Console.WriteLine("10 - 7 = " + math.Subtract(10, 7));
        Console.WriteLine("20 / 4 = " + math.Divide(20, 4));
        Console.WriteLine("20 * 4 = " + math.Multiply(20, 4));
        Console.WriteLine("8 / 0 = " + math.Divide(8, 0));
    }
}

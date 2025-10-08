using System;
class Program
{
    static void Calculate(int x, int y)
    {
        Console.WriteLine("Sum: " + (x + y));
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Calculate(a, b); // call method
    }
}